using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using NLog;

namespace LDWordProcessor
{
    public class SpellCheckerIgnore
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private List<SpellWordIgnoreEntry> ignoreList;
        private int file_id;

        public SpellCheckerIgnore(LDFileBinding file)
        {
            ignoreList = new List<SpellWordIgnoreEntry>();
            Load(file);
        }

        protected virtual void Dispose()
        {
            ignoreList.Clear();
            ignoreList = null;
        }

        private void Load(LDFileBinding file)
        {
            file_id = file.FileID;
            string sql = String.Format("SELECT * FROM files_ignorelist WHERE file_id={0}", file_id);
            DataRowCollection rows = DBManager.GetInstance().ExecSQL(sql);
            if (rows != null)
            {
                foreach (DataRow row in rows)
                {
                    ignoreList.Add(new SpellWordIgnoreEntry(row["word"].ToString(), Int16.Parse(row["position"].ToString())));
                }
            }
        }

        public void AddIgnore(MisSpellingEntry entry)
        {
            ignoreList.Add(new SpellWordIgnoreEntry(entry.Text, entry.Start, true));
        }

        public void AddIgnoreAll(MisSpellingEntry entry)
        {
            ignoreList.Add(new SpellWordIgnoreEntry(entry.Text, -1, true));
        }

        public bool Exist(string word, int position)
        {
            var items = from item in ignoreList
                        where (item.Text == word)
                        orderby item.Position
                        select item;

            foreach (var t in items)
            {
                return (t.Position == -1) || (t.Position == position);
            }

            return false;
        }

        public void Save(LDFileBinding file)
        {
           
            var items = from item in ignoreList
                        where (item.IsNew)
                        orderby item.Position
                        select item;

            if (items.Count() > 0)
            {
                StringBuilder sb = new StringBuilder("INSERT INTO files_ignorelist (file_id,word, position) VALUES ");
                foreach (var t in items)
                {
                    sb.AppendFormat("({0},'{1}',{2}),", file.FileID, t.Text, t.Position);
                    t.IsNew = false;
                }
                sb.Remove(sb.Length-1, 1); //remove last ,

                DBManager.GetInstance().ExecSQL(sb.ToString());
            }
        }
    }
}

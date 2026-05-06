using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using NLog;

namespace LDWordProcessor
{
    public class SpellChecked
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private List<SpellCheckedEntry> ignoreList;
        private int file_id;

        public SpellChecked(LDFileBinding file)
        {
            ignoreList = new List<SpellCheckedEntry>();
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
            string sql = String.Format("SELECT * FROM files_checked WHERE file_id={0}", file_id);
            DataRowCollection rows = DBManager.GetInstance().ExecSQL(sql);
            if (rows != null)
            {
                foreach (DataRow row in rows)
                {
                    ignoreList.Add(new SpellCheckedEntry(row["md5"].ToString(), row["paragraph"].ToString() , false));
                }
            }
        }

        public void Add(string s)
        {
            if (s != null && s.Length > 0)
            {
                ignoreList.Add(new SpellCheckedEntry(MD5Helper.GetMd5Hash(s), s , true));
                logger.Debug("checked: {0}{1}", MD5Helper.GetMd5Hash(s), s);
            }
        }

        public bool Exist(string s)
        {
            if (s != null)
            {
                var items = from item in ignoreList
                            where (item.MD5 == MD5Helper.GetMd5Hash(s))
                            select item;

                return items.Count() > 0;
            }
            else
            {
                return true;
            }
        }

        public void Save(LDFileBinding file)
        {
           
            var items = from item in ignoreList
                        where (item.IsNew)
                        select item;

            if (items.Count() > 0)
            {
                StringBuilder sb = new StringBuilder("INSERT INTO files_checked (file_id, md5, paragraph) VALUES ");
                foreach (var t in items)
                {
                    sb.AppendFormat("({0},'{1}','{2}'),", file.FileID, t.MD5, t.Text);
                    t.IsNew = false;
                }
                sb.Remove(sb.Length-1, 1); //remove last ,

                DBManager.GetInstance().ExecSQL(sb.ToString());
            }
        }
    }
}

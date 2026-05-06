using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace LDWordProcessor
{
    public class UserDict
    {
        private List<UserDictEntry> custom;
        private int user_id;

        public UserDict(int user_id)
        {
            custom = new List<UserDictEntry>();
            this.user_id = user_id;
            Load();
        }

        private void Load()
        {
            string sql = String.Format("SELECT * FROM users_dict WHERE user_id={0}", user_id);
            DataRowCollection rows = DBManager.GetInstance().ExecSQL(sql);
            if (rows != null)
            {
                foreach (DataRow row in rows)
                {
                    custom.Add(new UserDictEntry(row["word"].ToString(), false));
                }
            }
        }

        public bool Exist(string s)
        {
            var items = from item in custom
                        orderby item
                        where item.Word == s
                        select item;

            return items.Count() > 0;
        }

        public void Add(string word)
        {
            custom.Add(new UserDictEntry(word, true));
        }

        public void Save()
        {
            StringBuilder sb = new StringBuilder("INSERT INTO users_dict (user_id, word) VALUES ");
            bool hasNew = false;
            foreach (var c in custom)
            {
                if (c.IsNew)
                {
                    sb.AppendFormat("({0},'{1}'),", user_id, c.Word);
                    hasNew = true;
                }
            }
            if (hasNew)
            {
                sb.Remove(sb.Length - 1, 1); //remove last ,

                DBManager.GetInstance().ExecSQL(sb.ToString());
            }
        }
    }
}

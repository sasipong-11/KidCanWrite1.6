using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;
using NLog;
using System.IO;

namespace LDWordProcessor
{
    class LDLogger
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public static bool Logout(int user_id, string date_open, string date_closed)
        {
            string sql = String.Format("INSERT INTO users_access_log (user_id , date_open , date_closed) VALUES ({0}, '{1}', '{2}');", user_id, date_open, date_closed);
            return DBManager.GetInstance().ExecNonSQL(sql);
        }

        public static bool Completion(int file_id, int user_id, string word_start, string word_selected)
        {
            string sql = String.Format("INSERT INTO log_completion (file_id, user_id, word_start, word_selected) VALUES ({0},{1},'{2}','{3}');", file_id, user_id, word_start, word_selected);
            return DBManager.GetInstance().ExecNonSQL(sql);
        }

        public static bool Prediction(int file_id, int user_id, string word_start, string word_selected)
        {
            string sql = String.Format("INSERT INTO log_prediction (file_id, user_id, word_start, word_selected) VALUES ({0},{1},'{2}','{3}');", file_id, user_id, word_start, word_selected);
            return DBManager.GetInstance().ExecNonSQL(sql);
        }

        public static bool Suggestion(int file_id, int user_id, string mistype, string misspell, string word_selected)
        {
            string sql = String.Format("INSERT INTO log_suggestion(file_id, user_id , wrong_type , wrong_word , selected_word) VALUES ({0},{1},'{2}','{3}','{4}')",
                file_id, user_id, mistype, misspell, word_selected);
            return DBManager.GetInstance().ExecNonSQL(sql);
        }

        public static bool ClearCache()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("DELETE FROM log_completion WHERE file_id=0;");
            sb.Append("DELETE FROM log_prediction WHERE file_id=0;");
            sb.Append("DELETE FROM log_suggestion WHERE file_id=0;");
            sb.Append("DELETE FROM files_checked WHERE file_id=0;");
            string sql = sb.ToString();
            return DBManager.GetInstance().ExecNonSQL(sql);
        }

        public static bool SaveCache(int user_id, int file_id)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("UPDATE log_completion SET file_id={1} WHERE file_id=0 and user_id={0};", user_id, file_id);
            sb.AppendFormat("UPDATE log_prediction SET file_id={1} WHERE file_id=0 and user_id={0};", user_id, file_id);
            sb.AppendFormat("UPDATE log_suggestion SET file_id={1} WHERE file_id=0 and user_id={0};", user_id, file_id);
            //sb.AppendFormat("UPDATE files_checked SET file_id={0} WHERE file_id=0;", file_id);
            string sql = sb.ToString();
            return DBManager.GetInstance().ExecNonSQL(sql);
        }

    }
}

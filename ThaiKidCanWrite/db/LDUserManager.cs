using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Web.Script.Serialization;

namespace LDWordProcessor
{
    public class LDUserManager
    {
        public static int AddWork(SWorkModel work)
        {
            string create_date = DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss");
            string sql = String.Format("INSERT INTO works (step, q1, q2, q3, q4, q5, q6, q7, q8, q9, q10, q11, q12, send, date_create, mid, mapid) "
                + "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}');"
                , 1, work.q1, work.q2, work.q3, work.q4, work.q5, work.q6, work.q7, work.q8, work.q9, work.q10, work.q11, work.q12, 0,create_date, work.mid, work.mapid);
            Program.workData.id = "1";
            return DBManager.GetInstance().ExecNonSQL_ID(sql);
        }

        public static List<SWorkModel> LoadWorks()
        {
            List<SWorkModel> works = new List<SWorkModel>();
            DataRowCollection rows = DBManager.GetInstance().ExecSQL("SELECT id,title,q1 FROM works");
            if (rows != null && rows.Count > 0)
            {
                foreach (DataRow row in rows)
                {
                    SWorkModel work = new SWorkModel();
                    work.id = row["id"].ToString();
                    work.q1 = row["q1"].ToString();
                    work.title = row["title"].ToString();
                    works.Add(work);
                }
               
            }
            return works;
        }

        public static bool UpdateTitleWork(SWorkModel work)
        {
            string update_date = DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss");
            string sql = String.Format("UPDATE works SET title='{0}',date_update ='{1}'  WHERE id='{2}'",work.title, update_date, work.id);
            return DBManager.GetInstance().ExecNonSQL(sql);
        }

        public static bool SendWork(SWorkModel work)
        {
            string update_date = DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss");
            string sql = String.Format("UPDATE works SET send='{0}',date_update ='{1}'  WHERE id='{2}'",work.send, update_date, work.id);
            return DBManager.GetInstance().ExecNonSQL(sql);
        }
        public static int AddWorkDetail(SWorkDetailModel detail)
        {
            string sql = String.Format("INSERT INTO works_detail (wid, sentent, type, `order`) " + "VALUES ({0},'{1}','{2}',{3}) OUTPUT INSERTED.ID VALUES (@IDInsert);",
                detail.wid, detail.sentent, detail.type, detail.order);
            return DBManager.GetInstance().ExecNonSQL_ID(sql);
        }

        public static bool _Logout()
        {
            string sql = String.Format("delete from users");

            return DBManager.GetInstance().ExecNonSQL(sql);
        }
      
        public static bool AddUser(LDUserBinding user)
        {
            string create_date = DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss");
            string sql = String.Format("INSERT OR REPLACE INTO users (user_id, username, password, firstname, surname, create_date) "
                + "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}');", user.UserID ,user.Username, user.Password, user.Firstname, user.Surname, create_date);
            return DBManager.GetInstance().ExecNonSQL(sql);
        }

        public static LDUserBinding LoadUser(int user_id)
        {
            LDUserBinding user = new LDUserBinding();
            DataRowCollection rows = DBManager.GetInstance().ExecSQL("SELECT * FROM users WHERE user_id=" + user_id + "");
            if (rows != null && rows.Count > 0)
            {
                DataRow row = rows[0];
                user.UserID = user_id;
                user.Username = row["username"].ToString();
                user.Password = row["password"].ToString();
                user.Firstname = row["firstname"].ToString();
                user.Surname = row["surname"].ToString();
                user.CreateDate = row["create_date"].ToString();
                user.LastAccess = row["last_access"].ToString();
            }
            return user;
        }

        public static bool SaveUser(LDUserBinding user)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("UPDATE users SET username=\"").Append(user.Username).Append("\", ");
            sb.Append("password=\"").Append(user.Password).Append("\", ");
            sb.Append("firstname=\"").Append(user.Firstname).Append("\", ");
            sb.Append("surname=\"").Append(user.Surname).Append("\", ");
            sb.Append("last_access=\"").Append(user.LastAccess).Append("\" ");
            sb.Append("WHERE username=\"").Append(user.Username).Append("\" ");
            string sql = sb.ToString();
            return DBManager.GetInstance().ExecNonSQL(sql);
        }

        public static void Logout(LDUserBinding user)
        {
            LDLogger.Logout(user.UserID, user.LastAccess, DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss"));
        }                                                                                      
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;

namespace LDWordProcessor
{
    public class LDFileBinding
    {
        private int fileID;

        public int FileID
        {
            get { return fileID; }
            set { fileID = value; }
        }
        private int userID;

        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        private string path;

        public string Path
        {
            get { return path; }
            set { path = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string lastModified;

        public string LastModified
        {
            get { return lastModified; }
            set { lastModified = value; }
        }

        private bool isNew;

        public bool IsNew
        {
            get { return isNew; }
            set { isNew = value; }
        }

        public bool IsExist()
        {
            return File.Exists(Path);
        }

        private string nameGenAuto;

        public string NameGenAuto
        {
            get { return nameGenAuto; }
            set { nameGenAuto = value; }
        }
    }



    public class LDFileManager
    {
       // public const string DEFAULT_FILENAME = "เอกสาร1";
        public const string DEFAULT_FILENAME = "D:\\เอกสาร1.docx";

        public static LDFileBinding CreateFileItem(int user_id)
        {
            LDFileBinding f = new LDFileBinding();
            string filename = DateTime.Now.ToString("yyyyMMddHHmmss").ToString() + ".docx";
            f.FileID = 0;
            f.Name = filename;
            f.NameGenAuto = filename;
            f.Path = "D:\\" + filename;
            f.LastModified = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            f.IsNew = true;
            return f;
        }

        public static LDFileBinding LoadFileItem(string path)
        {
            string selectSQL = "SELECT * FROM files WHERE path='" + path + "'";
            DataRowCollection rows = DBManager.GetInstance().ExecSQL(selectSQL);
            if (rows != null && rows.Count > 0)
            {
                DataRow row = rows[0];

                LDFileBinding f = new LDFileBinding();
                f.FileID = Int16.Parse(row["file_id"].ToString());
                f.UserID = Int16.Parse(row["user_id"].ToString());
                f.Path = row["path"].ToString();
                f.LastModified = row["last_modified"].ToString();
                f.IsNew = false;

                return f;
            }

            return null;
        }

        public static void ClearTempFile()
        {
            string deleteSQL = "DELETE FROM files_ignorelist WHERE file_id = 0;DELETE FROM files_checked WHERE file_id = 0;";
            DBManager.GetInstance().ExecNonSQL(deleteSQL);
        }

        public static bool SaveDocument(LDFileBinding file)
        {
            string sql = String.Format("UPDATE files SET last_modified='{1}' WHERE file_id='{0}'", file.FileID, file.LastModified);
            return DBManager.GetInstance().ExecNonSQL(sql);
        }

        public static int SaveDocumentAs(int user_id, string path)
        {
            string sql = String.Format("INSERT INTO files (user_id, path, last_modified) VALUES ({0},'{1}','{2}')", user_id, path, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            if (DBManager.GetInstance().ExecNonSQL(sql))
            {
                int file_id = DBManager.GetInstance().ExecSQLInt("SELECT last_insert_rowid();");
                //update temp log
                LDLogger.SaveCache(user_id, file_id);
                return file_id;
            }
            else
            {
                return -1;
            }
        }

        public static List<LDFileBinding> GetRecentFiles(int user_id)
        {
            List<LDFileBinding> fileList = new List<LDFileBinding>();
            List<LDFileBinding> fileLostList = new List<LDFileBinding>();
            string selectSQL = "SELECT * FROM files WHERE user_id='" + user_id + "' ORDER BY last_modified DESC";
            DataRowCollection rows = DBManager.GetInstance().ExecSQL(selectSQL);
            if (rows != null && rows.Count > 0)
            {
                foreach (DataRow row in rows)
                {
                    LDFileBinding f = new LDFileBinding();
                    f.FileID = Int16.Parse(row["file_id"].ToString());
                    f.UserID = Int16.Parse(row["user_id"].ToString());
                    f.Path = row["path"].ToString();
                    f.LastModified = row["last_modified"].ToString();
                    f.IsNew = false;

                    if (!f.IsExist())
                    {
                        fileLostList.Add(f);
                    }
                    else
                    {
                        fileList.Add(f);
                    }
                }
            }

            foreach (var f in fileLostList)
            {
                DeleteRecentFiles(f);
            }

            return fileList;
        }

        public static void DeleteRecentFiles(LDFileBinding f)
        {
            string sql = "DELETE FROM files WHERE file_id="+f.FileID;
            DBManager.GetInstance().ExecNonSQL(sql);
        }
    }
}

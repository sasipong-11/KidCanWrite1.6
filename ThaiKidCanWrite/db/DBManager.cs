using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using NLog;
using System.Data;
using System.Data.Common;

namespace LDWordProcessor
{
    public class DBManager
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private string dbConnectionString = @"Data Source=user_log.dat;Version=3;New=False;";
        private SQLiteConnection conn;
        private static DBManager instance;

        public DBManager()
        {
            conn = new SQLiteConnection(dbConnectionString);
            Connect();
        }

        public static DBManager GetInstance()
        {
            if (instance == null)
            {
                instance = new DBManager();
            }

            return instance;
        }

        public bool Connect()
        {
            try
            {
                conn.Open();
                logger.Debug("Database connected.");
                return true;
            }
            catch (Exception e)
            {
                logger.Error(e.Message);
                return false;
            }
        }

        public void Disconnect()
        {
            if (conn != null)
            {
                conn.Close();
                logger.Debug("Database disconnected.");
            }
        }

        public bool ExecNonSQL(string sql)
        {
            try
            {
                logger.Debug("SQL Execute: {0}", sql);
                SQLiteCommand cmd = new SQLiteCommand(conn);
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                 return true;
            }
            catch (Exception ex)
            {
                logger.Error("{0}::{1}", sql, ex.Message);
                return false;
            }
        }
        public int ExecNonSQL_ID(string sql)
        {
            try
            {
                logger.Debug("SQL Execute: {0}", sql);
                SQLiteCommand cmd = new SQLiteCommand(conn);
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                var newId = cmd.ExecuteScalar();
                //int id = (int)cmd.ExecuteScalar();
                return 1;
            }
            catch (Exception ex)
            {
                logger.Error("{0}::{1}", sql, ex.Message);
                return 0;
            }
        }
        public DataRowCollection ExecSQL(string sql)
        {
            DataSet ds = new DataSet();
            try
            {
                logger.Debug("SQL Query: {0}", sql);
                var da = new SQLiteDataAdapter(sql, conn);
                da.Fill(ds);

                if (ds.Tables[0] != null)
                {
                    return ds.Tables[0].Rows;
                }
            }
            catch (Exception ex)
            {
                logger.Error("{0}::{1}", sql, ex.Message);
            }
            
            return null;
        }

        public int ExecCountSQL(string sql)
        {
            return ExecSQLInt(sql);
        }

        public int ExecSQLInt(string sql)
        {
            DataRowCollection rows = ExecSQL(sql);
            Int64 ret = 0;
            if (rows != null && rows.Count > 0)
            {
                DataRow row = rows[0];
                ret = (Int64)row[0];
            }
            logger.Debug("Ret: {0}", ret);
            return (int) ret;
        }
    }
}

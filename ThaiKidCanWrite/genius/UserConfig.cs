using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace LDWordProcessor
{
    public class UserConfigBinding
    {
        private int userID;
        public int Speed;
        public int Volume;
        public bool AutoComplete;
        public bool Prediction;

        public UserConfigBinding(int user_id){
            userID = user_id;
            string sql = String.Format("SELECT * FROM users_config WHERE user_id={0}", user_id);
            DataRowCollection rows = DBManager.GetInstance().ExecSQL(sql);
            Speed = 0;
            Volume = 100;
            AutoComplete = true;
            Prediction = true;

            if (rows != null && rows.Count > 0)
            {
                int b1 = 1, b2 = 1;
                DataRow row = rows[0];
                Int32.TryParse(row["speed"].ToString(), out Speed);
                Int32.TryParse(row["volume"].ToString(), out Volume);
                Int32.TryParse(row["autocomplete"].ToString(), out b1);
                Int32.TryParse(row["prediction"].ToString(), out b2);

                if (b1 == 1) AutoComplete = true;
                if (b2 == 1) Prediction = true;
            }
        }

        public void Save()
        {
            int b1 = AutoComplete ? 1 : 0;
            int b2 = Prediction ? 1 : 0;

            string sql = String.Format("UPDATE users_config SET speed={0}, volume={1}, autocomplete={2}, prediction={3} WHREE user_id={4};",
                Speed, Volume, b1, b2, userID);
            DBManager.GetInstance().ExecNonSQL(sql);
        }

    }
}

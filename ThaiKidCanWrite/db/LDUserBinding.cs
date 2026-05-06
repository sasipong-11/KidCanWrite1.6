using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;

namespace LDWordProcessor
{
    public class LDUserBinding
    {
        private int user_id;
        private static UserConfigBinding settings;
        private static UserDict dict;

        public int UserID
        {
            get { return user_id; }
            set { user_id = value; }
        }

        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private string firstname;

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }
        private string surname;

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        private string createDate;

        public string CreateDate
        {
            get { return createDate; }
            set { createDate = value; }
        }

        private string lastAccess;

        public string LastAccess
        {
            get { return lastAccess; }
            set { lastAccess = value; }
        }

        public override string ToString()
        {
            return firstname + " " + surname;
        }

        public List<LDFileBinding> GetRecentFiles()
        {
            return LDFileManager.GetRecentFiles(user_id);
        }

        public void SelectPrediction(int file_id, string word_start, string word_selected)
        {
            LDLogger.Prediction(file_id, user_id, word_start, word_selected);
        }

        public void SelectCompletion(int file_id, string word_start, string word_selected)
        {
            LDLogger.Completion(file_id, user_id, word_start, word_selected);
        }

        public void SelectSuggestion(int file_id, string mistype, string misspell, string word_selected)
        {
            LDLogger.Suggestion(file_id, user_id, mistype, misspell, word_selected);
        }

        public void Logout()
        {
            LDUserManager.Logout(this);
        }

        public void Save()
        {
            LDUserManager.SaveUser(this);
        }

        public UserConfigBinding Settings
        {
            get {
                if (settings == null) settings = new UserConfigBinding(user_id);
                return settings; 
            }
        }

        public UserDict UserDict
        {
            get {
                if (dict == null) dict = new UserDict(1);

                return dict;
            }
        }

    }
}

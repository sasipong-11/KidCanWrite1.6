using System;
using System.IO;
using System.Collections;
using System.Text;
using System.Collections.Generic;
using Microsoft.Win32;
using System.Security;
using System.Drawing;
using System.Security.Permissions;

using System.Windows.Forms;
using EnCryptDecrypt;

#pragma warning disable 0436
 
namespace LDWordProcessor
{
    class WPControls
    {
        private static string CurPath { get; set; }
        private static string CurUser { get; set; }
        private static string CurDict { get; set; }
        private static bool DictUpdate { get; set; }
        public static Font FontName { get; set; }
        public static Color FontColor { get; set; }
        private static SortedList SysConfig = new SortedList();
        private static ArrayList AllUser = new ArrayList();

        /// <summary>
        /// Check file system by current username  
        /// </summary>
        /// <returns>boolean</returns>
        public static bool ChkFileSysUser()
        {
            if (File.Exists(Environment.CurrentDirectory + "\\User\\Theme\\" + CurUser + ".dat"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Set current username
        /// </summary>
        /// <param name="name">string</param>
        public static void SetCurUser(string name)
        {
            CurUser = name;
        }
        /// <summary>
        /// Get current username
        /// </summary>
        /// <returns>string</returns>
        public static string GetCurUser()
        {
            return CurUser;
        }
        /// <summary>
        /// Set current Dict
        /// </summary>
        /// <param name="name">string</param>
        public static void SetCurDict(string name)
        {
            CurDict = name;
        }
        /// <summary>
        /// Get current Dict
        /// </summary>
        /// <returns>string</returns>
        public static string GetCurDict()
        {
            return CurDict;
        }
        /// <summary>
        ///  Load Systems config
        /// </summary>
        public static void LoadSysConfig()
        {
            try
            {
                ClearSysConfig();
                if (ChkFileSysUser())
                {
                    using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\User\\Theme\\" + GetCurUser() + ".dat", FileMode.Open))
                    {
                        StreamReader sr = new StreamReader(fs, Encoding.Default);
                        string line;
                        string[] split;
                        while ((line = sr.ReadLine()) != null)
                        {
                            if (line == "") continue;
                            split = CryptorEngine.Decrypt(line, true).Split(':');
                            SetSysConfig(split[0], split[1]);
                        }
                    }
                }
                else
                {
                    if (File.Exists(Environment.CurrentDirectory + "\\ThemeRemember.dat"))
                    {
                        using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\ThemeRemember.dat", FileMode.Open))
                        {
                            StreamReader sr = new StreamReader(fs, Encoding.Default);
                            string line;
                            string[] split;
                            while ((line = sr.ReadLine()) != null)
                            {
                                split = CryptorEngine.Decrypt(line, true).Split(':');
                                SetSysConfig(split[0], split[1]);
                            }
                        }
                    }
                    else
                    {
                        using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\ThemeRemember.dat", FileMode.CreateNew))
                        {
                            StreamWriter sr = new StreamWriter(fs, Encoding.Default);
                            sr.WriteLine(CryptorEngine.Encrypt("Theme:0", true));
                            sr.WriteLine(CryptorEngine.Encrypt("TTS_open:1", true));
                            sr.WriteLine(CryptorEngine.Encrypt("DataBase_update:0", true));
                            sr.WriteLine(CryptorEngine.Encrypt("TTS_speed:-1", true));
                            sr.WriteLine(CryptorEngine.Encrypt("Menu_thai:1", true));
                            sr.WriteLine(CryptorEngine.Encrypt("FontName:Angsana New", true));
                            sr.WriteLine(CryptorEngine.Encrypt("FontSize:18.0", true));
                            sr.WriteLine(CryptorEngine.Encrypt("FontStyle:Bold", true));
                            sr.WriteLine(CryptorEngine.Encrypt("FontColor:Black", true));
                            sr.Flush();
                            sr.Dispose();
                        }
                        SetSysConfig("Theme", "0");
                        SetSysConfig("TTS_open", "1");
                        SetSysConfig("DataBase_update", "0");
                        SetSysConfig("TTS_speed", "-1");
                        SetSysConfig("Menu_thai", "1");
                        SetSysConfig("FontName", "Angsana New");
                        SetSysConfig("FontSize", "18.0");
                        SetSysConfig("FontStyle", "Bold");
                        SetSysConfig("FontColor", "Black");
                    }
                }
            }
            catch
            {
                SetSysConfig("Theme", "0");
                SetSysConfig("TTS_open", "1");
                SetSysConfig("DataBase_update", "0");
                SetSysConfig("TTS_speed", "-1");
                SetSysConfig("Menu_thai", "1");
                SetSysConfig("FontName", "Angsana New");
                SetSysConfig("FontSize", "18.0");
                SetSysConfig("FontStyle", "Bold");
                SetSysConfig("FontColor", "Black");
            }
            FontStyle FS = new FontStyle();
            switch (GetSysConfig("FontStyle"))
            {
                case "Bold": FS = FontStyle.Bold; break;
                case "Italic": FS = FontStyle.Italic; break;
                case "Regular": FS = FontStyle.Regular; break;
                case "Strikeout": FS = FontStyle.Strikeout; break;
                case "Underline": FS = FontStyle.Underline; break;
            }
            FontName = new Font(GetSysConfig("FontName"), (float)Convert.ToDouble(GetSysConfig("FontSize")), FS);
            FontColor = Color.FromName(GetSysConfig("FontColor")); // Color.Black;

        }
        /// <summary>
        /// Set Systems Config 
        /// 1. Theme
        /// 2. TTS_open
        /// 3. DataBase_update
        /// 4. TTS_speed
        /// 5. Menu_thai
        /// </summary>
        /// <param name="key">string</param>
        /// <param name="value">string</param>
        public static void SetSysConfig(string key, string value)
        {
            try
            {
                SysConfig.Add(key, value);
            }
            catch
            {
                SysConfig.Remove(key);
                SysConfig.Add(key, value);
            }
        }
        /// <summary>
        /// Get Systems Config 
        /// 1. Theme
        /// 2. TTS_open
        /// 3. DataBase_update
        /// 4. TTS_speed
        /// 5. Menu_thai
        /// </summary>
        /// <param name="key">string</param>
        /// <returns>string</returns>
        public static string GetSysConfig(string key)
        {
            switch (key)
            {
                case "Theme": return SysConfig["Theme"].ToString();
                case "TTS_open": return SysConfig["TTS_open"].ToString();
                case "DataBase_update": return SysConfig["DataBase_update"].ToString();
                case "TTS_speed": return SysConfig["TTS_speed"].ToString();
                case "Menu_thai": return SysConfig["Menu_thai"].ToString();
                case "FontName": return SysConfig["FontName"].ToString();
                case "FontSize": return SysConfig["FontSize"].ToString();
                case "FontStyle": return SysConfig["FontStyle"].ToString();
                case "FontColor": return SysConfig["FontColor"].ToString();
                default: return "null";
            }
        }
        /// <summary>
        /// Clear all systems config
        /// </summary>
        public static void ClearSysConfig()
        {
            SysConfig.Clear();
        }
        /// <summary>
        ///  Load all username
        /// </summary>
        public static void LoadAllUser()
        {
            AllUser.Clear();
            // load ini config default
            if (File.Exists(Environment.CurrentDirectory + "\\Username.txt"))
            {
                // found username.txt
                using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\Username.txt", FileMode.Open))
                {
                    StreamReader sr = new StreamReader(fs, Encoding.Default);
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Trim() == "") continue;
                        SetUser(line);
                    }
                }
            }
            else
            {
                // Not found username.txt
                using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\Username.txt", FileMode.CreateNew))
                {
                    StreamWriter writer = new StreamWriter(fs, Encoding.Default);
                    writer.WriteLine("ผู้ใช้ทั่วไป");
                    writer.Flush();
                    writer.Dispose();
                    FileStream fs2 = new FileStream(Environment.CurrentDirectory + "\\Username.txt", FileMode.Open);
                    using (StreamReader sr = new StreamReader(fs2, Encoding.Default))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            if (line.Trim() == "") continue;
                            SetUser(line);
                        }
                    }
                }
            }


        }
        /// <summary>
        /// Set all username
        /// </summary>
        public static void SetUser(string name)
        {
            try
            {
                if (AllUser.Contains(name) == false)
                    AllUser.Add(name);
            }
            catch { }
        }
        /// <summary>
        ///  Get  all username
        /// </summary>
        /// <returns></returns>
        public static ArrayList GetAllUser()
        {
            return AllUser;
        }
        /// <summary>
        /// Clear all username
        /// </summary>
        public static void ClearAllUser()
        {
            AllUser.Clear();
        }
        /// <summary>
        /// Write log in username mode["START","END"]
        /// </summary>
        /// <param name="mode">string</param>
        public static void LogWriteIO(string mode)
        {
            try
            {
                using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\User\\Log\\" + GetCurUser() + "-" + GetCurDict() + "-" + String.Format("{0:dd_MM_yyyy}", DateTime.Now) + ".txt", FileMode.Append))
                {
                    StreamWriter writer = new StreamWriter(fs, Encoding.Default);
                    switch (mode.ToUpper())
                    {
                        case "START": writer.WriteLine("#วันเวลาที่เปิด " + String.Format("{0:dd_MM_yyyy}", DateTime.Now)); break;
                        case "END": writer.WriteLine("#วันเวลาที่ปิด " + String.Format("{0:dd_MM_yyyy}", DateTime.Now)); break;
                        default: break;
                    }
                    writer.Flush();
                    writer.Dispose();
                }
            }
            catch { }
        }
        /// <summary>
        /// Write log from select wordlist  
        /// </summary>
        /// <param name="keyword">string</param>
        /// <param name="Wordlist">string</param>
        /// <param name="index">int</param>
        public static void LogWrite(bool mPredict, string keyword, string Wordlist, int index)
        {
            try
            {
                using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\User\\Log\\" + GetCurUser() + "-" + GetCurDict() + "-" + String.Format("{0:dd_MM_yyyy}", DateTime.Now) + ".txt", FileMode.Append))
                {
                    StreamWriter writer = new StreamWriter(fs, Encoding.Default);
                    if (mPredict)
                    {
                        writer.WriteLine(DateTime.Now.ToLongTimeString() + "|P|" + keyword + "|" + Wordlist + "|" + (index + 1).ToString());
                    }
                    else
                    {
                        writer.WriteLine(DateTime.Now.ToLongTimeString() + "|C|" + keyword + "|" + Wordlist + "|" + (index + 1).ToString());
                    }
                    writer.Flush();
                    writer.Dispose();
                }
            }
            catch { }
        }

        public static Font GetFont()
        {
            return FontName;
        }
        public static void SetFont(Font FontN)
        {
            FontName = FontN;
        }
        public static Color GetFontColor()
        {
            return FontColor;
        }
        public static void SetFontColor(Color FontC)
        {
            FontColor = FontC;
        }
        public static bool getDictUpdate()
        {
            return Convert.ToBoolean(SysConfig["DataBase_update"]);
        }
        public static void setDictUpdate(bool s)
        {
            SysConfig["DataBase_update"] = Convert.ToByte(s);
        }

        public static string getHideFile()
        {
            try
            {
                if (detectOS.detectOS.getOSLegacy() == "XP")
                {
                    return @Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\SetTWPro32.dat";
                }
                else
                {
                    return @Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\SetTWPro32.dat";
                }
            }
            catch
            {
                try
                {
                    return @Environment.CurrentDirectory + "\\SetTWPro32.dat";
                }
                catch
                {
                    return @Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\SetTWPro32.dat";
                }
            }
        }

        public static string getRegFile()
        {
            try
            {
                if (detectOS.detectOS.getOSLegacy() == "XP")
                {
                    return @Environment.CurrentDirectory + "\\RegTWPro32.reg";
                }
                else
                {
                    return @Environment.CurrentDirectory + "\\RegTWPro32.reg";
                }
            }
            catch
            {
                try
                {
                    return @Environment.CurrentDirectory + "\\RegTWPro32.reg";
                }
                catch
                {
                    return @Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\RegTWPro32.reg";
                }
            }
        }
        public static string getSpFile()
        {
            try
            {
                if (detectOS.detectOS.getOSLegacy() == "XP")
                {
                    return @Environment.CurrentDirectory + "\\registerv32.dat";
                }
                else
                {
                    return @Environment.CurrentDirectory + "\\registerv32.dat";
                }
            }
            catch
            {
                try
                {
                    return @Environment.CurrentDirectory + "\\registerv32.dat";
                }
                catch
                {
                    return @Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\registerv32.dat";
                }
            }
        }
    }

     
}

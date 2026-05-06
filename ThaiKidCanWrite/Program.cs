using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using System.Drawing;
using System.Drawing.Text;
using System.Reflection;
using LDWordProcessor.form;
using LDWordProcessor.nectec;
using System.Text.RegularExpressions;
using NLog;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using SoftwareLocker;
using System.IO;
using System.Text;
using EnCryptDecrypt;
using LDWordProcessor.db;
using Newtonsoft.Json.Linq;

#pragma warning disable 0168
#pragma warning disable 0414

namespace LDWordProcessor
{
    static class Program
    {
        //[DllImport("gdi32.dll", EntryPoint = "AddFontResource", SetLastError = true)]
        //public static extern int AddFontResource([In][MarshalAs(UnmanagedType.LPWStr)]string lpFileName);

        private static Logger logger = LogManager.GetCurrentClassLogger();
        public static LDUserBinding AuthUser = null;
        public static SWorkModel workData = null;
        public static JObject SelectPicture = null;
        public static JObject SelectMap = null;
        public static bool isPractice = true;
        public static string Title = null;
        public static string[] Sentence = null;
        public static SAnswer answer =  new SAnswer();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        // config name program
        public static string appname = "KidCanWrite 1.6";
        // config name program
        public static string proid = "9";
        
        public static string host = "http://localhost/ld-write/www/";
        public static string host_api = host + "apis/";

        //--------------file and directory ------------

        private static String driveName = "";
        private static String[] driveNames = new string[10];
        private static int counter = 0;
        private static int Filescounter = 0;
        //---------------------------------------------

        //keep writing program version
        private static string folderName = "C:\\KidCanWrite";
        private static string fileName = "KidCanWrite.txt";
        private static string machinePrgPath = Path.Combine(folderName, fileName);
        // config server register
        public static string server;
        // config trial program
        public static string identifier;
        // config msg
        public static string msg;
        // companyid or userid 
        public static string cid;
        // type license of company
        public static string type_license;
        // key license of scholl
        public static string key_license;
        // key license of scholl
        public static string name_license;
        // key license of scholl
        public static string org_license;

        public static bool is_trial = true;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle("Office 2010 Blue");
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("th-TH");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("th-TH");
            
            string hidefile, regfile, spfile;

            WriteVersionFile();
            GetHost();
            VerifyRequireComponent();

            ShowScreen();

            if (getConfig())
            {
                // set path register & trial
                hidefile = WPControls.getHideFile();
                regfile = WPControls.getRegFile();
                spfile = WPControls.getSpFile();
                // Trial Dialog
                /*if (type_license == "1")
                {
                    int trialDay = 400, trialTime = 400 * 3;
                    // int trialDay, trialTime;
                    // trialDay = dateDiffCal();
                    // Console.WriteLine("trialDay-->"+trialDay);
                    // trialTime = trialDay * 3;
                    byte[] MyOwnKey = { 21, 10, 64, 10, 100, 40, 200, 4, 21, 54, 65, 246, 5, 62, 1, 54, 54, 6, 8, 9, 65, 4, 65, 9 };
                    //  TrialMaker t = new TrialMaker(appname, regfile, hidefile, msg, trialDay, trialTime, identifier, server, cid, spfile, proid);

                    TrialMaker t = new TrialMaker(appname, regfile, hidefile, msg, trialDay, trialTime, identifier, server, cid, spfile, proid, type_license);
                    t.TripleDESKey = MyOwnKey;

                    TrialMaker.RunTypes RT = t.ShowDialog();

                    if (RT != TrialMaker.RunTypes.Expired)
                    {
                        if (RT == TrialMaker.RunTypes.Full)
                            is_trial = false;
                        else
                            is_trial = true;
                        //    Application.Run(new FrmMain(is_trial));
                        ShowScreen();
                    }
                }
                else if (type_license == "2")
                {


                    int trialDay = 400, trialTime = 400 * 3;


                    if (!isTrial()) //is_trial 
                    {
                        is_trial = isTrial();
                        //  Console.WriteLine("key-->");
                        //    System.Windows.Forms.Application.Run(new FrmMain(false));
                        ShowScreen();
                    }
                    else
                    {

                        //---------------serach File-------

                       // searchDrive();
                        // Console.WriteLine("drive-->{0}",driveNames.Count());
                        //for (int i = 0; i < counter; i++)
                        //{

                        //    //  Console.WriteLine("drive-->{0}", driveNames[i]);
                        //    SearchFiles(driveNames[i]);
                        //}

                        // Console.WriteLine("FilesCounter-->{0}",Filescounter);

                        //if (Filescounter > 0)
                        //{

                        //}

                        //else if (Filescounter == 0)
                        //{


                        //}


                        byte[] MyOwnKey = { 21, 10, 64, 10, 100, 40, 200, 4, 21, 54, 65, 246, 5, 62, 1, 54, 54, 6, 8, 9, 65, 4, 65, 9 };
                        TrialMaker t = new TrialMaker(appname, regfile, hidefile, msg, trialDay, trialTime, identifier, server, cid, spfile, proid, type_license);
                        t.TripleDESKey = MyOwnKey;
                        TrialMaker.RunTypes RT = t.ShowDialog();
                        if (RT != TrialMaker.RunTypes.Expired)
                        {
                            if (RT == TrialMaker.RunTypes.Full)
                                is_trial = false;
                            else
                                is_trial = true;
                            //System.Windows.Forms.Application.Run(new FrmMain(is_trial));
                            ShowScreen();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("ไม่สามารถเปิดโปรแกรมได้ เนื่องจากติดปัญหาเรื่องลิขสิทธิ์", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/
            }

        }

        static private bool GetHost()
        {
            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\license\\host", FileMode.Open))
            {
                StreamReader sr = new StreamReader(fs, Encoding.Default);
                string line;

                string[] split;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line == "") continue;
                    host = line;
                    host_api = host + "apis/";
                }
                return true;
            }
        }

        static void ShowScreen()
        {
            LoginForm fLogin = new LoginForm();
            if (fLogin.ShowDialog() == DialogResult.OK)
            {
                ShowMenu();
            }
            else
            {
                Application.Exit();
            }
        }

        static void ShowMenu()
        {
            UserMenuForm usrMenu = new UserMenuForm();
            DialogResult ret = usrMenu.ShowDialog();
            if (ret == DialogResult.OK)
            {
                KCW_FromCreateMindmap frmPreNewDoc = new KCW_FromCreateMindmap();
                DialogResult ret2 = frmPreNewDoc.ShowDialog();
                if (ret2 == DialogResult.Yes)
                {
                    KCW_MainForm main = new KCW_MainForm();
                    Application.Run(main);
                }
                ShowMenu();
            }
            else if (ret == DialogResult.Yes)
            {
                KCW_WorkSend frm = new KCW_WorkSend();
                frm.ShowDialog();
                ShowMenu();
            }
            Program.AuthUser.Logout();
        }
        private static void searchDrive()
        {
            counter = 0;
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                //if ((d.IsReady && d.DriveType == DriveType.Removable) || (d.IsReady && d.DriveType == DriveType.CDRom))
                if (((d.IsReady && d.DriveType == DriveType.Removable) || (d.IsReady && d.DriveType == DriveType.CDRom)) && (d.VolumeLabel.ToString() == "NECTEC LDSW"))
                {
                    // Console.WriteLine("drive->{0}",d.Name);
                    driveNames[counter] = d.Name;
                    counter++;
                }
            }

        }

        public static void SearchFiles(string extDrive)
        {
            Filescounter = 0;
            try
            {
                extDrive += @"NECTEC\serial_Starter\txtStarter\";
                //Console.WriteLine("ext-->{0}", extDrive);

                string[] array1 = Directory.GetFiles(extDrive, "LDSuite_Starter.txt");


                foreach (string name in array1)
                {
                    Console.WriteLine(name);
                    Filescounter = 1;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error--> can not Find");
                Filescounter = 0;
            }
        }

        static private bool isTrial()
        {
            string str = FileReadWrite.ReadFile(WPControls.getSpFile());
            if ("OK" != str)
                return true;
            else
                return false;
        }

        static private bool getConfig()
        {
            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\license\\license", FileMode.Open))
            {
                StreamReader sr = new StreamReader(fs, Encoding.Default);
                string line;

                string[] split;
                 //string a = CryptorEngine.Encrypt("IDENTIFIER|009", true);
                  //Console.WriteLine("line-->", a);

                while ((line = sr.ReadLine()) != null)
                {
                    if (line == "") continue;
                    //Console.WriteLine("line-->", line);
                    split = CryptorEngine.Decrypt(line, true).Split('|');
                    if (split[0] == "SERVER")
                    {
                        server = split[1];
                    }
                    else if (split[0] == "IDENTIFIER")
                    {
                        identifier = split[1];
                    }
                    else if (split[0] == "MSG")
                    {
                        msg = split[1];
                    }
                    else if (split[0] == "COMPANYID")
                    {
                        cid = split[1];
                    }
                    else if (split[0] == "TYPE_LICENSE")
                    {
                        type_license = split[1];
                    }
                    else if (split[0] == "KEY_LICENSE")
                    {
                        key_license = split[1];
                    }
                    else if (split[0] == "NAME_LICENSE")
                    {
                        name_license = split[1];
                    }
                    else if (split[0] == "ORGANIZATION_LICENSE")
                    {
                        org_license = split[1];
                    }
                    else
                    {
                        MessageBox.Show("ไม่สามารถเปิดโปรแกรมได้ เนื่องจากไฟล์ระบบเสียหาย", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                return true;
            }
        }

        static void VerifyRequireComponent()
        {
            try
            {
                VajaTTS tts = new VajaTTS();
                if (!tts.IsVajaVoice())
                {
                    throw new Exception("เครื่องคอมพิวเตอร์นี้ ไม่ได้ทำการติดตั้ง โปรแกรมอ่านออกเสียงภาษาไทย");
                }
                else
                {
                    //Run vaja at the very first time.
                    // byte[] utf8Bytes = Encoding.UTF8.GetBytes("เปิดใช้สิทธิ์ของกระทรวงศึกษาธิการ");
                     //byte[] utf8Bytes = Encoding.UTF8.GetBytes("เปิดใช้สิทธิ์ของกระทรวงศึกษาธิการ สพฐ. รุ่นที่ 2 - 600 สิทธิ - ก.ย. 2557");
                     byte[] utf8Bytes = Encoding.UTF8.GetBytes("เข้าสู่การใช้งาน");

                    //
                    //Converting to Unicode from UTF8 bytes
                    byte[] unicodeBytes = Encoding.Convert(Encoding.UTF8, Encoding.Unicode, utf8Bytes);

                    //Getting string from Unicode bytes
                    // MessageBox.Show(Encoding.Unicode.GetString(unicodeBytes));
                    // reader.Text = "เปิดใช้สิทธิ์ของกระทรวงศึกษาธิการ";
                    tts.Text = Encoding.Unicode.GetString(unicodeBytes);
                    tts.Volume = 100;
                    tts.Play();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,
                    "แจ้งเตือน",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private static void WriteVersionFile()
        {
            if (!Directory.Exists(folderName))
            {
                Directory.CreateDirectory(folderName);
            }

            File.Delete(machinePrgPath); //for clearing contents in file
            using (StreamWriter sw = new StreamWriter(machinePrgPath, true))//create and write the file
            {
                sw.Write(appname);
                sw.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net.NetworkInformation; 

#pragma warning disable 0168
#pragma warning disable 0414

namespace SoftwareLocker
{
    public partial class frmDialog : Form
    {
        private string _Pass;
        private string _Server;
        private string _Identifier;
        private string _IDcompany;
        private string _SpFile;
        private string _Proid;

        private string MacAdrs;
        private string appname = "KidCanWrite 1.5";


        //------------------ new  variable

        private string _type_license;
        private static String Serial = "";
        private static String statusSerial = "";
        private static String schoolName = "";
        private static String organizeName = "";
        private static String driveName = "";
        private bool is_trial = true;

        //--------------file and directory ------------

        //   private static String driveName = "";
        private static String[] driveNames = new string[10];
        private static int counter = 0;
        private static int Filescounter = 0;
        private static string sourceDrive = "";
        //---------------------------------------------

        public frmDialog(string BaseString, string Password, int DaysToEnd, int Runed, string info, string Identifier, string Server, string IDcompany, string SpFile, string Proid, string type_license)
        {
            InitializeComponent();
             
            sebBaseString1.Text = BaseString; 
            _Pass = Password;
            _Server = Server;
            _Identifier = Identifier;
            _IDcompany = IDcompany;
            _SpFile = SpFile;
            _Proid = Proid;

            _type_license = type_license;
             
            lblText.Text = info;
            if (DaysToEnd <= 0 || Runed <= 0)
            { 
                btnTrial.Enabled = false;
            }

             
            if (_type_license == "2")
            {
                //---------------serach File-------
                searchDrive();
            
                for (int i = 0; i < counter; i++)
                {                    
                    SearchFiles(driveNames[i]);
                }                
                btnOK.Enabled = true;             
            }
            sebPassword1.Select();
            
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        private static void searchDrive()
        {
            counter = 0;
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                  if (((d.IsReady && d.DriveType == DriveType.Removable) || (d.IsReady && d.DriveType == DriveType.CDRom)) && (d.VolumeLabel.ToString() == "NECTEC LDSW"))
                {                 
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
                string[] array1 = Directory.GetFiles(extDrive, "ws_Starter.txt");
                foreach (string name in array1)
                {                  
                    sourceDrive = extDrive;
                    Filescounter = 1;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error--> can not Find");
                Filescounter = 0;
            }
        }
         
        public static string getSpFile()
        {
            //    Console.WriteLine("Dir-->{0}",@Environment.CurrentDirectory);
            
            try
            {

                if (detectOS.detectOS.getOSLegacy() == "XP")
                {
                    
                    return @Environment.CurrentDirectory + "\\registerv12-sapi.dat";
                    
                }
                else
                {
                    return @Environment.CurrentDirectory + "\\registerv12-sapi.dat";
                }
            }
            catch
            {
                try
                {
                    return @Environment.CurrentDirectory + "\\registerv12-sapi.dat";
                }
                catch
                {
                    return @Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\registerv12-sapi.dat";
                }
            }
        }
 
        private void btnTrial_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
        }

        public string FetchMacId()
        {
            MacAdrs = "";
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    MacAdrs += nic.GetPhysicalAddress().ToString();
                    break;
                }
            } 
            return MacAdrs;
        }

        private void frmDialog_Load(object sender, EventArgs e)
        {

        }

        private void sebPassword1_Load(object sender, EventArgs e)
        {

        }
    }
}
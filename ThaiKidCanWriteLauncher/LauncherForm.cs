using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

using RestSharp;
using RestSharp.Authenticators;
using System.Management;

using System.Diagnostics;

using Microsoft.Win32;
using System.Globalization;

using System.Text.RegularExpressions;

using System.Net.Http;
using System.Net;

namespace ThaiKidCanWriteLauncher
{
    public partial class LauncherForm : Form
    {
        //https://www.youtube.com/watch?v=fehVTLNQorQ
        //https://stackoverflow.com/questions/126611/can-a-net-windows-application-be-compressed-into-a-single-exe
        //https://stackoverflow.com/questions/21736329/embed-file-in-a-executable

        string UID = "";
        string User_Name = "";
        string User_Email = "";
        string User_PhoneNumber = "";
        string LicenseCode = "";
        string CompanyName = "";
        string TrialDate = "";
        int TrialDayMax = 30;
        string LastLicenseApiMessage = "";

        public const string emailif = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,36})+)$";
       
        public const string phoneif = @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$";

        private static readonly HttpClient client = new HttpClient();

        public static readonly string DefaultTempFilePath = System.IO.Path.GetTempPath();
        public LauncherForm()
        {
            if (System.Diagnostics.Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location)).Count() > 1) System.Diagnostics.Process.GetCurrentProcess().Kill();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            InitializeComponent();
        }

        string ResolveMainProgramPath()
        {
            string[] candidatePaths =
            {
                Path.Combine(Application.StartupPath, "ThaiKidCanWrite.exe"),
                Path.Combine(Application.StartupPath, "ThaiKidCanWrite", "bin", "Debug", "ThaiKidCanWrite.exe"),
                Path.Combine(Application.StartupPath, "ThaiKidCanWrite", "bin", "Release", "ThaiKidCanWrite.exe")
            };

            foreach (string candidatePath in candidatePaths)
            {
                if (File.Exists(candidatePath))
                {
                    return candidatePath;
                }
            }

            return candidatePaths[0];
        }

        bool LaunchMainProgram(string contextTag)
        {
            string targetPath = ResolveMainProgramPath();
            try
            {
                if (!File.Exists(targetPath))
                {
                    WriteLog("LaunchTarget Missing " + contextTag + " => " + targetPath);
                    MessageBox.Show("ไม่พบไฟล์ ThaiKidCanWrite.exe\n" + targetPath, "ไม่พบไฟล์โปรแกรมหลัก", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                Process.Start(new ProcessStartInfo
                {
                    FileName = targetPath,
                    WorkingDirectory = Path.GetDirectoryName(targetPath)
                });
                WriteLog("LaunchTarget OK " + contextTag + " => " + targetPath);
                return true;
            }
            catch (Exception ex)
            {
                WriteLog("LaunchTarget Exception " + contextTag + " => " + ex.ToString());
                MessageBox.Show("เปิดโปรแกรมหลักไม่สำเร็จ\n" + ex.Message, "ไม่สามารถเปิดโปรแกรมหลัก", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        string NormalizeLicenseKey(string keyNum)
        {
            if (string.IsNullOrWhiteSpace(keyNum))
            {
                return string.Empty;
            }

            return Regex.Replace(keyNum.ToUpperInvariant(), "[^A-Z0-9]", "");
        }

        string GetLicenseApiMessage(IRestResponse response)
        {
            if (response == null || string.IsNullOrWhiteSpace(response.Content))
            {
                return string.Empty;
            }

            Match match = Regex.Match(response.Content, "\"msg\"\\s*:\\s*\"([^\"]+)\"", RegexOptions.IgnoreCase);
            if (match.Success)
            {
                return match.Groups[1].Value.Trim().ToUpperInvariant();
            }

            return response.Content.Trim().ToUpperInvariant();
        }

        string BuildLicenseFailureMessage(string fallbackMessage)
        {
            if (string.IsNullOrWhiteSpace(LastLicenseApiMessage))
            {
                return fallbackMessage;
            }

            return fallbackMessage + "\nServer response: " + LastLicenseApiMessage;
        }
        int CheckLicenseTKCWAavailable(String keyNum, String uid)
        {
            try
            {
                LastLicenseApiMessage = string.Empty;
                string normalizedKey = NormalizeLicenseKey(keyNum);
                var client = new RestClient("https://ld-api.uat.rtt.in.th");
                // client.Authenticator = new HttpBasicAuthenticator(username, password);
                var request = new RestRequest("/api/license/validate-product?prgVersion=4");
                request.AddParameter("keyNum", normalizedKey);
                request.AddParameter("uid", uid);
                //request.AddHeader("header", "value");
                //request.AddFile("file", path);
                var response = client.Post(request);
                if (response == null || response.StatusCode == 0 || response.ResponseStatus != ResponseStatus.Completed)
                {
                    WriteLog("ValidateLicense NetworkFail => status=" + (response == null ? "null" : response.StatusCode.ToString()) + ", respStatus=" + (response == null ? "null" : response.ResponseStatus.ToString()) + ", err=" + (response == null ? "null" : response.ErrorMessage));
                    return 3;
                }
                string apiMessage = GetLicenseApiMessage(response);
                LastLicenseApiMessage = apiMessage;
                WriteLog("ValidateLicense => key=" + normalizedKey + ", uid=" + uid + ", status=" + response.StatusCode.ToString() + ", raw=" + response.Content);

                if (apiMessage == "OK")
                {
                    return 1;
                }
                if (apiMessage == "CHANGE_SERIAL")
                {
                    return 4;
                }
                else return 2;
                //WriteLog(response2.Content);
            }
            catch (Exception ex)
            {
                WriteLog("ValidateLicense Exception => " + ex.ToString());
                return 3;
            }
            return 3;
        }

        int CheckLicenseTKCWInstall(String keyNum, String uid, String fullname, String organizationName, String email, String phoneNo)
        {
            /*
             *
                2. After Install software
                https://tsa.aaa.in.th/api/license-install-success?license=mylicense
                // If update license status success return status 200 and json data:
                {
                  status: true,
                  message: 'The License is install successfully.'
                }
                // If update license status fail return status 401 and json data:
                {
                  status: false,
                  message: 'The License is not available to install.'
                }
             
            string ServiceUrl = "https://node.powermonitor.site";
            string CheckLicense = "/api/license-install-success?license=" + keyNum + "&owner=" + organizationName;

            // https://restsharp.dev/getting-started/getting-started.html
            // https://csharp.hotexamples.com/examples/RestSharp/RestClient/Post/php-restclient-post-method-examples.html

            try
            {

                string ServiceUploadAPI = (ServiceUrl + CheckLicense);


                var client = new RestClient(ServiceUrl);
                var Uploadrequest = new RestRequest(ServiceUploadAPI);

                IRestResponse response2 = client.Execute(Uploadrequest);

                if (response2.Content.Contains("true"))
                {
                    return 1;
                }
                else return 2;
                //WriteLog(response2.Content);

            }
            catch (Exception ex)
            {
                return 3;
            }
            return 3;*/
            try
            {
                LastLicenseApiMessage = string.Empty;
                string normalizedKey = NormalizeLicenseKey(keyNum);
                var client = new RestClient("https://ld-api.uat.rtt.in.th");
                // client.Authenticator = new HttpBasicAuthenticator(username, password);
                var request = new RestRequest("/api/license/activate-product?prgVersion=4");
                request.AddParameter("keyNum", normalizedKey);
                request.AddParameter("uid", uid);
                request.AddParameter("fullname", fullname);
                request.AddParameter("organizationName", organizationName);
                request.AddParameter("email", email);
                request.AddParameter("phoneNo", phoneNo);
                //request.AddHeader("header", "value");
                //request.AddFile("file", path);
                var response = client.Post(request);
                if (response == null || response.StatusCode == 0 || response.ResponseStatus != ResponseStatus.Completed)
                {
                    WriteLog("ActivateLicense NetworkFail => status=" + (response == null ? "null" : response.StatusCode.ToString()) + ", respStatus=" + (response == null ? "null" : response.ResponseStatus.ToString()) + ", err=" + (response == null ? "null" : response.ErrorMessage));
                    return 3;
                }
                string apiMessage = GetLicenseApiMessage(response);
                LastLicenseApiMessage = apiMessage;
                WriteLog("ActivateLicense => key=" + normalizedKey + ", uid=" + uid + ", fullname=" + fullname + ", org=" + organizationName + ", email=" + email + ", phone=" + phoneNo + ", status=" + response.StatusCode.ToString() + ", raw=" + response.Content);
                
                if (apiMessage == "OK")
                {
                    return 1;
                }
                if (apiMessage == "CHANGE_SERIAL")
                {
                    return 4;
                }
                else return 2;
                //WriteLog(response2.Content);
            }
            catch (Exception ex)
            {
                WriteLog("ActivateLicense Exception => " + ex.ToString());
                return 3;
            }
            return 3;
        }

        void ShowPanelLogin(int dayremind)
        {
            panelLogin.Enabled = true;
            panelLogin.Visible = true;

            panelConfirmLicense.Enabled = false;
            panelConfirmLicense.Visible = false;

            panelConfirmTrial.Enabled = false;
            panelConfirmTrial.Visible = false;

            trName.Text = "";
            trEmail.Text = "";
            trTelNo.Text = "";
            trOrg.Text = "";
            trLC.Text = "";
            if (dayremind > 0)
            {
                b2Trial.Enabled = true;
                b2Trial.Text = "ทดลองใช้ " + dayremind.ToString() + " วัน";
            }
            else
            {
                b2Trial.Enabled = false;
                b2Trial.Text = "หมดเวลาทดลองใช้";
                b2Trial.BackColor = Color.Red;
            }

            panelLogin.Update();
        }
        void ShowPanelConfirmLicense()
        {
            panelConfirmLicense.Location = panelLogin.Location;

            panelLogin.Enabled = false;
            panelLogin.Visible = false;

            panelConfirmLicense.Enabled = true;
            panelConfirmLicense.Visible = true;

            panelConfirmTrial.Enabled = false;
            panelConfirmTrial.Visible = false;

            labelChkLc.Text = "กำลังตรวจสอบ License code กรุณารอสักครู่ ...";

            panelConfirmLicense.Update();

        }
        void ShowPanelConfirmTrial(int dayremind)
        {
            panelConfirmTrial.Location = panelLogin.Location;

            panelLogin.Enabled = false;
            panelLogin.Visible = false;

            panelConfirmLicense.Enabled = false;
            panelConfirmLicense.Visible = false;

            panelConfirmTrial.Enabled = true;
            panelConfirmTrial.Visible = true;


            if (dayremind > 0)
            {
                labelTrial.Text = "เหลือเวลาทดลองใช้ " + dayremind.ToString() + " วัน";
                b4OK.Enabled = true;
                b4Cancle.Enabled = true;
                b4Lc.Enabled = true;
            }
            else
            {
                labelTrial.Text = "หมดเวลาทดลองใช้ โปรดใส่ License Code";
                b4OK.Enabled = false;
                b4OK.BackColor = Color.Red;
                b4Cancle.Enabled = true;
                b4Lc.Enabled = true;
            }

            panelConfirmTrial.Update();
        }
        private void LauncherForm_Shown(object sender, EventArgs e)
        {
            //this.Height = 250;

            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\NECTEC", true);

            if (rk == null)
            {
                Registry.CurrentUser.CreateSubKey("SOFTWARE\\NECTEC");
                rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\NECTEC", true);
                rk.SetValue("KCWLICENSE", "");
                rk.SetValue("KCWTRIAL", "");
            }

            try
            {
                LicenseCode = rk.GetValue("KCWLICENSE").ToString();
            }
            catch { rk.SetValue("KCWLICENSE", ""); }
            try
            {
                    TrialDate = rk.GetValue("KCWTRIAL").ToString();
            }
            catch { rk.SetValue("KCWTRIAL", ""); }

            rk.SetValue("KCWLOCATION", Application.StartupPath);

            if ((LicenseCode == string.Empty) && (TrialDate == string.Empty))
            {
                int dayleft = TrialDayMax;
                if (TrialDate == string.Empty) dayleft = TrialDayMax;
                else
                {
                    DateTime result = DateTime.ParseExact(TrialDate, "yyyy-MM-dd", CultureInfo.GetCultureInfo("en-GB"));
                    dayleft = TrialDayMax - (int)(DateTime.Now - result).TotalDays;
                }
                ShowPanelLogin(dayleft);
            }
            else if (LicenseCode != string.Empty)
            {
                ShowPanelConfirmLicense();
                UID = CalculateUID();
                try
                {
                    int retnum = CheckLicenseTKCWAavailable(LicenseCode, UID);
                    if (retnum == 1)
                    {
                        labelChkLc.Text = "ตรวจสอบ License code เรียบร้อย";
                        b3Cancle.Text = "ตกลง";
                    }
                    else if (retnum == 2)
                    {
                        MessageBox.Show(BuildLicenseFailureMessage("License code ไม่ถูกต้อง กรุณาลองใหม่"), "License code ไม่ถูกต้อง", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        int dayleft = TrialDayMax;
                        if (TrialDate == string.Empty) dayleft = TrialDayMax;
                        else
                        {
                            DateTime result = DateTime.ParseExact(TrialDate, "yyyy-MM-dd", CultureInfo.GetCultureInfo("en-GB"));
                            dayleft = TrialDayMax - (int)(DateTime.Now - result).TotalDays;
                        }
                        ShowPanelLogin(dayleft);
                    }
                    else if (retnum == 3)
                    {
                        MessageBox.Show("ไม่สามารถเชื่อมต่ออินเตอร์เน็ตได้ กรุณาลองใหม่", "ไม่สามารถเชื่อมต่ออินเตอร์เน็ตได้", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        int dayleft = TrialDayMax;
                        if (TrialDate == string.Empty) dayleft = TrialDayMax;
                        else
                        {
                            DateTime result = DateTime.ParseExact(TrialDate, "yyyy-MM-dd", CultureInfo.GetCultureInfo("en-GB"));
                            dayleft = TrialDayMax - (int)(DateTime.Now - result).TotalDays;
                        }
                        ShowPanelLogin(dayleft);
                    }
                    else if (retnum == 4)
                    {
                        MessageBox.Show("License นี้ถูกผูกกับเครื่องอื่นอยู่ กรุณาตรวจสอบกับผู้ดูแลระบบ", "License ถูกใช้งานกับเครื่องอื่น", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        int dayleft = TrialDayMax;
                        if (TrialDate == string.Empty) dayleft = TrialDayMax;
                        else
                        {
                            DateTime result = DateTime.ParseExact(TrialDate, "yyyy-MM-dd", CultureInfo.GetCultureInfo("en-GB"));
                            dayleft = TrialDayMax - (int)(DateTime.Now - result).TotalDays;
                        }
                        ShowPanelLogin(dayleft);
                    }
                }
                catch (Exception ex)
                {
                    WriteLog("An error occurred while querying for WMI data: " + ex.ToString());
                }
            }
            else if ((TrialDate != string.Empty))
            {
                DateTime result = DateTime.ParseExact(TrialDate, "yyyy-MM-dd", CultureInfo.GetCultureInfo("en-GB"));
                int dayleft = TrialDayMax - (int)(DateTime.Now - result).TotalDays;
                ShowPanelConfirmTrial(dayleft);
            }
            else
            {
                MessageBox.Show("Launcher มีปัญหา กรุณาลองเปิดใหม่", "Launcher มีปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
        private void b2Cancle_Click(object sender, EventArgs e)
        {
            Close();
        }
        private string CalculateUID()
        {
            string UID = "";
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM win32_processor");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    UID += queryObj["ProcessorId"].ToString();
                }

                searcher = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    UID += queryObj["SerialNumber"].ToString();
                }
            }
            catch (Exception ex)
            {
                WriteLog("An error occurred while querying for WMI data: " + ex.ToString());
            }
            return UID;
        }

        private void SaveFileStream(String path, Stream stream)
        {
            var fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
            stream.CopyTo(fileStream);
            fileStream.Dispose();
        }
        private void WriteLog(string value)
        {

            System.Globalization.CultureInfo oldCI = System.Threading.Thread.CurrentThread.CurrentCulture;
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");

            string strLogPart = "";
            string strLogfile = "";
            string strDate = "";
            strDate = DateTime.Now.ToString("logs_TSA_install_yyyy-MM-dd");
            strLogPart = Application.StartupPath;
            strLogfile = Application.StartupPath + @"\" + strDate + ".txt";
            try
            {
                if (!Directory.Exists(strLogPart))
                {
                    Directory.CreateDirectory(strLogPart);
                }

                System.IO.StreamWriter sw = new StreamWriter(strLogfile, true);
                sw.WriteLine(DateTime.Now.ToString("HH:mm:ss") + ":" + value);
                sw.Flush();
                sw.Dispose();

                sw.Close();
            }
            catch// (Exception ex)
            {
                //MessageBox.Show("Error:" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string[] files = Directory.GetFiles(strLogPart);
            try
            {
                foreach (string file in files)
                {
                    FileInfo fi = new FileInfo(file);
                    if (fi.LastAccessTime < DateTime.Now.AddMonths(-1))
                        fi.Delete();
                }
            }
            catch// (Exception ex)
            {
                //MessageBox.Show("Error:" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            System.Threading.Thread.CurrentThread.CurrentCulture = oldCI;
        }
        private void b2OK_Click(object sender, EventArgs e)
        {
            String ErrorStr = String.Empty;

            if (trLC.Text == String.Empty)
            {
                ErrorStr = "กรุณาใส่ License Code";
            }
            if (trName.Text == String.Empty)
            {
                if (ErrorStr != String.Empty) ErrorStr += " และ\n";
                ErrorStr += "กรุณาใส่ ชื่อ - นามสกุล";
            }
            if (trEmail.Text == String.Empty)
            {
                if (ErrorStr != String.Empty) ErrorStr += " และ\n";
                ErrorStr += "กรุณาใส่ E-Mail";
            }
            else if (!Regex.IsMatch(trEmail.Text, emailif))
            {
                if (ErrorStr != String.Empty) ErrorStr += " และ\n";
                ErrorStr += "E-Mail ไม่ถูกต้อง";
            }
            if (trTelNo.Text == String.Empty)
            {
                if (ErrorStr != String.Empty) ErrorStr += " และ\n";
                ErrorStr += "กรุณาใส่ เบอร์โทรติดต่อ";
            }
            else if (!Regex.IsMatch(trTelNo.Text, phoneif))
            {
                if (ErrorStr != String.Empty) ErrorStr += " และ\n";
                ErrorStr += "เบอร์โทรติดต่อ ไม่ถูกต้อง (ใส่ได้เฉพาะตัวเลขและ \"-\" เท่านั้น)";
            }
            if (trOrg.Text == String.Empty)
            {
                if (ErrorStr != String.Empty) ErrorStr += " และ\n";
                ErrorStr += "กรุณาใส่ หน่วยงาน";
            }


            if (ErrorStr != String.Empty)
            {
                MessageBox.Show(ErrorStr, "กรอกข้อมูลไม่ครบถ้วน", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                User_Name = trName.Text;
                User_Email = trEmail.Text;
                User_PhoneNumber = trTelNo.Text;
                LicenseCode = trLC.Text;
                LicenseCode = NormalizeLicenseKey(LicenseCode);
                CompanyName = trOrg.Text;

                ShowPanelConfirmLicense();
                try
                {
                    UID = CalculateUID();
                    int retnum = CheckLicenseTKCWInstall(LicenseCode, UID, User_Name, CompanyName, User_Email, User_PhoneNumber);
                    if (retnum == 1)
                    {
                        RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\NECTEC", true);

                        if (rk != null)
                        {
                            rk.SetValue("KCWLICENSE", LicenseCode);
                            rk.SetValue("KCWTRIAL", "");
                        }

                        labelChkLc.Text = "ตรวจสอบ License code เรียบร้อย";
                        b3Cancle.Text = "ตกลง";
                    }
                    else if (retnum == 2)
                    {
                        MessageBox.Show(BuildLicenseFailureMessage("License code ไม่ถูกต้อง กรุณาลองใหม่"), "License code ไม่ถูกต้อง", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        int dayleft = TrialDayMax;
                        if (TrialDate == string.Empty) dayleft = TrialDayMax;
                        else
                        {
                            DateTime result = DateTime.ParseExact(TrialDate, "yyyy-MM-dd", CultureInfo.GetCultureInfo("en-GB"));
                            //Check day remine
                            dayleft = TrialDayMax - (int)(DateTime.Now - result).TotalDays;
                        }
                        ShowPanelLogin(dayleft);
                    }
                    else if (retnum == 3)
                    {
                        MessageBox.Show("ไม่สามารถเชื่อมต่ออินเตอร์เน็ตได้ กรุณาลองใหม่", "ไม่สามารถเชื่อมต่ออินเตอร์เน็ตได้", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        int dayleft = TrialDayMax;
                        if (TrialDate == string.Empty) dayleft = TrialDayMax;
                        else
                        {
                            DateTime result = DateTime.ParseExact(TrialDate, "yyyy-MM-dd", CultureInfo.GetCultureInfo("en-GB"));
                            //Check day remine
                            dayleft = TrialDayMax - (int)(DateTime.Now - result).TotalDays;
                        }
                        ShowPanelLogin(dayleft);
                    }
                    else if (retnum == 4)
                    {
                        MessageBox.Show("License นี้ถูกผูกกับเครื่องอื่นอยู่ กรุณาตรวจสอบกับผู้ดูแลระบบ", "License ถูกใช้งานกับเครื่องอื่น", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        int dayleft = TrialDayMax;
                        if (TrialDate == string.Empty) dayleft = TrialDayMax;
                        else
                        {
                            DateTime result = DateTime.ParseExact(TrialDate, "yyyy-MM-dd", CultureInfo.GetCultureInfo("en-GB"));
                            dayleft = TrialDayMax - (int)(DateTime.Now - result).TotalDays;
                        }
                        ShowPanelLogin(dayleft);
                    }
                    else if (retnum == 4)
                    {
                        MessageBox.Show("License นี้ถูกผูกกับเครื่องอื่นอยู่ กรุณาตรวจสอบกับผู้ดูแลระบบ", "License ถูกใช้งานกับเครื่องอื่น", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        int dayleft = TrialDayMax;
                        if (TrialDate == string.Empty) dayleft = TrialDayMax;
                        else
                        {
                            DateTime result = DateTime.ParseExact(TrialDate, "yyyy-MM-dd", CultureInfo.GetCultureInfo("en-GB"));
                            dayleft = TrialDayMax - (int)(DateTime.Now - result).TotalDays;
                        }
                        ShowPanelLogin(dayleft);
                    }
                }
                catch (Exception ex)
                {
                    WriteLog("An error occurred while querying for WMI data: " + ex.ToString());
                }
            }
        }
      
        private void b3Cancle_Click(object sender, EventArgs e)
        {
            if (b3Cancle.Text == "ตกลง")
            {
                LaunchMainProgram("(ConfirmButton)");
            }
            
            Close();
        }

        private void b4Cancle_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void b4OK_Click(object sender, EventArgs e)
        {
            if (TrialDate == string.Empty)
            {
                RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\NECTEC", true);

                if (rk != null)
                {
                    string text = DateTime.Now.ToString("yyyy-MM-dd", CultureInfo.GetCultureInfo("en-GB"));
                    rk.SetValue("KCWTRIAL", DateTime.Now.ToString("yyyy-MM-dd", CultureInfo.GetCultureInfo("en-GB")));
                }
            }
            if (!LaunchMainProgram("(Trial)"))
            {
                return;
            }
            Close();
        }

        private void b2Trial_Click(object sender, EventArgs e)
        {
            int dayleft = TrialDayMax;
            if (TrialDate == string.Empty) dayleft = TrialDayMax;
            else
            {
                DateTime result = DateTime.ParseExact(TrialDate, "yyyy-MM-dd", CultureInfo.GetCultureInfo("en-GB"));
                //Check day remine
                dayleft = TrialDayMax - (int)(DateTime.Now - result).TotalDays;
            }
            ShowPanelConfirmTrial(dayleft);
        }

        private void b4Lc_Click(object sender, EventArgs e)
        {
            int dayleft = TrialDayMax;
            if (TrialDate == string.Empty) dayleft = TrialDayMax;
            else
            {
                DateTime result = DateTime.ParseExact(TrialDate, "yyyy-MM-dd", CultureInfo.GetCultureInfo("en-GB"));
                //Check day remine
                dayleft = TrialDayMax - (int)(DateTime.Now - result).TotalDays;
            }
            ShowPanelLogin(dayleft);
        }

        private void bround1_Click(object sender, EventArgs e)
        {
            DialogResult Cancleresult = MessageBox.Show("ยกเลิก License Code สำหรับเครื่องนี้.", "ยกเลิก License Code !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Cancleresult == DialogResult.Yes)
            {
                try
                {
                    RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\NECTEC", true);

                    Registry.CurrentUser.CreateSubKey("SOFTWARE\\NECTEC");
                    rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\NECTEC", true);
                    rk.SetValue("KCWLICENSE", "");
                    rk.SetValue("KCWTRIAL", "");
                }
                catch
                {

                }

                Close();
            }
        }

    }
}

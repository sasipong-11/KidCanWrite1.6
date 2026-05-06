using sun.net.www.http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace LDWordProcessor
{
    class HttpsService
    {
        
        System.Net.WebClient Client = new System.Net.WebClient();

        BasicReq.BReq http = new BasicReq.BReq();
        public string HttpGet(string path)
        {
            string result = http.HttpGet(Program.host_api + path);
            return result;
        }
        public string HttpPost()
        {
            return "";
        }
        public string UpLoadFile(string fileNamePath, string uriString)
        { 
            string s ="";
            try
            {
                Client.Headers.Clear();
                Client.Headers.Add("Content-Type", "binary/octet-stream");
                byte[] result = Client.UploadFile(uriString, "POST", fileNamePath);//fileNamePath คือ D://ชื่อไฟล์.dox

                s = System.Text.Encoding.UTF8.GetString(result, 0, result.Length);
            }
            catch (Exception e)
            { 
                s =  "{'status':'error', 'message':'file upload is null'}";
            }
            return s;
        }
    }
}

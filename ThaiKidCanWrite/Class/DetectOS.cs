using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace  detectOS
{
    public class detectOS
    {
        /// <summary>
        /// Gets Operating System Name using .Net's Environment class.
        /// </summary>
        /// <returns>String containing the name of the operating system followed by its service pack (if any)</returns>
        public static string getOSLegacy()
        {
            //Get Operating system information.
            OperatingSystem os = Environment.OSVersion;
            //Get version information about the os.
            Version vs = os.Version;

            //Variable to hold our return value
            string operatingSystem = "";

            if (os.Platform == PlatformID.Win32Windows)
            {
                //This is a pre-NT version of Windows
                switch (vs.Minor)
                {
                    case 0:
                        operatingSystem = "95";
                        break;
                    case 10:
                        if (vs.Revision.ToString() == "2222A")
                            operatingSystem = "98SE";
                        else
                            operatingSystem = "98";
                        break;
                    case 90:
                        operatingSystem = "Me";
                        break;
                    default:
                        break;
                }
            }
            else if (os.Platform == PlatformID.Win32NT)
            {
                switch (vs.Major)
                {
                    case 3:
                        operatingSystem = "NT 3.51";
                        break;
                    case 4:
                        operatingSystem = "NT 4.0";
                        break;
                    case 5:
                        if (vs.Minor == 0)
                        {
                            operatingSystem = "2000";
                        }
                        else
                        {
                            operatingSystem = "XP";
                        }
                        break;
                    case 6:
                        if (vs.Minor == 0)
                        {
                            operatingSystem = "Vista";
                        }
                        else
                        {
                            operatingSystem = "7";
                        }
                        break;
                    default:
                        break;
                }
            }
            //Make sure we actually got something in our OS check
            //We don't want to just return " Service Pack 2"
            //That information is useless without the OS version.
            //if (operatingSystem != "")
            //{
            //    //Got something.  Let's see if there's a service pack installed.
            //    operatingSystem += getOSServicePackLegacy();
            //}
            //Return the information we've gathered.
            return operatingSystem;
        }
        /// <summary>
        /// Gets the installed Operating System Service Pack using .Net's Environment class.
        /// </summary>
        /// <returns>String containing the operating system's installed service pack (if any)</returns>
        public static string getOSServicePackLegacy()
        {
            // Get service pack from Environment Class
            string sp = Environment.OSVersion.ServicePack;
            if (sp != null && sp.ToString() != "" && sp.ToString() != " ")
            {
                // If there's a service pack, return it with a space in front (for formatting)
                return " " + sp.ToString();
            }
            // No service pack.  Return an empty string
            return "";
        }
        /// <summary>
        /// Gets Operating System Architecture.  This does not tell you if the program in running in
        /// 32- or 64-bit mode or if the CPU is 64-bit capable.  It tells you whether the actual Operating
        /// System is 32- or 64-bit.
        /// </summary>
        /// <returns>Int containing 32 or 64 representing the number of bits in the OS Architecture</returns>
        public static int getOSArchitectureLegacy()
        {
            string pa = Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE");
            return ((String.IsNullOrEmpty(pa) || String.Compare(pa, 0, "x86", 0, 3, true) == 0) ? 32 : 64);
        }
    }
}

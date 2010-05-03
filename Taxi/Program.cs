using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using _UseFull;
namespace Taxi
{
    static class Program
    {
        public static string hardSignature()
        {
            string res = "";
            HardDrive hd = new HardDrive();
            HardDriveInfo hdi = (HardDriveInfo)hd.GetHardDriveInfo()[0];
            res = ((hdi.Signature.Length > 0) && (hdi.Signature != null) ? hdi.Signature : "123654879");
            return res;
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
           long h;
            h=Int64.Parse(hardSignature());
            h=(h*2)/3;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (File.Exists(Application.StartupPath + "\\content.dll"))
            {
                Form_activation active = new Form_activation();
                if (File.ReadAllText(Application.StartupPath + "\\content.dll") == h.ToString())
                {
                    Application.Run(new frm_login());
                    
                }
                else
                {
                    Application.Run(new Form_activation());
                }
            }
       
            
        }
    }
}
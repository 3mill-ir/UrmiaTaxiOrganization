using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using _UseFull;
using System.IO;

namespace Taxi
{
    public partial class Form_activation : Form
    {
        public Form_activation()
        {
            InitializeComponent();
        }

        private void Form_activation_Load(object sender, EventArgs e)
        {
            textBox1.Text = hardSignature();

        }
        public static string GetActivationCode(string st)
        {
            UTF8Encoding ue = new UTF8Encoding();
            byte[] stBytes = ue.GetBytes(st);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] hashBytes = md5.ComputeHash(stBytes);
            return Regex.Replace(BitConverter.ToString(hashBytes), "-", "").ToLower().Substring(0, 20);
        }


        public static string hardSignature()
        {
            string res = "";
            HardDrive hd = new HardDrive();
            HardDriveInfo hdi = (HardDriveInfo)hd.GetHardDriveInfo()[0];
            res = ((hdi.Signature.Length > 0) && (hdi.Signature != null) ? hdi.Signature : "7211560");
            return res;
        }

        private void Form_activation_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {long h=Int64.Parse( hardSignature());
        h=(h*2)/3;
        if (h.ToString ()== textBox2.Text)
        {
            File.WriteAllText(Application.StartupPath + "\\content.dll", h.ToString());
            frm_login login = new frm_login();
            login.Show();
            this.Hide();
        }
        }

        private void Form_activation_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    
    }
}

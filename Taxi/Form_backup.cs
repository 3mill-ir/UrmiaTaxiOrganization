using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FarsiMessageBox;
using System.IO;

namespace Taxi
{
    public partial class Form_backup : Form
    {
        //**************************************************
        string filePath = Application.StartupPath + @"\taxi.accdb";
        string destFilePath = "";
        FileStream fsSource;
        FileStream fsDest;
        BinaryReader br;
        BinaryWriter bw;
        string bcpFilePath = "";
        //**************************************************
        public Form_backup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = folderBrowserDialog1.ShowDialog();
                if (res == DialogResult.OK)
                {
                    destFilePath = folderBrowserDialog1.SelectedPath;
                    textBox1.Text = destFilePath;
                    btnBackup.Enabled = true;
                }
                else
                {
                    destFilePath = "";
                    btnBackup.Enabled = false;
                    textBox1.Text = destFilePath;
                }
            }
            catch (Exception ex)
            {
                FMessageBox.Show(ex.Message, "خطا", FMessageBoxButtons.OK, FMessageBoxIcons.Error);
            }
        }
        private string FileNameCreate(string destFolder)
        {
            string fileName = "";
            string defFileName = "taxi.mdbbcp";
            string newFileName = defFileName;
            bool okey = false;
            int i = 2;
            while (okey == false)
            {
                if (!File.Exists(destFolder + @"\" + newFileName))
                {
                    fileName = newFileName;
                    okey = true;
                }
                else
                {
                    newFileName = IncreaseFileName(defFileName.Remove(defFileName.IndexOf('.')), i);
                    i++;
                }
            }
            return fileName;
        }

        private string IncreaseFileName(string currentName, int i)
        {
            string newName = "";
            newName = currentName + i.ToString() + @".mdbbcp";
            return newName;
        }
        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    if (destFilePath.Length > 0)
                    {
                        //File.Copy(filePath, destFilePath + @"\db_mobileShop.mdbbcp");
                        fsSource = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                        fsDest = new FileStream(destFilePath + @"\" + FileNameCreate(destFilePath), FileMode.Create, FileAccess.Write);
                        br = new BinaryReader(fsSource);
                        bw = new BinaryWriter(fsDest);
                        ///////////////////////// read and write :
                        progressBar1.Value = 0;
                        progressBar1.Maximum = (int)fsSource.Length;
                        progressBar1.Visible = true;
                        while (br.BaseStream.Position < br.BaseStream.Length)
                        {
                            bw.Write(br.ReadBytes(200));
                            if ((progressBar1.Value + 200) < progressBar1.Maximum)
                                progressBar1.Value += 200;
                            else
                                progressBar1.Value = progressBar1.Maximum;
                        }
                        /////////////////////////
                        br.Close();
                        bw.Close();
                        fsSource.Close();
                        fsDest.Close();
                        FMessageBox.Show("عملیات با موفقیت انجام شد", "پیام", FMessageBoxButtons.OK, FMessageBoxIcons.Information);
                        progressBar1.Value = 0;
                    }
                    else
                    {
                        FMessageBox.Show("لطفاً مکان فایل بکاپ را مشخص کنید", "پیام", FMessageBoxButtons.OK, FMessageBoxIcons.Warning);
                    }
                }
                else
                {
                    FMessageBox.Show("متأسفانه فایل پایگاه داده یافت نشد", "پیام", FMessageBoxButtons.OK, FMessageBoxIcons.Warning);
                }
            }
            catch (Exception ex)
            {
                FMessageBox.Show(ex.Message, "خطا", FMessageBoxButtons.OK, FMessageBoxIcons.Error);
            }
        }
    }
}

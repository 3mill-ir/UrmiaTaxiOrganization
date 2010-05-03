using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using FarsiMessageBox;

namespace Taxi
{
    public partial class Form_recovery : Form
    {
        //*****************************************
        string filePath = Application.StartupPath + @"\taxi.accdb";
        string destFilePath = "";
        FileStream fsSource;
        FileStream fsDest;
        BinaryReader br;
        BinaryWriter bw;
        string bcpFilePath = "";
        //**************************
        public Form_recovery()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = openFileDialog1.ShowDialog();
                if (res == DialogResult.OK)
                {
                    bcpFilePath = openFileDialog1.FileName;
                    tbBackupFileName.Text = bcpFilePath;
                    tbBaziaft.Enabled = true;
                }
                else
                {
                    bcpFilePath = "";
                    tbBackupFileName.Text = bcpFilePath;
                    tbBaziaft.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                FMessageBox.Show(ex.Message, "خطا", FMessageBoxButtons.OK, FMessageBoxIcons.Error);
            }
        }

        private void tbBaziaft_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = FMessageBox.Show("این فایل بکاپ جایگزین پایگاه داده کنونی خواهد شد" + "\n\n" + "آیا اطمینان دارید؟", "جایگزین شود؟", FMessageBoxButtons.YesNo, FMessageBoxIcons.Question);
                if (res == DialogResult.Yes)
                {
                    fsSource = new FileStream(bcpFilePath, FileMode.Open, FileAccess.Read);
                    fsDest = new FileStream(filePath, FileMode.Create, FileAccess.Write);
                    br = new BinaryReader(fsSource);
                    bw = new BinaryWriter(fsDest);
                    //////////////////////////////
                    prgBackup.Visible = true;
                    prgBackup.Value = 0;
                    prgBackup.Maximum = (int)fsSource.Length;
                    while (br.BaseStream.Position < br.BaseStream.Length)
                    {
                        bw.Write(br.ReadBytes(200));
                        if (prgBackup.Value + 200 <= prgBackup.Maximum)
                            prgBackup.Value += 200;
                        else
                            prgBackup.Value = prgBackup.Maximum;
                    }
                    //////////////////////////////
                    fsDest.Close();
                    fsSource.Close();
                    br.Close();
                    bw.Close();
                    FMessageBox.Show("عملیات بازیافت با موفقیت انجام شد", "پیام", FMessageBoxButtons.OK, FMessageBoxIcons.Information);
                    prgBackup.Value = 0;
                }
            }
            catch (Exception ex)
            {
                FMessageBox.Show(ex.Message, "خطا", FMessageBoxButtons.OK, FMessageBoxIcons.Error);
            }
        }
    }
}

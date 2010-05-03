using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Taxi
{
    public partial class F_Main : Form
    {
        //***************************************
        frm_login frm = new frm_login();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader rdr;
        static  string taxi_name;
        //***************************************
        public string tname
        {
            get
            {
                return taxi_name;

        }
            set
            {
                taxi_name = value;
            }
        }
        public F_Main()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void bexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F_Main_Load(object sender, EventArgs e)
        {
            try
            {
                panel2.Location = new System.Drawing.Point(this.Size.Width / 2 - panel2.Size.Width / 2, this.Size.Height / 2 - panel2.Size.Height / 2);
                cmd.Connection = frm.oledbcon1;
                frm.oledbcon1.Open();
                cmd.CommandText = "select taxiname from taxi_info ";
                rdr = cmd.ExecuteReader();
                rdr.Read();
                if (rdr.HasRows)
                {
                   textBox1.Text = " تاكسي تلفني " + rdr.GetString(0);
                   taxi_name = textBox1.Text;
                }


            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);

            }
            finally
            {
                frm.oledbcon1.Close();
            }
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void F_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

      

       

        private void اشتراكجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_new_customer newcustomerfrm = new Form_new_customer();
            newcustomerfrm.ShowDialog();
        }

        private void رانندهجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_sabteservice sabteservicefrm = new frm_sabteservice();
            sabteservicefrm.ShowDialog();
        }

        private void ثبتToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xxx_Click(object sender, EventArgs e)
        {
            Form_newdriver newdriverfrm = new Form_newdriver();
            newdriverfrm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_new_customer newcustomerfrm = new Form_new_customer();
            newcustomerfrm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form_newdriver newdriverfrm = new Form_newdriver();
            newdriverfrm.ShowDialog();
        }

        private void رانندهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_driveredit drivereditfrm = new Form_driveredit();
            drivereditfrm.ShowDialog();
        }

        private void اشتراكToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_customeredit customeredit = new Form_customeredit();
            customeredit.ShowDialog();
        }

        private void تغييرتصويرژسزToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void بكاپگيريToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_backup backupfrm = new Form_backup();
            backupfrm.ShowDialog();
        }

        private void بازيافتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_recovery recoveryfrm = new Form_recovery();
            recoveryfrm.ShowDialog();
        }

        private void كاربرجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_changepass changepassfrm = new Form_changepass();
            changepassfrm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_servicesreport servicesreportfrm = new Form_servicesreport();
            servicesreportfrm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm_sabteservice sabteservicefrm = new frm_sabteservice();
            sabteservicefrm.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form_changepass changepassfrm = new Form_changepass();
            changepassfrm.ShowDialog();
        }

        private void سرويسهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_servicesreport servicesreportfrm = new Form_servicesreport();
            servicesreportfrm.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form_backup backupfrm = new Form_backup();
            backupfrm.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void مشخصاتآژانسToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_taxi taxifrm = new Form_taxi();
            taxifrm.ShowDialog();
        }

        private void راهنماToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_help helpfrm = new Form_help();
            helpfrm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

     

   

       
      

       
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using farhaniPersianDate;
using FarsiMessageBox;
using System.Data.OleDb;
using System.IO;

namespace Taxi
{
    public partial class frm_login : Form
    {
        cDate date = new cDate();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader rdr;
        public OleDbConnection oledbcon1 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\taxi.accdb");
        public frm_login()
        {
            InitializeComponent();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

            
            comboBox1.SelectedIndex = 0;
            textBox1.Text = date.Year + "/" + date.Month + "/" + date.Day;
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            cmd.Connection = oledbcon1;
            try
            {
               
               oledbcon1.Open();
               cmd.CommandText = "select * from managers where username='"+comboBox1.SelectedItem.ToString()+"'";
               rdr = cmd.ExecuteReader();
               rdr.Read();
               if (rdr.HasRows)
               {
                  
                   if (( rdr.GetString(4)) == (textBox2.Text))
                   {
                       rdr.Close();
                       F_Main mainfrm = new F_Main();
                       mainfrm.Show();
                       this.Hide();
                   }
                   else
                   {
                       FMessageBox.Show("کلمه عبور را اشتباه وارد کرده اید ", "اخطار", FMessageBoxButtons.OK, FMessageBoxIcons.Error);
                   }

               }
             

            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);

            }
            finally
            {
                oledbcon1.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

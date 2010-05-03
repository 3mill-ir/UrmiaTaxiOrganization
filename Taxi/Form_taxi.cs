using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using FarsiMessageBox;

namespace Taxi
{
    public partial class Form_taxi : Form
    {
        //***************************************
        frm_login frm = new frm_login();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader rdr;
        //***************************************
        public Form_taxi()
        {
            InitializeComponent();
        }

        private void Form_taxi_Load(object sender, EventArgs e)
        {
            try
            {
                cmd.Connection = frm.oledbcon1;
                frm.oledbcon1.Open();
                cmd.CommandText = "select * from taxi_info ";
                rdr = cmd.ExecuteReader();
                if ( rdr.Read())
                {
                    textBox1.Text = rdr.GetValue(0).ToString();
                    textBox2.Text = rdr.GetValue(1).ToString();
                    textBox3.Text = rdr.GetValue(2).ToString();
                    textBox4.Text = rdr.GetValue(3).ToString();

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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Connection = frm.oledbcon1;
                frm.oledbcon1.Open();
          
                    cmd.CommandText = "insert into taxi_info values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
                    cmd.ExecuteNonQuery();
                    FMessageBox.Show("اطلاعات ذخيره شد.", "پيغام1", FMessageBoxButtons.OK, FMessageBoxIcons.Information);
               

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

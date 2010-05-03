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
    public partial class Form_newdriver : Form
    {
        frm_login frm = new frm_login();
        OleDbCommand cmd = new OleDbCommand();

        public Form_newdriver()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void b4_Click(object sender, EventArgs e)
        {
            try
            {
                frm.oledbcon1.Open();
                cmd.Connection = frm.oledbcon1;
                cmd.CommandText = "insert into Drivers values('" + tb1.Text + "','" + tb6.Text + "','" + tb7.Text + "','" + tb4.Text + "','" + tb2.Text + "','" + tb3.Text + "','" + tb5.Text + "','" + tb8.Text + "')";
                MessageBox.Show(cmd.CommandText);
                cmd.ExecuteNonQuery();
                FMessageBox.Show("اطلاعات ذخيره شد.", "پيغام", FMessageBoxButtons.OK, FMessageBoxIcons.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                frm.oledbcon1.Close();
            }
        }

        private void tb3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

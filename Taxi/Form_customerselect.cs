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
    public partial class Form_customerselect : Form
    {
        //*****************************************
        frm_login frm = new frm_login();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader rdr;
        frm_sabteservice customereditfrm = new frm_sabteservice();
        //*******************************************
        public Form_customerselect()
        {
            InitializeComponent();
        }

        private void Form_customerselect_Load(object sender, EventArgs e)
        {
            try
            {
                ds.Clear();
                adp.SelectCommand.Connection = frm.oledbcon1;
                adp.SelectCommand.CommandText = "select (custumerid) as كداشتراك,(custumerName) as [نام مشترك] ,(address) as آدرس ,(tel) as تلفن from Costumers ";
                adp.Fill(ds, "Costumers");
                dataGrid1.SetDataBinding(ds, "Costumers");

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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                customereditfrm.tb1.Text = ds.Tables["Costumers"].Rows[dataGrid1.CurrentRowIndex][0].ToString();
                customereditfrm.tb2.Text = ds.Tables["Costumers"].Rows[dataGrid1.CurrentRowIndex][1].ToString();
                customereditfrm.tb3.Text = ds.Tables["Costumers"].Rows[dataGrid1.CurrentRowIndex][3].ToString();
                customereditfrm.tb4.Text = ds.Tables["Costumers"].Rows[dataGrid1.CurrentRowIndex][2].ToString();

                this.Hide();
                customereditfrm.ShowDialog();
            }
            catch(Exception)
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

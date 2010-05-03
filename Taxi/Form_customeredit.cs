using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using farhaniPersianDate;
using FarsiMessageBox;

namespace Taxi
{
    public partial class Form_customeredit : Form
    {
        //*********************************************
        frm_login frm = new frm_login();
        OleDbCommand cmd = new OleDbCommand();
        OleDbCommand cmd1 = new OleDbCommand();
        OleDbDataReader rdr;     
        string str = "";
        DataSet1 ds1;
        Form_print rp = new Form_print();
        F_Main mainfrm = new F_Main();
        //**********************************************
        public Form_customeredit()
        {
            InitializeComponent();
        }

        private void dataGrid1_Navigate(object sender, NavigateEventArgs ne)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ds.Tables["Costumers"].Rows.Count != 0)
                {
                    button2.Enabled = true;
                    button1.Enabled = false;
                    tb1.Text = ds.Tables["Costumers"].Rows[dataGrid1.CurrentRowIndex][0].ToString();
                    tb2.Text = ds.Tables["Costumers"].Rows[dataGrid1.CurrentRowIndex][1].ToString();
                    tb3.Text = ds.Tables["Costumers"].Rows[dataGrid1.CurrentRowIndex][3].ToString();
                    tb4.Text = ds.Tables["Costumers"].Rows[dataGrid1.CurrentRowIndex][2].ToString();
                    str = tb1.Text;
                }
            }
            catch(Exception)
            {
            }
        }

        private void Form_customeredit_Load(object sender, EventArgs e)
        {
            try
            {
                ds.Clear();
                adp.SelectCommand.Connection = frm.oledbcon1;
                adp.SelectCommand.CommandText = "select (custumerid) as كداشتراك,(custumerName) as مشترك ,(address) as آدرس ,(tel) as تلفن from Costumers ";
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Connection = frm.oledbcon1;
                frm.oledbcon1.Open();
                cmd.CommandText = "UPDATE costumers SET  custumername ='" + tb2.Text + "', custumerid='"+tb1.Text+"', address='" + tb4.Text
                    + "' ,tel='" + tb3.Text  + "' where custumerid='" + str+"'" ;
                cmd.ExecuteNonQuery();
                button2.Enabled = false;
                button1.Enabled = true;
                FMessageBox.Show(" اطلاعات ذخیره شد", "پیغام", FMessageBoxButtons.OK, FMessageBoxIcons.Information);
                try
                {
                    ds.Clear();
                    adp.SelectCommand.Connection = frm.oledbcon1;
                    adp.SelectCommand.CommandText = "select (custumerid) as كداشتراك,(custumerName) as مشترك ,(address) as آدرس ,(tel) as تلفن from Costumers ";
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
                    button2.Enabled = false;
                }
                tb1.Text = "";
                tb2.Text = "";
                tb3.Text = "";
                tb4.Text = "";
             
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                frm.oledbcon1.Open();
                cmd1.Connection = frm.oledbcon1;
                ds1 = new DataSet1();
                ds1.Costumers.Clear();

                //           MessageBox.Show(mainfrm.taxi_name);
                adp.SelectCommand.CommandText = "select * from Costumers";
                adp.Fill(ds1.Costumers);
                crystalReport31.SetDataSource(ds1);
                crystalReport31.SetParameterValue("name", mainfrm.tname);
                rp.crystalReportViewer1.ReportSource = crystalReport31;
                rp.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error2", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                frm.oledbcon1.Close();
            }
        }
    }
}

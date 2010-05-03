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
    public partial class Form_driveredit : Form
    {
        //********************************************
        frm_login frm = new frm_login();
        string str = "";
        OleDbCommand cmd = new OleDbCommand();
        OleDbCommand cmd1 = new OleDbCommand();
        Form_print rp = new Form_print();
        F_Main mainfrm = new F_Main();
        DataSet1 ds1;
        //***********************************************

        public Form_driveredit()
        {
            InitializeComponent();
        }

        private void Form_driveredit_Load(object sender, EventArgs e)
        {
            try
            {
                ds.Clear();
                adp.SelectCommand.Connection = frm.oledbcon1;
                adp.SelectCommand.CommandText = "select (driverName) as [نام راننده],(tel) as تلفن,(address) as آدرس ,(carMark) as پلاك,(mellicode) as كدملي , (dateborn) as تولد , (cartype) as خودرو , (color) as [رنگ خودرو] from Drivers ";
                adp.Fill(ds, "Drivers");
                dataGrid1.SetDataBinding(ds, "Drivers");

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
                button2.Enabled = true;
                button1.Enabled = false;
                tb1.Text = ds.Tables["Drivers"].Rows[dataGrid1.CurrentRowIndex][0].ToString();
                tb6.Text = ds.Tables["Drivers"].Rows[dataGrid1.CurrentRowIndex][1].ToString();
                tb7.Text = ds.Tables["Drivers"].Rows[dataGrid1.CurrentRowIndex][2].ToString();
                tb4.Text = ds.Tables["Drivers"].Rows[dataGrid1.CurrentRowIndex][3].ToString();
                tb2.Text = ds.Tables["Drivers"].Rows[dataGrid1.CurrentRowIndex][4].ToString();
                tb3.Text = ds.Tables["Drivers"].Rows[dataGrid1.CurrentRowIndex][5].ToString();
                tb5.Text = ds.Tables["Drivers"].Rows[dataGrid1.CurrentRowIndex][6].ToString();
                textBox1.Text = ds.Tables["Drivers"].Rows[dataGrid1.CurrentRowIndex][7].ToString();
                str = tb6.Text;
            }
            catch(Exception)
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Connection = frm.oledbcon1;
                frm.oledbcon1.Open();
                cmd.CommandText = "UPDATE Drivers SET  Drivername ='" + tb1.Text + "', tel='" + tb6.Text
                    + "' ,address='" + tb7.Text + "', carMark='" + tb4.Text + "' ,mellicode='" + tb2.Text + "', dateborn='" + tb3.Text +
                     "' ,cartype='" + tb5.Text + "', color='" + textBox1.Text + "' where tel='" + str + "'";
                cmd.ExecuteNonQuery();
                button1.Enabled = true;
                button2.Enabled = false;
                FMessageBox.Show(" اطلاعات ذخیره شد", "پیغام", FMessageBoxButtons.OK, FMessageBoxIcons.Information);
                try
                {
                    ds.Clear();
                    adp.SelectCommand.Connection = frm.oledbcon1;
                    adp.SelectCommand.CommandText = "select (driverName) as [نام راننده],(tel) as تلفن,(address) as آدرس ,(carMark) as پلاك,(mellicode) as كدملي , (dateborn) as تولد , (cartype) as خودرو from Drivers ";
                    adp.Fill(ds, "Drivers");
                    dataGrid1.SetDataBinding(ds, "Drivers");

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
                tb5.Text = "";
                tb6.Text = "";
                tb7.Text = "";
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                frm.oledbcon1.Open();
                cmd1.Connection = frm.oledbcon1;
                ds1 = new DataSet1();
                ds1.Drivers.Clear();

                //           MessageBox.Show(mainfrm.taxi_name);
                adp.SelectCommand.CommandText = "select * from drivers";
                adp.Fill(ds1.Drivers);
                crystalReport41.SetDataSource(ds1);
                crystalReport41.SetParameterValue("name", mainfrm.tname);
                rp.crystalReportViewer1.ReportSource = crystalReport41;
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

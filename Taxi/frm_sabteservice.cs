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
namespace Taxi
{
    public partial class frm_sabteservice : Form
    {
        //*****************************************
        cDate date = new cDate();
        frm_login frm = new frm_login();
        OleDbCommand cmd = new OleDbCommand();
        OleDbCommand cmd1 = new OleDbCommand();
        OleDbDataReader rdr;
        Boolean b = false;
        int x;
        F_Main mainfrm = new F_Main();
        DataSet1 ds1;
        Form_print rp = new Form_print();
        //***************************************
        public frm_sabteservice()
        {
            InitializeComponent();
        }

        private void frm_sabteservice_Load(object sender, EventArgs e)
        {
            
            try
            {
                tb6.SelectedIndex = 0;
                ds.Clear();
                tb7.Text = date.Year + "/";
                if (date.Month < 10)
                {
                    tb7.Text += "0" + date.Month + "/";
                }
                else
                {
                    tb7.Text += date.Month + "/";
                }
                if (date.Day < 10)
                {
                    tb7.Text += "0" + date.Day;
                }
                else
                {
                    tb7.Text += date.Day;
                }


                tb8.Text = DateTime.Now.Hour + ":" + DateTime.Now.Minute; 
                frm.oledbcon1.Open();
                adp.SelectCommand.Connection = frm.oledbcon1;
                adp.SelectCommand.CommandText = "SELECT     serviceID AS [شماره سرويس], costumerName AS [نام مشتري], costumerID AS [كد اشتراك], tel AS تلفن, customeraddress AS آدرس, destination AS مقصد," +
                     " moveTime AS ساعت, moveDate AS تاريخ, drivername AS [نام راننده], servicePrice AS مبلغ from Services where moveDate='" + tb7.Text+"'";
                adp.Fill(ds, "services");
                //     where moveDate='" + date.Year + "/" + date.Month + "/" + date.Day + "'";         
                dataGrid1.SetDataBinding(ds, "services");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                frm.oledbcon1.Close();
            }
            try
            {
                frm.oledbcon1.Open();
                cmd.Connection = frm.oledbcon1;
                cmd.CommandText = "select driverName from Drivers";
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    rdr.Read();
                    tb6.Items.Add(rdr.GetString(0));
                    while (rdr.Read())
                    {
                        tb6.Items.Add(rdr.GetString(0));
                    }
                }
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (b == false)
            {
                try
                {
                    frm.oledbcon1.Open();
                    cmd.Connection = frm.oledbcon1;
                    cmd.CommandText = "insert into Services       (driverName, costumerID, costumerName, destination, moveTime, moveDate, servicePrice, customeraddress, tel) values('" + tb6.SelectedItem.ToString() + "'," + tb1.Text + ",'" +
                        tb2.Text + "','" + tb5.Text + "','" + tb8.Text + "','" + tb7.Text + "','" + tb9.Text + "','" + tb4.Text + "','" + tb3.Text + "')";
                    cmd.ExecuteNonQuery();
                    FMessageBox.Show("سرويس به ثبت رسيد", "پيغام", FMessageBoxButtons.OK, FMessageBoxIcons.Information);
                    Form_print rp = new Form_print();
                    rp.crystalReportViewer1.ReportSource = crystalReport11;

                    MessageBox.Show(mainfrm.tname);
                    //*******************************************************
                    crystalReport11.SetParameterValue("taxi", mainfrm.tname);
                        crystalReport11.SetParameterValue("date", tb7.Text);
                        crystalReport11.SetParameterValue("code", tb1.Text);
                        crystalReport11.SetParameterValue("customer", tb2.Text);
                        crystalReport11.SetParameterValue("tel", tb3.Text);
                        crystalReport11.SetParameterValue("address", tb4.Text);
                        crystalReport11.SetParameterValue("distination", tb5.Text);
                        crystalReport11.SetParameterValue("driver", tb6.Text);
                        crystalReport11.SetParameterValue("time", tb8.Text);
                        crystalReport11.SetParameterValue("cost", tb9.Text);
                        rp.ShowDialog();
                    //*********************************************************
                    
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
            else
            {
                try
                {
                    frm.oledbcon1.Open();
                    cmd.Connection = frm.oledbcon1;
                    cmd.CommandText = "update  Services  set costumername='"+tb2.Text + "',customeraddress='" + tb4.Text + "',tel='" + tb3.Text + "',destination='" + tb5.Text + "',drivername='" + tb6.SelectedItem.ToString() + "',movedate='" + tb7.Text + "',movetime='" + tb8.Text + "',serviceprice='" + tb9.Text+  "' where serviceID="+x;
                    cmd.ExecuteNonQuery();
                    FMessageBox.Show("سرويس به ثبت رسيد", "پيغام", FMessageBoxButtons.OK, FMessageBoxIcons.Information);
                    Form_print rp = new Form_print();
                    rp.crystalReportViewer1.ReportSource = crystalReport11;
                    //*******************************************************
                    crystalReport11.SetParameterValue("taxi", mainfrm.tname);

                    crystalReport11.SetParameterValue("date", tb7.Text);

                    crystalReport11.SetParameterValue("code", tb1.Text);
            
                    crystalReport11.SetParameterValue("customer", tb2.Text);
               
                    crystalReport11.SetParameterValue("tel", tb3.Text);
               
                    crystalReport11.SetParameterValue("address", tb4.Text);
                 
                    crystalReport11.SetParameterValue("distination", tb5.Text);
               
                    crystalReport11.SetParameterValue("driver", tb6.Text);
                   
                    crystalReport11.SetParameterValue("time", tb8.Text);

                    crystalReport11.SetParameterValue("cost", tb9.Text);
                    rp.ShowDialog();
                    //*********************************************************
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
          
            try
            {
                ds.Clear();
                tb7.Text = date.Year + "/";
                if (date.Month < 10)
                {
                    tb7.Text += "0" + date.Month + "/";
                }
                else
                {
                    tb7.Text += date.Month + "/";
                }
                if (date.Day < 10)
                {
                    tb7.Text += "0" + date.Day;
                }
                else
                {
                    tb7.Text += date.Day;
                }
                tb8.Text = DateTime.Now.Hour + ":" + DateTime.Now.Minute; 
                frm.oledbcon1.Open();
                adp.SelectCommand.Connection = frm.oledbcon1;
                adp.SelectCommand.CommandText = "SELECT     serviceID AS [شماره سرويس], costumerName AS [نام مشتري], costumerID AS [كد اشتراك], tel AS تلفن, customeraddress AS آدرس, destination AS مقصد," +
                    " moveTime AS ساعت, moveDate AS تاريخ, driverName AS [نام راننده], servicePrice AS مبلغ from Services where moveDate='"+tb7.Text + "'";
                adp.Fill(ds, "services");
                //     where moveDate='" + date.Year + "/" + date.Month + "/" + date.Day + "'";         
                dataGrid1.SetDataBinding(ds, "services");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                frm.oledbcon1.Close();
            }
            tb1.Text = "";
            tb2.Text = "";
            tb3.Text = "";
            tb4.Text = "";
            tb5.Text = "";
            tb6.Text = "";
            tb9.Text = "";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                tb1.Text = ds.Tables["services"].Rows[dataGrid1.CurrentRowIndex][2].ToString();
                tb2.Text = ds.Tables["services"].Rows[dataGrid1.CurrentRowIndex][1].ToString();
                tb3.Text = ds.Tables["services"].Rows[dataGrid1.CurrentRowIndex][3].ToString();
                tb4.Text = ds.Tables["services"].Rows[dataGrid1.CurrentRowIndex][4].ToString();
                tb5.Text = ds.Tables["services"].Rows[dataGrid1.CurrentRowIndex][5].ToString();
                for (int i = 0; i < tb6.Items.Count; i++)
                {
                    if (tb6.Items[i].ToString() == ds.Tables["services"].Rows[dataGrid1.CurrentRowIndex][8].ToString())
                    {
                        tb6.SelectedIndex = i;
                    }
                }

                tb7.Text = ds.Tables["services"].Rows[dataGrid1.CurrentRowIndex][7].ToString();
                tb8.Text = ds.Tables["services"].Rows[dataGrid1.CurrentRowIndex][6].ToString();
                tb9.Text = ds.Tables["services"].Rows[dataGrid1.CurrentRowIndex][9].ToString();
                b = true;
                x = Int32.Parse(ds.Tables["services"].Rows[dataGrid1.CurrentRowIndex][0].ToString());
            }
            catch (Exception)
            {
            }
        }


        private void b3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb8_TextChanged(object sender, EventArgs e)
        {

        }

        private void b4_Click(object sender, EventArgs e)
        {
            Form_customerselect customerselectfrm = new Form_customerselect();
           
           this.Hide();
           customerselectfrm.ShowDialog();
          
            
        }

        private void b5_Click(object sender, EventArgs e)
        {
            try
            {
                frm.oledbcon1.Open();
                cmd1.Connection = frm.oledbcon1;
                ds1 = new DataSet1();
                ds1.Services.Clear();
                adp.SelectCommand.CommandText = "select * from services where movedate='"+tb7.Text+"'";
                adp.Fill(ds1.Services);
                crystalReport21.SetDataSource(ds1);
                crystalReport21.SetParameterValue("name", mainfrm.tname);
                rp.crystalReportViewer1.ReportSource = crystalReport21;
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

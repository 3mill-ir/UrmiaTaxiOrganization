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
    public partial class Form_servicesreport : Form
    {
        //*********************************************
        OleDbCommand cmd = new OleDbCommand();
        OleDbCommand cmd1 = new OleDbCommand();
        OleDbDataAdapter adp;
        DataSet ds;
        DataSet1 ds1;
        frm_login frm = new frm_login();
        OleDbDataReader rdr;
        Form_print rp = new Form_print();
        F_Main mainfrm = new F_Main();
        //**************************************************
        public Form_servicesreport()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ds.Clear();
                if (checkBox3.Checked == true)
                {
                    if (maskedTextBox1.Text != "    /  /  ")
                    {
                        adp.SelectCommand.CommandText = "SELECT     serviceID AS [شماره سرويس], costumerName AS [نام مشتري], costumerID AS [كد اشتراك], tel AS تلفن, customeraddress AS آدرس, destination AS مقصد," +
                            " moveTime AS ساعت, moveDate AS تاريخ, driverName AS [نام راننده], servicePrice AS مبلغ from Services  where movedate='" + maskedTextBox3.Text + "' and driverName='" + comboBox1.SelectedItem.ToString() + "'";
                        cmd1.CommandText = adp.SelectCommand.CommandText;
                    }
                }
                else
                {
                    adp.SelectCommand.CommandText = "SELECT     serviceID AS [شماره سرويس], costumerName AS [نام مشتري], costumerID AS [كد اشتراك], tel AS تلفن, customeraddress AS آدرس, destination AS مقصد," +
                                                " moveTime AS ساعت, moveDate AS تاريخ, driverName AS [نام راننده], servicePrice AS مبلغ from Services  where  driverName='" + comboBox1.SelectedItem.ToString() + "'";
                    cmd1.CommandText = adp.SelectCommand.CommandText;
                }


                adp.Fill(ds, "tbl");
                dataGridView1.DataSource = ds.Tables["tbl"];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                panel1.Enabled = true;
            }
            if (checkBox1.Checked == false)
            {
                panel1.Enabled = false;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;

            try
            {
               
                if (checkBox1.Checked == true)
                {
                    if (maskedTextBox1.Text != "    /  /  ")
                    {
                        adp.SelectCommand.CommandText = "SELECT     serviceID AS [شماره سرويس], costumerName AS [نام مشتري], costumerID AS [كد اشتراك], tel AS تلفن, customeraddress AS آدرس, destination AS مقصد," +
                            " moveTime AS ساعت, moveDate AS تاريخ, driverName AS [نام راننده], servicePrice AS مبلغ from Services  where movedate='" + maskedTextBox1.Text+"'";
                        cmd1.CommandText = adp.SelectCommand.CommandText;
                    }
                }



                adp.Fill(ds, "tbl");
                dataGridView1.DataSource = ds.Tables["tbl"];
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                ds.Clear();
                if (checkBox4.Checked == true)
                {
                    if (maskedTextBox1.Text != "    /  /  ")
                    {
                        adp.SelectCommand.CommandText = "SELECT     serviceID AS [شماره سرويس], costumerName AS [نام مشتري], costumerID AS [كد اشتراك], tel AS تلفن, customeraddress AS آدرس, destination AS مقصد," +
                            " moveTime AS ساعت, moveDate AS تاريخ, driverName AS [نام راننده], servicePrice AS مبلغ from Services  where movedate='" + maskedTextBox2.Text + "' and (costumerID=" + textBox1.Text + ")";
                        cmd1.CommandText = adp.SelectCommand.CommandText; 
                    }
                }
                else
                {
                    adp.SelectCommand.CommandText = "SELECT     serviceID AS [شماره سرويس], costumerName AS [نام مشتري], costumerID AS [كد اشتراك], tel AS تلفن, customeraddress AS آدرس, destination AS مقصد," +
                                                " moveTime AS ساعت, moveDate AS تاريخ, driverName AS [نام راننده], servicePrice AS مبلغ from Services  where ( costumerID=" + textBox1.Text + ")";
                    cmd1.CommandText = adp.SelectCommand.CommandText;
                }
               
                adp.Fill(ds, "tbl");
                dataGridView1.DataSource = ds.Tables["tbl"];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_servicesreport_Load(object sender, EventArgs e)
        {
            try
            {
                comboBox1.SelectedIndex = 0;
                frm.oledbcon1.Open();
                cmd.Connection = frm.oledbcon1;
                cmd.CommandText = "select driverName from Drivers";
                rdr = cmd.ExecuteReader();
                adp = new OleDbDataAdapter(cmd);
                ds = new DataSet();
                if (rdr.HasRows)
                {
                    rdr.Read();
                    comboBox1.Items.Add(rdr.GetString(0));
                    while (rdr.Read())
                    {
                        comboBox1.Items.Add(rdr.GetString(0));
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

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                panel3.Enabled = true;
            }
            if (checkBox3.Checked == false)
            {
                panel3.Enabled = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                panel4.Enabled = true;
            }
            if (checkBox4.Checked == false)
            {
                panel4.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                frm.oledbcon1.Open();
                cmd1.Connection = frm.oledbcon1;
                ds1 = new DataSet1();
                ds1.Services.Clear();
               
     //           MessageBox.Show(mainfrm.taxi_name);
                adp.SelectCommand.CommandText = cmd1.CommandText;
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

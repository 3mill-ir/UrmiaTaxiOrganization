using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using farhaniPersianDate;
using System.Collections;
using FarsiMessageBox;

namespace Taxi
{
    public partial class Form_changepass : Form
    {
        frm_login frm = new frm_login();
        OleDbCommand cmd = new OleDbCommand();
        OleDbCommand cmd2 = new OleDbCommand();
        OleDbDataReader rdr;
        //OleDbDataReader rdr1;
        string pass = "";
        ArrayList arr = new ArrayList();

        private OleDbConnection oledbcon2 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\taxi.accdb");
        public Form_changepass()
        {
            InitializeComponent();
        }

        private void Form_changepass_Load(object sender, EventArgs e)
        {
            frm.oledbcon1.Open();
            try
            {
               
                cmd.Connection = frm.oledbcon1;
                cmd.CommandText = "select username from Managers";
             
                rdr = cmd.ExecuteReader();
                
                if (rdr.HasRows)
                {
                   
                    while (rdr.Read())
                    {

                        arr.Add(rdr.GetString(0).ToString());
                        
                    }
                   
                }
                rdr.Close();
               for(int i=0;i<arr.Count;i++)
               {
                   dgv.Rows.Add(arr[i]);
               }
               try
               {
                   frm.oledbcon1.Open();

                   if ((dgv.Rows.Count > 0) && (dgv.CurrentRow.Index >= 0))
                   {

                       string userName = dgv.CurrentRow.Cells[0].Value.ToString();
                       cmd.CommandText = "select * from Managers Where userName = '" + userName + "'";
                       rdr = cmd.ExecuteReader();
                       if (rdr.HasRows)
                       {
                           while (rdr.Read())
                           {

                               tb1.Text = rdr.GetString(0);
                               tb2.Text = rdr.GetString(1);
                               tb3.Text = rdr.GetString(2);
                               pass = rdr.GetString(4);
                           }
                       }
                   }
               }
               catch (Exception ex)
               {
                   FMessageBox.Show(ex.Message, "خطا", FMessageBoxButtons.OK, FMessageBoxIcons.Error);


               }
               finally
               {
                   frm.oledbcon1.Close();
               }
           
            }
            catch(Exception ex)
            {
                FMessageBox.Show(ex.Message, "خطا", FMessageBoxButtons.OK, FMessageBoxIcons.Error);
            }
            finally
            {
                frm.oledbcon1.Close();
            }

        }
       
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {

            try
            {
                frm.oledbcon1.Open();
             
                if ((dgv.Rows.Count > 0) && (dgv.CurrentRow.Index >= 0))
                {
                    
                    string userName = dgv.CurrentRow.Cells[0].Value.ToString();
                    cmd.CommandText = "select * from Managers Where userName = '" + userName + "'";
                    rdr = cmd.ExecuteReader();
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {

                            tb1.Text = rdr.GetString(0);
                            tb2.Text = rdr.GetString(1);
                            tb3.Text = rdr.GetString(2);
                            pass = rdr.GetString(4);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //FMessageBox.Show(ex.Message, "خطا", FMessageBoxButtons.OK, FMessageBoxIcons.Error);


            }
            finally
            {
                frm.oledbcon1.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Connection = frm.oledbcon1;
                frm.oledbcon1.Open();
                cmd.CommandText = "UPDATE managers SET  managername ='" + tb1.Text + "', address='" + tb2.Text
                    + "' ,tel='" + tb3.Text + "' where username='" + dgv.CurrentRow.Cells[0].Value.ToString()+"'";
                cmd.ExecuteNonQuery();
                FMessageBox.Show(" اطلاعات ذخیره شد", "پیغام", FMessageBoxButtons.OK, FMessageBoxIcons.Information);
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
                if (tb4.Text == pass)
                {
                    cmd.CommandText = "UPDATE managers SET    [password] ='" + tb5.Text + "' where username='" + dgv.CurrentRow.Cells[0].Value.ToString() + "'";
                  
                    cmd.ExecuteNonQuery();
                    FMessageBox.Show(" اطلاعات ذخیره شد", "پیغام", FMessageBoxButtons.OK, FMessageBoxIcons.Information);

                }
                else
                    FMessageBox.Show(" كلمه عبور قبلي را نادرست وارد كرده ايد!", "پیغام", FMessageBoxButtons.OK, FMessageBoxIcons.Warning);
                    
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

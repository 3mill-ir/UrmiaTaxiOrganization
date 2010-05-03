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
    public partial class Form_new_customer : Form
    {
        OleDbCommand cmd = new OleDbCommand();
        frm_login frm = new frm_login();
        OleDbDataReader rdr;

        public Form_new_customer()
        {
            InitializeComponent();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            try
            {
                frm.oledbcon1.Open();
                cmd.Connection = frm.oledbcon1;
                cmd.CommandText = "select custumerID from Costumers where custumerID='"+tb1.Text+"'";
                rdr = cmd.ExecuteReader();
                
                if (rdr.HasRows)
                {
                    FMessageBox.Show(" اين شماره اشتراك قبلا رزرو شده است لطفا شماره ديگري را بكار ببريد!", "پيغام", FMessageBoxButtons.OK, FMessageBoxIcons.Information);

                }
                   
                else
                {

                    rdr.Close();
                       
                        cmd.Connection = frm.oledbcon1;
                        cmd.CommandText = "insert into costumers (custumerName,address,tel,custumerID)values('" + tb2.Text + "','" + tb4.Text + "','" + tb3.Text+"','"+tb1.Text + "')";
                        cmd.ExecuteNonQuery();
                        FMessageBox.Show("اطلاعات ذخيره شد.", "پيغام", FMessageBoxButtons.OK, FMessageBoxIcons.Information);
                        this.Close();
                
                }
               
           

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

        private void Form_new_customer_Load(object sender, EventArgs e)
        {
       

        }
    }
}

namespace Taxi
{
    partial class frm_sabteservice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.b4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb6 = new System.Windows.Forms.ComboBox();
            this.tb8 = new System.Windows.Forms.TextBox();
            this.tb7 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb9 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.adp = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.ds = new System.Data.DataSet();
            this.label11 = new System.Windows.Forms.Label();
            this.crystalReport11 = new Taxi.CrystalReport1();
            this.crystalReport21 = new Taxi.CrystalReport2();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(138, 92);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(119, 22);
            this.tb3.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "شماره تلفن:";
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(138, 27);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(119, 22);
            this.tb1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "كد  اشتراك:";
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(138, 58);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(119, 22);
            this.tb2.TabIndex = 3;
            this.tb2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "نام مشتري:";
            // 
            // dataGrid1
            // 
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(25, 230);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(686, 300);
            this.dataGrid1.TabIndex = 1;
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(435, 182);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(121, 30);
            this.b1.TabIndex = 2;
            this.b1.Text = "ثبت";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.button1_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(295, 182);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(121, 30);
            this.b2.TabIndex = 3;
            this.b2.Text = "ويرايش";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.button2_Click);
            // 
            // b3
            // 
            this.b3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.b3.Location = new System.Drawing.Point(159, 182);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(121, 30);
            this.b3.TabIndex = 4;
            this.b3.Text = "انصراف";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(250, 531);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(207, 32);
            this.b5.TabIndex = 5;
            this.b5.Text = "چاپ ليست";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // tb4
            // 
            this.tb4.Location = new System.Drawing.Point(23, 123);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(234, 22);
            this.tb4.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(267, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 14);
            this.label9.TabIndex = 18;
            this.label9.Text = "آدرس :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.b4);
            this.groupBox1.Controls.Add(this.tb2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(336, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 161);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "انتخاب مشترك:";
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(23, 27);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(98, 23);
            this.b4.TabIndex = 7;
            this.b4.Text = "انتخاب";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb6);
            this.groupBox2.Controls.Add(this.tb8);
            this.groupBox2.Controls.Add(this.tb7);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tb9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tb5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(61, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 161);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ساير مشخصات";
            // 
            // tb6
            // 
            this.tb6.FormattingEnabled = true;
            this.tb6.Location = new System.Drawing.Point(19, 55);
            this.tb6.Name = "tb6";
            this.tb6.Size = new System.Drawing.Size(122, 22);
            this.tb6.TabIndex = 26;
            // 
            // tb8
            // 
            this.tb8.Location = new System.Drawing.Point(93, 109);
            this.tb8.Name = "tb8";
            this.tb8.Size = new System.Drawing.Size(49, 22);
            this.tb8.TabIndex = 25;
            this.tb8.TextChanged += new System.EventHandler(this.tb8_TextChanged);
            // 
            // tb7
            // 
            this.tb7.Location = new System.Drawing.Point(58, 83);
            this.tb7.Name = "tb7";
            this.tb7.Size = new System.Drawing.Size(84, 22);
            this.tb7.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 14);
            this.label10.TabIndex = 22;
            this.label10.Text = "تومان";
            // 
            // tb9
            // 
            this.tb9.Location = new System.Drawing.Point(68, 135);
            this.tb9.Name = "tb9";
            this.tb9.Size = new System.Drawing.Size(74, 22);
            this.tb9.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(148, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 14);
            this.label8.TabIndex = 20;
            this.label8.Text = "مبلغ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 14);
            this.label4.TabIndex = 18;
            this.label4.Text = "نام راننده :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 14);
            this.label5.TabIndex = 2;
            this.label5.Text = "زمان حركت :";
            // 
            // tb5
            // 
            this.tb5.Location = new System.Drawing.Point(19, 28);
            this.tb5.Name = "tb5";
            this.tb5.Size = new System.Drawing.Size(123, 22);
            this.tb5.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 14);
            this.label6.TabIndex = 4;
            this.label6.Text = "مقصد :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(148, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 14);
            this.label7.TabIndex = 6;
            this.label7.Text = "تاريخ حركت :";
            // 
            // adp
            // 
            this.adp.DeleteCommand = this.oleDbDeleteCommand1;
            this.adp.InsertCommand = this.oleDbInsertCommand1;
            this.adp.SelectCommand = this.oleDbSelectCommand1;
            this.adp.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // ds
            // 
            this.ds.DataSetName = "NewDataSet";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(576, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 14);
            this.label11.TabIndex = 21;
            this.label11.Text = "ليست سرويس هاي امروز";
            // 
            // frm_sabteservice
            // 
            this.AcceptButton = this.b1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.b3;
            this.ClientSize = new System.Drawing.Size(738, 568);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.dataGrid1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_sabteservice";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ثبت سرويس";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frm_sabteservice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b5;
        public System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tb4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Data.OleDb.OleDbDataAdapter adp;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.DataSet ds;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb7;
        private System.Windows.Forms.TextBox tb8;
        private System.Windows.Forms.ComboBox tb6;
        private System.Windows.Forms.Label label11;
        private CrystalReport1 crystalReport11;
        private CrystalReport2 crystalReport21;

    }
}
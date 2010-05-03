namespace Taxi
{
    partial class Form_new_customer
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
            this.b2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.b1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // b2
            // 
            this.b2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.b2.Location = new System.Drawing.Point(203, 203);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(109, 45);
            this.b2.TabIndex = 6;
            this.b2.Text = "انصراف";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.tb2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tb1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(36, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 166);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Taxi.Properties.Resources.untitled;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(192, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 87);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(294, 58);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(139, 22);
            this.tb2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 14);
            this.label4.TabIndex = 20;
            this.label4.Text = "نام ونام خانوادگي :";
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(294, 92);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(139, 22);
            this.tb3.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(448, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 14);
            this.label6.TabIndex = 24;
            this.label6.Text = "شماره تلفن :";
            // 
            // tb4
            // 
            this.tb4.Location = new System.Drawing.Point(25, 125);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(408, 22);
            this.tb4.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(448, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 14);
            this.label9.TabIndex = 18;
            this.label9.Text = "آدرس :";
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(294, 26);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(139, 22);
            this.tb1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "كد اشتراك :";
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(318, 203);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(109, 45);
            this.b1.TabIndex = 5;
            this.b1.Text = "ذخيره";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // Form_new_customer
            // 
            this.AcceptButton = this.b1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Taxi.Properties.Resources.top_panel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.b2;
            this.ClientSize = new System.Drawing.Size(631, 267);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.b1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form_new_customer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اشتراك جديد";
            this.Load += new System.EventHandler(this.Form_new_customer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
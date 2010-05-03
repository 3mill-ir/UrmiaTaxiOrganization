namespace Taxi
{
    partial class Form_recovery
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
            this.button2 = new System.Windows.Forms.Button();
            this.tbBackupFileName = new System.Windows.Forms.TextBox();
            this.tbBaziaft = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.prgBackup = new System.Windows.Forms.ProgressBar();
            this.button4 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 39);
            this.button2.TabIndex = 31;
            this.button2.Text = "انصراف";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tbBackupFileName
            // 
            this.tbBackupFileName.Location = new System.Drawing.Point(80, 76);
            this.tbBackupFileName.Name = "tbBackupFileName";
            this.tbBackupFileName.Size = new System.Drawing.Size(315, 22);
            this.tbBackupFileName.TabIndex = 29;
            // 
            // tbBaziaft
            // 
            this.tbBaziaft.Enabled = false;
            this.tbBaziaft.Location = new System.Drawing.Point(292, 136);
            this.tbBaziaft.Name = "tbBaziaft";
            this.tbBaziaft.Size = new System.Drawing.Size(77, 39);
            this.tbBaziaft.TabIndex = 30;
            this.tbBaziaft.Text = "بازیافت";
            this.tbBaziaft.UseVisualStyleBackColor = true;
            this.tbBaziaft.Click += new System.EventHandler(this.tbBaziaft_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(211, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 33);
            this.label1.TabIndex = 26;
            this.label1.Text = "بازیافت فایل بکاپ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prgBackup
            // 
            this.prgBackup.Location = new System.Drawing.Point(80, 110);
            this.prgBackup.Name = "prgBackup";
            this.prgBackup.Size = new System.Drawing.Size(452, 20);
            this.prgBackup.Step = 200;
            this.prgBackup.TabIndex = 27;
            this.prgBackup.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(415, 73);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 31);
            this.button4.TabIndex = 28;
            this.button4.Text = "انتخاب فایل بکاپ ...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form_recovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 199);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbBackupFileName);
            this.Controls.Add(this.tbBaziaft);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prgBackup);
            this.Controls.Add(this.button4);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form_recovery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بازيافت ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbBackupFileName;
        private System.Windows.Forms.Button tbBaziaft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar prgBackup;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
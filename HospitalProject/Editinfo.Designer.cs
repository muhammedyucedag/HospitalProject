namespace HospitalProject
{
    partial class Editinfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editinfo));
            this.btnUpdateRecord = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mskNumber = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUpdateRecord
            // 
            this.btnUpdateRecord.Location = new System.Drawing.Point(150, 553);
            this.btnUpdateRecord.Name = "btnUpdateRecord";
            this.btnUpdateRecord.Size = new System.Drawing.Size(206, 41);
            this.btnUpdateRecord.TabIndex = 7;
            this.btnUpdateRecord.Text = "Güncelle";
            this.btnUpdateRecord.UseVisualStyleBackColor = true;
            this.btnUpdateRecord.Click += new System.EventHandler(this.btnUpdateRecord_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 458);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 24);
            this.label6.TabIndex = 24;
            this.label6.Text = "Cinsiyet:";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN"});
            this.cmbGender.Location = new System.Drawing.Point(150, 501);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(206, 32);
            this.cmbGender.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "Şifre:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(150, 408);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(206, 30);
            this.txtPassword.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "T.C. Kimlik Numarası:";
            // 
            // mskTc
            // 
            this.mskTc.Location = new System.Drawing.Point(145, 222);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(206, 30);
            this.mskTc.TabIndex = 3;
            this.mskTc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Telefon:";
            // 
            // mskNumber
            // 
            this.mskNumber.Location = new System.Drawing.Point(150, 313);
            this.mskNumber.Mask = "(999) 000-0000";
            this.mskNumber.Name = "mskNumber";
            this.mskNumber.Size = new System.Drawing.Size(206, 30);
            this.mskNumber.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ad:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(145, 134);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(206, 30);
            this.txtSurname.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(145, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(206, 30);
            this.txtName.TabIndex = 1;
            // 
            // Editinfo
            // 
            this.AcceptButton = this.btnUpdateRecord;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(496, 652);
            this.Controls.Add(this.btnUpdateRecord);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mskTc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mskNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Editinfo";
            this.Text = "Editinfo";
            this.Load += new System.EventHandler(this.Editinfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateRecord;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
    }
}
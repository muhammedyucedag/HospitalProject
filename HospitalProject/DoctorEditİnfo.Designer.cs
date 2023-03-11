namespace HospitalProject
{
    partial class DoctorEditİnfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorEditİnfo));
            this.label4 = new System.Windows.Forms.Label();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.btnUpdateİnformation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 29);
            this.label4.TabIndex = 26;
            this.label4.Text = "T.C. Kimlik Numarası:";
            // 
            // mskTc
            // 
            this.mskTc.Location = new System.Drawing.Point(150, 239);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(206, 34);
            this.mskTc.TabIndex = 25;
            this.mskTc.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Ad:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(150, 151);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(206, 34);
            this.txtSurname.TabIndex = 22;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(150, 70);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(206, 34);
            this.txtName.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 29);
            this.label5.TabIndex = 28;
            this.label5.Text = "Şifre:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(155, 431);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(206, 34);
            this.txtPassword.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 29);
            this.label3.TabIndex = 30;
            this.label3.Text = "Branş";
            // 
            // cmbBranch
            // 
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(156, 334);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(200, 35);
            this.cmbBranch.TabIndex = 31;
            // 
            // btnUpdateİnformation
            // 
            this.btnUpdateİnformation.Location = new System.Drawing.Point(155, 488);
            this.btnUpdateİnformation.Name = "btnUpdateİnformation";
            this.btnUpdateİnformation.Size = new System.Drawing.Size(206, 41);
            this.btnUpdateİnformation.TabIndex = 32;
            this.btnUpdateİnformation.Text = "Güncelle";
            this.btnUpdateİnformation.UseVisualStyleBackColor = true;
            this.btnUpdateİnformation.Click += new System.EventHandler(this.btnUpdateİnformation_Click);
            // 
            // DoctorEditİnfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(516, 555);
            this.Controls.Add(this.btnUpdateİnformation);
            this.Controls.Add(this.cmbBranch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mskTc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "DoctorEditİnfo";
            this.Text = "DoctorEditİnfo";
            this.Load += new System.EventHandler(this.DoctorEditİnfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.Button btnUpdateİnformation;
    }
}
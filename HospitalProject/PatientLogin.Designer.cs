namespace HospitalProject
{
    partial class PatientLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.lnkSignup = new System.Windows.Forms.LinkLabel();
            this.btnPatientLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "T.C. Kimlik Numarası:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // mskTc
            // 
            this.mskTc.Location = new System.Drawing.Point(327, 146);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(251, 30);
            this.mskTc.TabIndex = 1;
            this.mskTc.ValidatingType = typeof(int);
            // 
            // lnkSignup
            // 
            this.lnkSignup.AutoSize = true;
            this.lnkSignup.Location = new System.Drawing.Point(401, 253);
            this.lnkSignup.Name = "lnkSignup";
            this.lnkSignup.Size = new System.Drawing.Size(71, 24);
            this.lnkSignup.TabIndex = 3;
            this.lnkSignup.TabStop = true;
            this.lnkSignup.Text = "Üye Ol";
            this.lnkSignup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSignup_LinkClicked);
            // 
            // btnPatientLogin
            // 
            this.btnPatientLogin.Location = new System.Drawing.Point(478, 245);
            this.btnPatientLogin.Name = "btnPatientLogin";
            this.btnPatientLogin.Size = new System.Drawing.Size(100, 32);
            this.btnPatientLogin.TabIndex = 4;
            this.btnPatientLogin.Text = "Giriş Yap";
            this.btnPatientLogin.UseVisualStyleBackColor = true;
            this.btnPatientLogin.Click += new System.EventHandler(this.btnPatientLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(327, 197);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(251, 30);
            this.txtPassword.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(190, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(399, 43);
            this.label3.TabIndex = 7;
            this.label3.Text = "HASTA GİRİŞ PANELİ";
            // 
            // PatientLogin
            // 
            this.AcceptButton = this.btnPatientLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(748, 334);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnPatientLogin);
            this.Controls.Add(this.lnkSignup);
            this.Controls.Add(this.mskTc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "PatientLogin";
            this.Text = "PatientLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.LinkLabel lnkSignup;
        private System.Windows.Forms.Button btnPatientLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
    }
}
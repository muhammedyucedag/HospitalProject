namespace HospitalProject
{
    partial class Panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel));
            this.btnDoctorLogin = new System.Windows.Forms.Button();
            this.btnPatientLogin = new System.Windows.Forms.Button();
            this.btnSecreterLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDoctorLogin
            // 
            this.btnDoctorLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDoctorLogin.BackgroundImage")));
            this.btnDoctorLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoctorLogin.Location = new System.Drawing.Point(14, 280);
            this.btnDoctorLogin.Name = "btnDoctorLogin";
            this.btnDoctorLogin.Size = new System.Drawing.Size(274, 272);
            this.btnDoctorLogin.TabIndex = 0;
            this.btnDoctorLogin.UseVisualStyleBackColor = true;
            this.btnDoctorLogin.Click += new System.EventHandler(this.btnDoctorLogin_Click);
            // 
            // btnPatientLogin
            // 
            this.btnPatientLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPatientLogin.BackgroundImage")));
            this.btnPatientLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPatientLogin.Location = new System.Drawing.Point(315, 280);
            this.btnPatientLogin.Name = "btnPatientLogin";
            this.btnPatientLogin.Size = new System.Drawing.Size(274, 272);
            this.btnPatientLogin.TabIndex = 0;
            this.btnPatientLogin.UseVisualStyleBackColor = true;
            this.btnPatientLogin.Click += new System.EventHandler(this.btnPatientLogin_Click);
            // 
            // btnSecreterLogin
            // 
            this.btnSecreterLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSecreterLogin.BackgroundImage")));
            this.btnSecreterLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSecreterLogin.Location = new System.Drawing.Point(620, 280);
            this.btnSecreterLogin.Name = "btnSecreterLogin";
            this.btnSecreterLogin.Size = new System.Drawing.Size(274, 272);
            this.btnSecreterLogin.TabIndex = 0;
            this.btnSecreterLogin.UseVisualStyleBackColor = true;
            this.btnSecreterLogin.Click += new System.EventHandler(this.btnSecreterLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 572);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "DOKTOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 572);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "HASTA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(707, 572);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "SEKRETER";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(13, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 233);
            this.panel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(239, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(408, 38);
            this.label4.TabIndex = 4;
            this.label4.Text = "HEART BREAT HOSPİTAL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(354, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(907, 639);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSecreterLogin);
            this.Controls.Add(this.btnPatientLogin);
            this.Controls.Add(this.btnDoctorLogin);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Panel";
            this.Text = "Panel";
            this.Load += new System.EventHandler(this.Panel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDoctorLogin;
        private System.Windows.Forms.Button btnPatientLogin;
        private System.Windows.Forms.Button btnSecreterLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}
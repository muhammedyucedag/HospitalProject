namespace HospitalProject
{
    partial class SecreterDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecreterDetail));
            this.lblNameSurname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCreateAnnouncement = new System.Windows.Forms.Button();
            this.rchAnnouncement = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkSituation = new System.Windows.Forms.CheckBox();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.mskHour = new System.Windows.Forms.MaskedTextBox();
            this.mskDate = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnAnnouncement = new System.Windows.Forms.Button();
            this.btnMeetingPanel = new System.Windows.Forms.Button();
            this.btnBrancPanel = new System.Windows.Forms.Button();
            this.btnDoctorPanel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNameSurname
            // 
            this.lblNameSurname.AutoSize = true;
            this.lblNameSurname.Location = new System.Drawing.Point(234, 111);
            this.lblNameSurname.Name = "lblNameSurname";
            this.lblNameSurname.Size = new System.Drawing.Size(93, 24);
            this.lblNameSurname.TabIndex = 3;
            this.lblNameSurname.Text = "Null Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ad Soyad:";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(234, 52);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(142, 24);
            this.lblTc.TabIndex = 1;
            this.lblTc.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "T.C. Kimlik Numarası:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.lblNameSurname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblTc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 198);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Bilgi Sistemi";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.btnCreateAnnouncement);
            this.groupBox2.Controls.Add(this.rchAnnouncement);
            this.groupBox2.Location = new System.Drawing.Point(12, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 316);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // btnCreateAnnouncement
            // 
            this.btnCreateAnnouncement.Location = new System.Drawing.Point(6, 265);
            this.btnCreateAnnouncement.Name = "btnCreateAnnouncement";
            this.btnCreateAnnouncement.Size = new System.Drawing.Size(406, 45);
            this.btnCreateAnnouncement.TabIndex = 1;
            this.btnCreateAnnouncement.Text = "Oluştur";
            this.btnCreateAnnouncement.UseVisualStyleBackColor = true;
            this.btnCreateAnnouncement.Click += new System.EventHandler(this.btnCreateAnnouncement_Click);
            // 
            // rchAnnouncement
            // 
            this.rchAnnouncement.Location = new System.Drawing.Point(6, 29);
            this.rchAnnouncement.Name = "rchAnnouncement";
            this.rchAnnouncement.Size = new System.Drawing.Size(406, 230);
            this.rchAnnouncement.TabIndex = 0;
            this.rchAnnouncement.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.chkSituation);
            this.groupBox3.Controls.Add(this.mskTc);
            this.groupBox3.Controls.Add(this.cmbDoctor);
            this.groupBox3.Controls.Add(this.cmbBranch);
            this.groupBox3.Controls.Add(this.mskHour);
            this.groupBox3.Controls.Add(this.mskDate);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(436, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(328, 520);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rendevu Paneli";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 458);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(316, 45);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkSituation
            // 
            this.chkSituation.AutoSize = true;
            this.chkSituation.Location = new System.Drawing.Point(109, 366);
            this.chkSituation.Name = "chkSituation";
            this.chkSituation.Size = new System.Drawing.Size(97, 28);
            this.chkSituation.TabIndex = 13;
            this.chkSituation.Text = "Durum";
            this.chkSituation.UseVisualStyleBackColor = true;
            // 
            // mskTc
            // 
            this.mskTc.Location = new System.Drawing.Point(110, 301);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(189, 30);
            this.mskTc.TabIndex = 12;
            this.mskTc.ValidatingType = typeof(int);
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(110, 235);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(189, 32);
            this.cmbDoctor.TabIndex = 11;
            // 
            // cmbBranch
            // 
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(110, 172);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(189, 32);
            this.cmbBranch.TabIndex = 10;
            this.cmbBranch.SelectedIndexChanged += new System.EventHandler(this.cmbBranch_SelectedIndexChanged);
            // 
            // mskHour
            // 
            this.mskHour.Location = new System.Drawing.Point(110, 117);
            this.mskHour.Mask = "00:00";
            this.mskHour.Name = "mskHour";
            this.mskHour.Size = new System.Drawing.Size(189, 30);
            this.mskHour.TabIndex = 9;
            this.mskHour.ValidatingType = typeof(System.DateTime);
            // 
            // mskDate
            // 
            this.mskDate.Location = new System.Drawing.Point(110, 61);
            this.mskDate.Mask = "00/00/0000";
            this.mskDate.Name = "mskDate";
            this.mskDate.Size = new System.Drawing.Size(189, 30);
            this.mskDate.TabIndex = 8;
            this.mskDate.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 24);
            this.label8.TabIndex = 5;
            this.label8.Text = "Saat:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Branş:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Doktor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Hasta T.C:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tarih:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(770, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(399, 258);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branş Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(393, 229);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(770, 276);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(399, 377);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktor Listesi";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 26);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(393, 348);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox6.Controls.Add(this.btnAnnouncement);
            this.groupBox6.Controls.Add(this.btnMeetingPanel);
            this.groupBox6.Controls.Add(this.btnBrancPanel);
            this.groupBox6.Controls.Add(this.btnDoctorPanel);
            this.groupBox6.Location = new System.Drawing.Point(12, 538);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(752, 115);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hızlı Erişim";
            // 
            // btnAnnouncement
            // 
            this.btnAnnouncement.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAnnouncement.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAnnouncement.Location = new System.Drawing.Point(640, 45);
            this.btnAnnouncement.Name = "btnAnnouncement";
            this.btnAnnouncement.Size = new System.Drawing.Size(99, 45);
            this.btnAnnouncement.TabIndex = 18;
            this.btnAnnouncement.Text = "Duyuru";
            this.btnAnnouncement.UseVisualStyleBackColor = false;
            this.btnAnnouncement.Click += new System.EventHandler(this.btnAnnouncement_Click);
            // 
            // btnMeetingPanel
            // 
            this.btnMeetingPanel.Location = new System.Drawing.Point(422, 45);
            this.btnMeetingPanel.Name = "btnMeetingPanel";
            this.btnMeetingPanel.Size = new System.Drawing.Size(208, 45);
            this.btnMeetingPanel.TabIndex = 17;
            this.btnMeetingPanel.Text = "Randevu Paneli";
            this.btnMeetingPanel.UseVisualStyleBackColor = true;
            this.btnMeetingPanel.Click += new System.EventHandler(this.btnMeetingPanel_Click);
            // 
            // btnBrancPanel
            // 
            this.btnBrancPanel.Location = new System.Drawing.Point(214, 45);
            this.btnBrancPanel.Name = "btnBrancPanel";
            this.btnBrancPanel.Size = new System.Drawing.Size(198, 45);
            this.btnBrancPanel.TabIndex = 16;
            this.btnBrancPanel.Text = "Branş Paneli";
            this.btnBrancPanel.UseVisualStyleBackColor = true;
            this.btnBrancPanel.Click += new System.EventHandler(this.btnBrancPanel_Click);
            // 
            // btnDoctorPanel
            // 
            this.btnDoctorPanel.Location = new System.Drawing.Point(12, 45);
            this.btnDoctorPanel.Name = "btnDoctorPanel";
            this.btnDoctorPanel.Size = new System.Drawing.Size(192, 45);
            this.btnDoctorPanel.TabIndex = 15;
            this.btnDoctorPanel.Text = "Doktor Paneli";
            this.btnDoctorPanel.UseVisualStyleBackColor = true;
            this.btnDoctorPanel.Click += new System.EventHandler(this.btnDoctorPanel_Click);
            // 
            // SecreterDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1175, 663);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SecreterDetail";
            this.Text = "SecreterDetail";
            this.Load += new System.EventHandler(this.SecreterDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNameSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCreateAnnouncement;
        private System.Windows.Forms.RichTextBox rchAnnouncement;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkSituation;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.MaskedTextBox mskHour;
        private System.Windows.Forms.MaskedTextBox mskDate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnMeetingPanel;
        private System.Windows.Forms.Button btnBrancPanel;
        private System.Windows.Forms.Button btnDoctorPanel;
        private System.Windows.Forms.Button btnAnnouncement;
    }
}
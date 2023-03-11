using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HospitalProject
{
    public partial class PatientLogin : Form
    {
        public PatientLogin()
        {
            InitializeComponent();
        }
        SqlConnectionClass scc = new SqlConnectionClass();
        private void lnkSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PatientRegistration pr = new PatientRegistration();
            pr.Show();
        }

        private void btnPatientLogin_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from Hastalar Where HastaTc=@p1 and HastaSifre=@p2", scc.connection());
            command.Parameters.AddWithValue("@p1", mskTc.Text);
            command.Parameters.AddWithValue("@p2", txtPassword.Text);
            // şimdi komuttan gelen değerleri okuması için komut giriyoruz.
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                PatientDetail pd = new PatientDetail();
                pd.tcnamesurname = mskTc.Text;
                pd.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı T.C. & Şifre Girişi Yapıldı");
            }
            scc.connection().Close();
        }
    }
}   
    
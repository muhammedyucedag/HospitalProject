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
    public partial class SecreterLogin : Form
    {
        public SecreterLogin()
        {
            InitializeComponent();
        }
        SqlConnectionClass scc = new SqlConnectionClass();
        private void btnPatientLogin_Click(object sender, EventArgs e)
        {
            SqlCommand comman = new SqlCommand("select * from Sekreterler where SekreterTC=@p1 and SekreterSifre=@p2",scc.connection());
            comman.Parameters.AddWithValue("@p1", mskTc.Text);
            comman.Parameters.AddWithValue("@p2",txtPassword.Text);
            SqlDataReader dr=comman.ExecuteReader();

            if (dr.Read())
            {
                SecreterDetail scd = new SecreterDetail();
                scd.TCnumara = mskTc.Text;
                scd.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC & Şifre Girişi");
            }
            scc.connection().Close();   
        }
    }
}

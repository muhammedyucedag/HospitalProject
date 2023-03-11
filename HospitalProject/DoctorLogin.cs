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
    public partial class DoctorLogin : Form
    {
        public DoctorLogin()
        {
            InitializeComponent();
        }
        SqlConnectionClass scc = new SqlConnectionClass();
        private void btnPatientLogin_Click(object sender, EventArgs e)
        {
            SqlCommand comman = new SqlCommand("select * from Doktorlar where DoktorTC=@p1 and DoktorSifre=@p2", scc.connection());
            comman.Parameters.AddWithValue("@p1", mskTc.Text);
            comman.Parameters.AddWithValue("@p2", txtPassword.Text);
            SqlDataReader dr = comman.ExecuteReader();
            if (dr.Read())
            {
                DoctorDetail dd = new DoctorDetail();
                dd.TC = mskTc.Text;
                dd.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre Girişi");
            }
            scc.connection().Close();
        }
    }
}

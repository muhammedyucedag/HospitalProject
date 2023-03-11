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
    public partial class DoctorEditİnfo : Form
    {
        public DoctorEditİnfo()
        {
            InitializeComponent();
        }
        SqlConnectionClass scc = new SqlConnectionClass();
        public string TCNO;
        private void DoctorEditİnfo_Load(object sender, EventArgs e)
        {
            mskTc.Text = TCNO;

            SqlCommand comman = new SqlCommand("select * from Doktorlar where DoktorTC=@p1", scc.connection());
            comman.Parameters.AddWithValue("@p1", mskTc.Text);
            SqlDataReader dr = comman.ExecuteReader();

            while (dr.Read())
            {
                txtName.Text = dr[1].ToString();
                txtSurname.Text = dr[2].ToString();
                cmbBranch.Text = dr[3].ToString();
                txtPassword.Text = dr[4].ToString();
            }
            scc.connection().Close();
        }

        private void btnUpdateİnformation_Click(object sender, EventArgs e)
        {
            SqlCommand comman = new SqlCommand("update Doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 where DoktorTC=@p5", scc.connection());
            comman.Parameters.AddWithValue("@p1", txtName.Text);
            comman.Parameters.AddWithValue("@p2", txtSurname.Text);
            comman.Parameters.AddWithValue("@p3", cmbBranch.Text);
            comman.Parameters.AddWithValue("@p4", txtPassword.Text);
            comman.Parameters.AddWithValue("@p5", mskTc.Text);
            // hata şifre yerine tc geliyor
            comman.ExecuteNonQuery();
            scc.connection().Close();
            MessageBox.Show("Bilgileriniz Güncellendi");
        }
    }
}

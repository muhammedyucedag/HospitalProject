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
    public partial class Editinfo : Form
    {
        public Editinfo()
        {
            InitializeComponent();
        }

        public string TCno;

        SqlConnectionClass scc = new SqlConnectionClass();
        private void Editinfo_Load(object sender, EventArgs e)
        {
            // Bilgileri Düzenle Kısmına Hastamızın Tüm bilgilerini aktarma işlemi

            mskTc.Text = TCno;
            SqlCommand comman = new SqlCommand("select * from Hastalar where HastaTc=@p1", scc.connection());
            comman.Parameters.AddWithValue("@p1", mskTc.Text);
            SqlDataReader dr = comman.ExecuteReader();
            
            while (dr.Read())
            {
                txtName.Text = dr[1].ToString();
                txtSurname.Text = dr[2].ToString();
                mskTc.Text = dr[3].ToString();
                mskNumber.Text = dr[4].ToString();
                txtPassword.Text = dr[5].ToString();
                cmbGender.Text = dr[6].ToString();
            }
            scc.connection().Close();

        }

        private void btnUpdateRecord_Click(object sender, EventArgs e)
        {
            SqlCommand comman2 = new SqlCommand("update Hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTC=@p3,HastaTelefon=@p4,HastaSifre=@p5,HastaCinsiyet=@p6",scc.connection());
            comman2.Parameters.AddWithValue("@p1", txtName.Text);
            comman2.Parameters.AddWithValue("@p2", txtSurname.Text);
            comman2.Parameters.AddWithValue("@p3", mskTc.Text);
            comman2.Parameters.AddWithValue("@p4", mskNumber.Text);
            comman2.Parameters.AddWithValue("@p5", txtPassword.Text);
            comman2.Parameters.AddWithValue("@p6", cmbGender.Text);
            comman2.ExecuteNonQuery(); // bu komut insert update ve delet sorgularında çalışır
            scc.connection().Close();

            MessageBox.Show("Bilgileriniz Güncellenmiştir","bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}

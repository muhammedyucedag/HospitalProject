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
    public partial class PatientRegistration : Form
    {
        public PatientRegistration()
        {
            InitializeComponent();
        }

        SqlConnectionClass scc = new SqlConnectionClass();

        private void btnSignup_Click(object sender, EventArgs e)
        {
            // scc.connection()  scc yukarıdaki kısaltma conneciton da SqlConnectionClass daki Metodumun adı Direk olarak clası tanımlıyorum ve sql tanımlanıyor.

            SqlCommand command = new SqlCommand("insert into Hastalar (HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)", scc.connection());

            // şimdi parametreleri giriyoruz

            command.Parameters.AddWithValue("@p1", txtName.Text);
            command.Parameters.AddWithValue("@p2", txtSurname.Text);
            command.Parameters.AddWithValue("@p3", mskTc.Text);
            command.Parameters.AddWithValue("@p4", mskNumber.Text);
            command.Parameters.AddWithValue("@p5", txtPassword.Text);
            command.Parameters.AddWithValue("@p6", cmbGender.Text);

            // sorguyu çalıştırmak için komut giriyoruz.

            command.ExecuteNonQuery();
            scc.connection().Close();
            MessageBox.Show("Kaydınız Gerçekleşmiştir Şifreniz" + txtPassword.Text,"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

            // HASTA KAYIT İŞLEMİMİZ TAMAM


        }

        private void PatientRegistration_Load(object sender, EventArgs e)
        {

        }

        private void PatientRegistration_Load_1(object sender, EventArgs e)
        {

        }
    }
}

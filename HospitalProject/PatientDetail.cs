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
    public partial class PatientDetail : Form
    {
        public PatientDetail()
        {
            InitializeComponent();
        }
        public string tcnamesurname;

        SqlConnectionClass scc = new SqlConnectionClass();
        private void PatientDetail_Load(object sender, EventArgs e)
        {
            lblTc.Text = tcnamesurname;


            // Ad Soyad Çekme İşlmei

            SqlCommand comman = new SqlCommand("select HastaAd,HastaSoyad from Hastalar where HastaTC=@p1", scc.connection());
            comman.Parameters.AddWithValue("@p1", tcnamesurname);
            SqlDataReader dr = comman.ExecuteReader();  

            while (dr.Read())
            {
                // bu kod satırında lblnamesurname olan kısma ne yazdıracak [0] adı [1] soyadı yan yana 
                lblNameSurname.Text = dr[0] + " " + dr[1];
            }
            scc.connection().Close();


            // Randevu Geçmişi
            // dataadapter komutu datagridwier deki verileri aktarmam için kullanılan komut 
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Randevular where HastaTc=" + tcnamesurname, scc.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            // Branşları Çekme 

            SqlCommand comman2 = new SqlCommand("select BransAd from Branslar", scc.connection());
            SqlDataReader dr2 = comman2.ExecuteReader();

            while (dr2.Read())
            {
                cmbBranch.Items.Add(dr2[0]);
            }
            scc.connection().Close();


        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            // cmbBranch ' a branşlara göre doktorları adını ve soy adını çekme
            cmbDoctor.Items.Clear();

            SqlCommand comman3 = new SqlCommand("select DoktorAd,DoktorSoyad from Doktorlar where DoktorBrans=@p1", scc.connection());
            comman3.Parameters.AddWithValue("@p1", cmbBranch.Text);
            SqlDataReader dr3 = comman3.ExecuteReader();

            while (dr3.Read())
            {
                cmbDoctor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            scc.connection().Close();
        }

        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Doktor Adına Göre Randevuları Gösterme işlemi

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Randevular where RandevuBrans='" + cmbBranch.Text + "' and  RandevuDoktor='" + cmbDoctor.Text + "'", scc.connection());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void lnkEditinfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Editinfo ei = new Editinfo();
            ei.TCno = lblTc.Text;
            ei.Show();

        }

        private void btnMeeting_Click(object sender, EventArgs e)
        {
            SqlCommand comman = new SqlCommand("update Randevular set RandevuDurum=1,HastaTc=@p1,HastaSikayet=@p2 where Randevuİd=@p3",scc.connection());
            comman.Parameters.AddWithValue("@p1", lblTc.Text);
            comman.Parameters.AddWithValue("@p2", rchComplaint.Text);
            comman.Parameters.AddWithValue("@p3", txtid.Text);
            comman.ExecuteNonQuery();
            scc.connection().Close();
            MessageBox.Show("Randevu Alındı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

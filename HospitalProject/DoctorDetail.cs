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
    public partial class DoctorDetail : Form
    {
        public DoctorDetail()
        {
            InitializeComponent();
        }
        SqlConnectionClass scc = new SqlConnectionClass();
        public string TC;
        private void DoctorDetail_Load(object sender, EventArgs e)
        {
            // Doktor Tc doktor detaya çekme işlemi
            lblTc.Text = TC;

            // Doktor ad soyad detaya çekme işlemi
            SqlCommand comman = new SqlCommand("select DoktorAd,DoktorSoyad from Doktorlar where DoktorTC=@p1", scc.connection());
            comman.Parameters.AddWithValue("@p1", lblTc.Text);
            SqlDataReader dr = comman.ExecuteReader();
            // if kullanmadık çünkü if sadece eşitlik durumunda kullanılır.
            while (dr.Read())
            {
                lblNameSurname.Text = dr[0] + " " + dr[1];

            }
            scc.connection().Close();

            // Randevular 
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Randevular where RandevuDoktor='" + lblNameSurname.Text+"'", scc.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;  
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DoctorEditİnfo dei = new DoctorEditİnfo();
            dei.TCNO = lblTc.Text;
            dei.Show();
            
        }

        private void btnAnnouncement_Click(object sender, EventArgs e)
        {
            Announcement at = new Announcement();
            at.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            rchComplaint.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}

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
    public partial class SecreterDetail : Form
    {
        public SecreterDetail()
        {
            InitializeComponent();
        }
        SqlConnectionClass scc = new SqlConnectionClass();
        public string TCnumara;
        private void SecreterDetail_Load(object sender, EventArgs e)
        {
            lblTc.Text = TCnumara;
            // ad soyad 

            SqlCommand comman1 = new SqlCommand("select SekreterAdSoyad from sekreterler where SekreterTC=@p1", scc.connection());
            comman1.Parameters.AddWithValue("@p1", lblTc.Text);
            SqlDataReader dr1 = comman1.ExecuteReader();

            while (dr1.Read())
            {
                lblNameSurname.Text = dr1[0].ToString();

            }
            scc.connection().Close();

            // Branşları data gride aktarma

            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Branslar", scc.connection());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            // Doktorları Listeye Aktarma 

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select (DoktorAd + ' ' + DoktorSoyad) as ' Doktorlar ', DoktorBrans from Doktorlar", scc.connection());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            // Bransı Combobax'a Aktarma
            SqlCommand komut2 = new SqlCommand("select BransAd from Branslar", scc.connection());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBranch.Items.Add(dr2[0]);
            }
            scc.connection().Close();

            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // yeni bir kaydetme yapacağz 

            SqlCommand komutkaydet = new SqlCommand("insert into Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor,HastaTC,RandevuDurum,HastaSikayet) values (@r1,@r2,@r3,@r4,@r5,@r6,@r7)",scc.connection());

            // Şimdi parametreleri giriyoruz

            komutkaydet.Parameters.AddWithValue("@r1", mskDate.Text);
            komutkaydet.Parameters.AddWithValue("@r2", mskHour.Text);
            komutkaydet.Parameters.AddWithValue("@r3", cmbBranch.Text);
            komutkaydet.Parameters.AddWithValue("@r4", cmbDoctor.Text);
            komutkaydet.Parameters.AddWithValue("@r5", mskTc.Text);
            komutkaydet.Parameters.AddWithValue("@r6", chkSituation.Checked);
            komutkaydet.Parameters.AddWithValue("@r7", "Burası düzeltilecek.");
            komutkaydet.ExecuteNonQuery();
            scc.connection().Close();
            MessageBox.Show("Randevu Oluşturuldu");
        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoctor.Items.Clear();

            SqlCommand komut = new SqlCommand("select DoktorAd,DoktorSoyad from Doktorlar where DoktorBrans=@p1", scc.connection());
            komut.Parameters.AddWithValue("@p1", cmbBranch.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbDoctor.Items.Add(dr[0] + " " + dr[1]);
            }
            scc.connection().Close();
        }

        private void btnCreateAnnouncement_Click(object sender, EventArgs e)
        {
            SqlCommand comman = new SqlCommand("insert into Duyurular (duyuru) values (@d1)", scc.connection());
            comman.Parameters.AddWithValue("@d1", rchAnnouncement.Text);
            comman.ExecuteNonQuery();
            scc.connection().Close();
            MessageBox.Show("Duyuru Oluşturuldu");
        }

        private void btnDoctorPanel_Click(object sender, EventArgs e)
        {
            DoctorPanel dp = new DoctorPanel();
            dp.Show();

        }

        private void btnBrancPanel_Click(object sender, EventArgs e)
        {
            Branch bh = new Branch();
            bh.Show();
        }

        private void btnMeetingPanel_Click(object sender, EventArgs e)
        {
            AppointmentList list = new AppointmentList();
            list.Show();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
                
        }

        private void btnAnnouncement_Click(object sender, EventArgs e)
        {
            Announcement act = new Announcement();
            act.Show();

        }
    }
}

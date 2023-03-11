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
    public partial class DoctorPanel : Form
    {
        public DoctorPanel()
        {
            InitializeComponent();
        }

        SqlConnectionClass scc = new SqlConnectionClass();

        private void DoctorPanel_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from Doktorlar", scc.connection());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            // Branları ComboBax'a Aktarma işlemi

            SqlCommand comman = new SqlCommand("select BransAd from Branslar", scc.connection());
            SqlDataReader dr = comman.ExecuteReader();
            while (dr.Read())
            {
                cmbBranch.Items.Add(dr[0]);
            }
            scc.connection().Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // insert into işlemi Eklemeye yarar 

            SqlCommand comman = new SqlCommand("insert into Doktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) values (@d1,@d2,@d3,@d4,@d5)", scc.connection());
            comman.Parameters.AddWithValue("@d1", txtName.Text);
            comman.Parameters.AddWithValue("@d2", txtSurname.Text);
            comman.Parameters.AddWithValue("@d3", cmbBranch.Text);
            comman.Parameters.AddWithValue("@d4", mskTc.Text);
            comman.Parameters.AddWithValue("@d5", txtPassword.Text);
            comman.ExecuteNonQuery();
            scc.connection().Close();
            MessageBox.Show("Doktor Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // buradaki işlem Doktor Panelindeki Datagrid de herhangi bir stüna tıkladığım zaman soldaki box lara verileri aktaracak

            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtName.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSurname.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbBranch.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskTc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtPassword.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // delete komutu Silme işlermini yapar 

            SqlCommand comman = new SqlCommand("delete from Doktorlar where DoktorTC=@p1", scc.connection());
            comman.Parameters.AddWithValue("@p1", mskTc.Text);
            comman.ExecuteNonQuery();
            scc.connection().Close();
            MessageBox.Show("Kayıt Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand comman = new SqlCommand("Update Doktorlar set DoktorAd=@d1,DoktorSoyad=@d2,DoktorBrans=@d3,DoktorTC=@d4,DoktorSifre=@d5 Where DoktorTC=@d4", scc.connection());
            comman.Parameters.AddWithValue("@d1", txtName.Text);
            comman.Parameters.AddWithValue("@d2", txtSurname.Text);
            comman.Parameters.AddWithValue("@d3", cmbBranch.Text);
            comman.Parameters.AddWithValue("@d4", mskTc.Text);
            comman.Parameters.AddWithValue("@d5", txtPassword.Text);
            comman.ExecuteNonQuery();
            scc.connection().Close();
            MessageBox.Show("Doktor Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
    
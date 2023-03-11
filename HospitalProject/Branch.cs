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
    public partial class Branch : Form
    {
        public Branch()
        {
            InitializeComponent();
        }

        SqlConnectionClass scc = new SqlConnectionClass();

        private void Branch_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Branslar", scc.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand comman = new SqlCommand("insert into Branslar (BransAd) values (@b1)", scc.connection());
            comman.Parameters.AddWithValue("@b1",txtBranchName.Text);
            comman.ExecuteNonQuery();
            scc.connection().Close();
            MessageBox.Show("Branş Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtBranchid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtBranchName.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand comman = new SqlCommand("delete from Branslar where Bransid=@b1", scc.connection());
            comman.Parameters.AddWithValue("@b1", txtBranchid.Text);
            comman.ExecuteNonQuery();
            scc.connection().Close();
            MessageBox.Show("Branş Silindi");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand comman = new SqlCommand("update Branslar set BransAd=@p1 where Bransid=@p2", scc.connection());
            comman.Parameters.AddWithValue("@p1",txtBranchName.Text);
            comman.Parameters.AddWithValue("@p2",txtBranchid.Text);
            comman.ExecuteNonQuery();
            scc.connection().Close();
            MessageBox.Show("Branş Güncellendi");
        }
    }
}

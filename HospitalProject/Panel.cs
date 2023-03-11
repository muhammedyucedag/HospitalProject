using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalProject
{
    public partial class Panel : Form
    {
        public Panel()
        {
            InitializeComponent();
        }

        private void btnPatientLogin_Click(object sender, EventArgs e)
        {
            PatientLogin pl = new PatientLogin();
            pl.Show();
            this.Hide();
        }

        private void btnDoctorLogin_Click(object sender, EventArgs e)
        {
            DoctorLogin dl = new DoctorLogin();
            dl.Show();
            this.Hide();
        }

        private void btnSecreterLogin_Click(object sender, EventArgs e)
        {
            SecreterLogin sl = new SecreterLogin();
            sl.Show();
            this.Hide();
        }

        private void Panel_Load(object sender, EventArgs e)
        {

        }
    }
}

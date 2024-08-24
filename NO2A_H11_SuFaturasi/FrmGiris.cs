using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NO2A_H11_SuFaturasi
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtMail.Text, @"\S") && Regex.IsMatch(txtSifre.Text, @"\S"))
            {
                Genel.kullanici = Genel.db.Kullanici.Where(x => x.Mail == txtMail.Text && x.Sifre == txtSifre.Text).FirstOrDefault();
                if (Genel.kullanici != null)
                {
                    FrmAna frm = new FrmAna();
                    frm.Show();
                    Hide();
                }
                else
                    MessageBox.Show("Mail veya Şifre Hatalıdır");
            }
            else
                MessageBox.Show("Mail ve Şifre Bilgilerini Giriniz");
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {

        }
    }
}

using NO2A_H08_SuFaturasi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NO2A_H11_SuFaturasi
{
    public partial class FrmAna : Form
    {
        public FrmAna()
        {
            InitializeComponent();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            FrmMusteriDetay frm = new FrmMusteriDetay();
            frm.TopLevel = false;
            Controls.Add(frm);
            frm.Show();
            frm.Top = 50;
            frm.Left = 250;
        }

        private void btnMusteriList_Click(object sender, EventArgs e)
        {
            FrmMusteriList frm = new FrmMusteriList();
            frm.TopLevel = false;
            Controls.Add(frm);
            frm.Show();
            frm.Top = 50;
            frm.Left = 250;
        }

        private void FrmAna_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnYeniFatura_Click(object sender, EventArgs e)
        {
            FrmFatura frm = new FrmFatura();
            frm.TopLevel = false;
            Controls.Add(frm);
            frm.Show();
            frm.Top = 50;
            frm.Left = 250;
        }

        private void FrmAna_Load(object sender, EventArgs e)
        {

        }
    }
}

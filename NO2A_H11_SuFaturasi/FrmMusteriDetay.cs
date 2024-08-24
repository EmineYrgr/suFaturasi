using NO2A_H08_SuFaturasi;
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
    public partial class FrmMusteriDetay : Form
    {
        Musteri musteri;
        public FrmMusteriDetay(int MusteriID = 0)
        {
            InitializeComponent();
            if (MusteriID == 0)
                musteri = new Musteri();
            else
                musteri = Genel.db.Musteri.Find(MusteriID);
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMusteriDetay_Load(object sender, EventArgs e)
        {
            comboIl.DisplayMember = "Il_Adi";
            comboIl.ValueMember = "ID";
            comboIl.DataSource = Genel.db.iller.ToList();

            radioBahce.Checked = musteri.AboneTuru == "B";
            radioMesken.Checked = musteri.AboneTuru == "M" || musteri.AboneTuru == null;
            radioTicari.Checked = musteri.AboneTuru == "T";

            txtTCKN.Text = musteri.TCKN;
            txtAdSoyad.Text = musteri.AdSoyad;
            txtSayacNo.Text = musteri.SayacNo;
            txtCepTelefonu.Text = musteri.CepTelefonu;
            txtAdres.Text = musteri.Adres;

            comboIl.SelectedValue = musteri.Il_ID > 0 ? musteri.Il_ID : 42;
            comboIlce.SelectedValue = musteri.Ilce_ID;
        }

        private void comboIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Il_ID = (int)comboIl.SelectedValue;
            comboIlce.DisplayMember = "IlceAdi";
            comboIlce.ValueMember = "ID";
            comboIlce.DataSource = Genel.db.ilceler.Where(x => x.Il_ID == Il_ID).ToList();

        }

        private void btnKaydetGuncelle_Click(object sender, EventArgs e)
        {
            string cepTelefonu = Regex.Replace(txtCepTelefonu.Text, @"\D", "");
            string aboneTuru = radioBahce.Checked ? "B" : radioMesken.Checked ? "M" : radioTicari.Checked ? "T" : null;

            Genel.db.Musteri.Add(new NO2A_H08_SuFaturasi.Musteri()
            {
                TCKN = txtTCKN.Text,
                AdSoyad = txtAdSoyad.Text,
                SayacNo = txtSayacNo.Text,
                CepTelefonu = cepTelefonu,
                Adres = txtAdres.Text,
                Il_ID = (int)comboIl.SelectedValue,
                Ilce_ID = (int)comboIlce.SelectedValue,
                AboneTuru = aboneTuru
            }
                );
            Genel.db.SaveChanges();
        }
    }
}

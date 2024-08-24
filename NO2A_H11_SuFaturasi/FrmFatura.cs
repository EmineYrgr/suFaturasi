using NO2A_H11_SuFaturasi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NO2A_H08_SuFaturasi
{
    public partial class FrmFatura : Form
    {
        public FrmFatura()
        {
            InitializeComponent();
        }

        Musteri musteri;
        private void FrmFatura_Load(object sender, EventArgs e)
        {
            comboMusteriID.DataSource = Genel.db.Musteri.ToList();
            comboMusteriID.DisplayMember = "SayacNo";

            dateTarih.Value = DateTime.Now;
            dateSonOdemeTarih.Value = DateTime.Today.AddDays(15);
        }
        private void dateTarih_ValueChanged(object sender, EventArgs e)
        {
            dateSonOdemeTarih.Value = dateTarih.Value.Date.AddDays(15);
        }
        private void comboMusteriID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                musteri = comboMusteriID.SelectedItem as Musteri;
                var fatura = Genel.db.Fatura.Where(x => x.MusteriID == musteri.ID).ToList().Last();
                numericIlkEndeks.Value = fatura.SonEndeks;
            }
            catch
            {
                numericIlkEndeks.Value = 0;
            }
            numericSonEndeks.Minimum = numericIlkEndeks.Value;
        }
        double tutar = 0;
        private void numericSonEndeks_ValueChanged(object sender, EventArgs e)
        {
            int tuketim = Convert.ToInt32(numericSonEndeks.Value - numericIlkEndeks.Value);

            tutar = (double)tuketim *
                    (musteri.AboneTuru == "B" ? 1.5 :
                    musteri.AboneTuru == "M" ? 3 :
                    musteri.AboneTuru == "T" ? 4.5 : 0);

            lblTutar.Text = tutar.ToString("N2") + " TL";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Genel.db.Fatura.Add(new Fatura()
            {
                IlkEndeks = (int)numericIlkEndeks.Value,
                MusteriID = musteri.ID,
                SonEndeks = (int)numericSonEndeks.Value,
                SonOdemeTarihi = dateSonOdemeTarih.Value,
                Tarih = dateTarih.Value,
                Tutar = Convert.ToDecimal(tutar)
            });

            Genel.db.SaveChanges();
        }
    }
}

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
    public partial class FrmMusteriList : Form
    {
        public FrmMusteriList()
        {
            InitializeComponent();
        }

        private void FrmMusteriList_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Genel.db.View_MusteriList.ToList();
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["Adres"].Visible = false;
            dataGridView1.Columns["Il_ID"].Visible = false;
            dataGridView1.Columns["Ilce_ID"].Visible = false;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //if(e.ColumnIndex==0)
            if (dataGridView1.Columns[e.ColumnIndex].Name == "edit")
            {
                int MusteriID = (int)dataGridView1.Rows[e.RowIndex].Cells["ID"].Value;
                FrmMusteriDetay frm = new FrmMusteriDetay(MusteriID);
                frm.ShowDialog();
            }
        }
    }
}

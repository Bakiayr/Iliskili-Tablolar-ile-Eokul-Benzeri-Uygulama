using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotSistemi_OrnekProje
{
    public partial class FrmDersler : Form
    {
        public FrmDersler()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.Tbl_DersTableAdapter ds = new DataSet1TableAdapters.Tbl_DersTableAdapter();

        private void FrmDersler_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.DersListesi();
        }

        private void pictureBox_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.DersListesi();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            ds.DersEkle(txt_dersAd.Text);
            MessageBox.Show("Ders Başarıyla Eklendi!");
        }

        private void btn_Güncelle_Click(object sender, EventArgs e)
        {
            ds.DersGuncelle(txt_dersAd.Text, byte.Parse(txt_dersID.Text));
            MessageBox.Show("Ders Güncellenmiştir!");
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            ds.DersSil(byte.Parse(txt_dersID.Text));
            MessageBox.Show("Ders Silinmiştir!");

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_dersID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_dersAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}

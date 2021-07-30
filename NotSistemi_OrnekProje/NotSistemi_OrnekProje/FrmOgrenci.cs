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

namespace NotSistemi_OrnekProje
{
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.DataTable1TableAdapter data = new DataSet1TableAdapters.DataTable1TableAdapter();
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-RT3Q6PB\SQLEXPRESS;Initial Catalog=BonusOkul;Integrated Security=True");

        private void radioBtn_Erkek_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "Erkek";
        }

        private void radioBtn_Kız_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "Kız";
        }

        private void pictureBox_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = data.OgrenciListele();

            //comboBox a verileri çekme işlemi 
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *From Tbl_Kulup", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //         !!!!!!!!
            cmb_Kulup.DisplayMember = "KULUPADI";
            cmb_Kulup.ValueMember = "KULUPID";
            cmb_Kulup.DataSource = dt;
            baglanti.Close();
        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = data.OgrenciListele();
        }

        private void btn_Güncelle_Click(object sender, EventArgs e)
        {
            data.OgrenciGuncelle(txt_ogrenciAd.Text, txt_ogrenciSoyad.Text, byte.Parse(cmb_Kulup.SelectedValue.ToString()), label7.Text, int.Parse(txt_ogrenciID.Text));
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            data.OgrenciSil(int.Parse(txt_ogrenciID.Text));
            MessageBox.Show("Öğrenci Başarıyla Silindi!");
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            data.OgrenciEkle(txt_ogrenciAd.Text, txt_ogrenciSoyad.Text, byte.Parse(cmb_Kulup.SelectedValue.ToString()), label7.Text);
            MessageBox.Show("Öğrenci Başarıyla Eklendi!");
        }

        private void cmb_Kulup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ogrenciID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_ogrenciAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_ogrenciSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmb_Kulup.DisplayMember = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            label7.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            if (label7.Text == "Kız")
            {
                radioBtn_Kız.Checked = true;
            }
            else
                radioBtn_Erkek.Checked = true;
        }

        private void txt_Arama_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = data.OgrenciGetir(txt_Arama.Text);
        }
    }
}

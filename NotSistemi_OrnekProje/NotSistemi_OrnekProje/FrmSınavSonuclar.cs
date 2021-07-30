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
    public partial class FrmSınavSonuclar : Form
    {
        public FrmSınavSonuclar()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.Tbl_NotTableAdapter ds = new DataSet1TableAdapters.Tbl_NotTableAdapter();
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-RT3Q6PB\SQLEXPRESS;Initial Catalog=BonusOkul;Integrated Security=True");

        private void btn_Ara_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.NotListesi(byte.Parse(txt_ogrenciID.Text));
        }

        private void FrmSınavSonuclar_Load(object sender, EventArgs e)
        {
            //comboBox a verileri çekme işlemi s
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *From Tbl_Ders", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //         !!!!!!!!
            cmb_Dersler.DisplayMember = "DERSAD";
            cmb_Dersler.ValueMember = "DERSID";
            cmb_Dersler.DataSource = dt;
            baglanti.Close();
        }
        int notid;
        bool durum;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            notid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_ogrenciID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_sınav1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_sınav2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_sınav3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_Proje.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_Ortalama.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_Durum.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btn_Hesapla_Click(object sender, EventArgs e)
        {
            int sinav1, sinav2, sinav3, proje;
            double ortalama;

            sinav1 = Convert.ToInt16(txt_sınav1.Text);
            sinav2 = Convert.ToInt16(txt_sınav2.Text);
            sinav3 = Convert.ToInt16(txt_sınav3.Text);
            proje = Convert.ToInt16(txt_Proje.Text);
            ortalama = (sinav1 + sinav2 + sinav3 + proje) / 4;
            txt_Ortalama.Text = ortalama.ToString();
            if (ortalama >= 50) { 
                txt_Durum.Text = "GEÇTİ";
                durum = true;
            }
            else { 
                txt_Durum.Text = "KALDI";
                durum = false;
            }
        }

        private void btn_Güncelle_Click(object sender, EventArgs e)
        {
            ds.NotGuncelle(byte.Parse(cmb_Dersler.SelectedValue.ToString()), int.Parse(txt_ogrenciID.Text), byte.Parse(txt_sınav1.Text), byte.Parse(txt_sınav2.Text), byte.Parse(txt_sınav3.Text), byte.Parse(txt_Proje.Text), decimal.Parse(txt_Ortalama.Text),durum,notid);
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            txt_Durum.Text = "";
            txt_ogrenciID.Text = "";
            txt_Ortalama.Text = "";
            txt_Proje.Text = "";
            txt_sınav1.Text = "";
            txt_sınav2.Text = "";
            txt_sınav3.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

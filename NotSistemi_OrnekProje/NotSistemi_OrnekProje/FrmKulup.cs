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
    public partial class FrmKulup : Form
    {
        public FrmKulup()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-RT3Q6PB\SQLEXPRESS;Initial Catalog=BonusOkul;Integrated Security=True");
       
        void liste()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Kulup", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void FrmKulup_Load(object sender, EventArgs e)
        {
            liste();
        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            liste();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into Tbl_Kulup (KulupAdı) values (@p1)", baglanti);
            komut.Parameters.AddWithValue("@p1", txt_KulupAd.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kulüp Listeye Eklendi!!");
            liste();

        }

        private void pictureBox_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_KulupID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_KulupAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete From Tbl_Kulup where KulupID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txt_KulupID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kulüp Silme İşlemi Gerçekleşti!");
            liste();
        }

        private void btn_Güncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update Tbl_Kulup set KulupAdı=@a1 where KulupID=@a2", baglanti);
            komut.Parameters.AddWithValue("@a1", txt_KulupAd.Text);
            komut.Parameters.AddWithValue("@a2", txt_KulupID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kulüp İsmi Güncellendi!!");
        }
    }
}

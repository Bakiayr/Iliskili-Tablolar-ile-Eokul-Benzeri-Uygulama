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
    public partial class FrmOgrenciNotlar : Form
    {
        public FrmOgrenciNotlar()
        {
            InitializeComponent();
        }
        public string numara;
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-RT3Q6PB\SQLEXPRESS;Initial Catalog=BonusOkul;Integrated Security=True");

        private void FrmOgrenciNotlar_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select DERSAD,SINAV1,SINAV2,SINAV3,PROJE,ORTALAMA,DURUM from Tbl_Not INNER JOIN Tbl_Ders ON Tbl_Not.DERSID = Tbl_Ders.DERSID Where OGRID = @p1", baglanti);
            komut.Parameters.AddWithValue("@p1", numara);
            baglanti.Open();
            SqlCommand isimgetirme = new SqlCommand("select OGRAD,OGRSOYAD from Tbl_Ogrenci where OGRID='" + numara + "'", baglanti);
            SqlDataReader dr = isimgetirme.ExecuteReader();
            while (dr.Read())
            {
                this.Text = dr[0] + " " + dr[1];
            }
            baglanti.Close();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }
    }
}

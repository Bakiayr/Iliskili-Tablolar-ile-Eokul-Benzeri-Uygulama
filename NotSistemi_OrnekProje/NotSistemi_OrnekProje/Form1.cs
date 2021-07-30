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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox_Ogrenci_Click(object sender, EventArgs e)
        {
            FrmOgrenciNotlar frm = new FrmOgrenciNotlar();
            frm.numara = textBox_Numara.Text;
            frm.Show();
            this.Hide();
        }

        private void pictureBox_Ogretmen_Click(object sender, EventArgs e)
        {
            FrmOgretmen fr = new FrmOgretmen();
            fr.Show();
            this.Hide();
        }
    }
}

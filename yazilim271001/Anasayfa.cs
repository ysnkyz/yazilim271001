using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazilim271001
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 musteri= new Form3();
            musteri.MdiParent = this;
            musteri.Show();
        }

        private void ekleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form4 stok = new Form4();
            stok.MdiParent = this;
            stok.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult cevap = 
            MessageBox.Show
            ("Uygulamadan Çıkmak İstiyor Musunuz ?","Uygulama",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                Application.Exit();
            }
            

        }

        private void Anasayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult cevap =
            MessageBox.Show
            ("Uygulamadan Çıkmak İstiyor Musunuz ?", "Uygulama", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

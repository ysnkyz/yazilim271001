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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kul, sifre;
            kul= textBox1.Text;
            sifre= textBox2.Text;

            if (string.IsNullOrEmpty(kul))
            {
             MessageBox.Show
             ("Kullanıcı Adı Boş Geçilemez","Login Hatası",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                textBox1.Focus();
            }
            else if (string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show
                ("Şifre Boş Geçilemez", "Login Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
            }
            else
            {
                if (kul=="admin" && sifre=="123")
                {
                    Anasayfa form2 = new Anasayfa();
                    form2.Show();
                    this.Hide();    
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı Ve Şifre Hatalı", "Login Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace number_guessing_game
{
    public partial class Form1 : Form
    {
        int tahmin, sayi;
        int hak = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //ozgurcyaman
            tahmin = Convert.ToInt32(textBox1.Text);

            if (tahmin == sayi) 
            {
                MessageBox.Show("Tebrikler " + hak.ToString() + ". hakkınız varken bildiniz");
                hak = 10;
                label1.Text = "0";
                label5.Text = "1000";
                label6.Text = "Kalan hak: 10";
                textBox1.Text = "";

            }

            else if (tahmin < sayi) 
            {
                hak--;
                label1.Text = tahmin.ToString();
                label6.Text = "Kalan hak: " + hak.ToString();
                textBox1.Focus();
                textBox1.Text = "";

            }
            else if (tahmin > sayi)
            {
                hak--;
                label5.Text = tahmin.ToString();
                label6.Text = "Kalan hak: " + hak.ToString();
                textBox1.Focus();
                textBox1.Text="";

            }
            if (hak<=0)
            {
                MessageBox.Show("Tüm haklarınız bitti kaybettiniz, doğru sayi: " + sayi.ToString());


            }
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hak = 10;
            label1.Text = "0";
            label5.Text = "1000";
            label6.Text = "Kalan hak: 10";
            textBox1.Focus();
            textBox1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            sayi = rastgele.Next(1001);
            label6.Text = "Kalan hak: " + hak.ToString();
            label3.Text = sayi.ToString();
           

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            operasiHitung.Items.Add("Penambahan");
            operasiHitung.Items.Add("Pengurangan");
            operasiHitung.Items.Add("Perkalian");
            operasiHitung.Items.Add("Pembagian");
            operasiHitung.SelectedItem = ("Penambahan");
        }

        static int Penambahan(int a, int b)
        {
            return a+b;

        }

        static int Pengurangan(int a, int b)
        {
            return a - b;

        }
        static int Perkalian(int a, int b)
        {
            return a * b;

        }
        static int Pembagian(int a, int b)
        {
            return a / b;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonhitung_Click(object sender, EventArgs e)
        {
            var a = Convert.ToInt32(textBox3.Text);
            var b = Convert.ToInt32(textBox2.Text);
            string ambilOperasi = Operasi.Text;

            if (ambilOperasi == "Penambahan")
            {
                textBox1.Text = Convert.ToString(Penambahan(a, b));
            }
            else if (ambilOperasi == "Pengurangan")
            {
                textBox1.Text = Convert.ToString(Pengurangan(a, b));
            }
            else if (ambilOperasi == "Perkalian")
            {

                textBox1.Text = Convert.ToString(Perkalian(a, b));
            }
            else (ambilOperasi == "Pembagian")
            {
                textBox1.Text = Convert.ToString(Pembagian(a, b));
            }
        }

            private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

       private void Hasil_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

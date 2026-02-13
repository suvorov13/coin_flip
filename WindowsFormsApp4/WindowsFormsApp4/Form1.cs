using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection.Emit;


namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        private int orzel = 0;
        private int reszka  = 0;
        private Random rng = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool wynik = rng.Next(2) == 0;
            if (wynik)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\student\\source\\repos\\WindowsFormsApp4\\WindowsFormsApp4\\img\\orzel.png");
                orzel++;
                label1.Text = "Orzel";
            }else
            {
                reszka++;
                label1.Text = "Reszka";
                pictureBox1.Image = Image.FromFile("C:\\Users\\student\\source\\repos\\WindowsFormsApp4\\WindowsFormsApp4\\img\\reszka.png");
            }
            label2.Text = $"Suma: {orzel + reszka} | Orzel: {orzel} | Reszka: {reszka}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            orzel = 0;
            reszka = 0;
            label1.Text = "-";
            label2.Text = "Suma: 0 | Orzel: 0 | Rzeszka: 0";
            pictureBox1.Image = Image.FromFile("C:\\Users\\student\\source\\repos\\WindowsFormsApp4\\WindowsFormsApp4\\img\\rzut.png");
        }
    }
}

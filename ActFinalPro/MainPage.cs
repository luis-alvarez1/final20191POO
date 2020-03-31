using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActFinalPro
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            MainGlases pasar = new MainGlases();
            pasar.Show();

            //Al presionar la imagen o carrito, se pasa al siguiente formulario
        }

        private void btn_shoes_Click(object sender, EventArgs e)
        {
            MainShoes pasar = new MainShoes();
            pasar.Show();

            //Al presionar la imagen o carrito, se pasa al siguiente formulario
        }

        private void btn_earphones_Click(object sender, EventArgs e)
        {
            MainAirPodsII pasar = new MainAirPodsII();
            pasar.Show();

            //Al presionar la imagen o carrito, se pasa al siguiente formulario
        }

        private void btn_glasses_MouseHover(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pct_shoes_Click(object sender, EventArgs e)
        {
            MainShoes pasar = new MainShoes();
            pasar.Show();

            //Al presionar la imagen o carrito, se pasa al siguiente formulario
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit(); 

            //Al presionar cancelar, se cierra la app
        }

        private void Pct_glasses_Click(object sender, EventArgs e)
        {
            MainGlases pasar = new MainGlases();
            pasar.Show();

            //Al presionar la imagen o carrito, se pasa al siguiente formulario
        }

        private void Pct_earphones_Click(object sender, EventArgs e)
        {
            MainAirPodsII pasar = new MainAirPodsII();
            pasar.Show();

            //Al presionar la imagen o carrito, se pasa al siguiente formulario
        }
    }
}
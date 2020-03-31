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
    public partial class MainShoes : Form
    {
        public MainShoes()
        {
            InitializeComponent();
        }

        private void MainShoes_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //La ventana se cierra para escoger otra opción
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pct_comprar_Click(object sender, EventArgs e)
        {   //Se pulsa el carrito
            if (cmb_colorShoe.Text == "Seleccione..." || cmb_talla.Text == "Seleccione...")
            //los valores deben ser diferentes al valor por defecto
            {
                //Mensaje de error sencillo
                MessageBox.Show("Rellene todas las especificaciones para continuar.");
            }
            else
            {
                //se muestra el siguiente formulario de recoleccion de datos para el cliente
                Details_Client v = new Details_Client();
                v.Show();
                this.Close();
            }
        }

        private void Vtn_brendita_Click(object sender, EventArgs e)
        {

            MessageBox.Show("<3");
        }
    }
}

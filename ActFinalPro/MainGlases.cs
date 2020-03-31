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
    
    public partial class MainGlases : Form
    {

        public MainGlases()
        {
            InitializeComponent();
        }

        private void MainGlases_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //La ventana se cierra para escoger otra opción
            this.Close();
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Pct_comprar_Click(object sender, EventArgs e)
        //Se pulsa el carrito
        {
            if (cmb_colorPol.Text == "Seleccione..." || cmb_diseno.Text == "Seleccione...")
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

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


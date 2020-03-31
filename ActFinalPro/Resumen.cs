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
    public partial class Resumen : Form
    {
        //Se pasan por parametros los campos a mostrar
        public Resumen(string nombre, string metodo_pago, string num_tarjeta, string direccion,
            string correo, string numero_cel)
        {
            InitializeComponent();

            //Se asigana el valor de los campos
            r_nombre.Text = nombre;
            r_metodoPago.Text = metodo_pago;
            r_numTarjeta.Text = num_tarjeta;
            r_adress.Text = direccion;
            r_correo.Text = correo;
            r_celular.Text = numero_cel;
        }

        private void Resumen_Load(object sender, EventArgs e)
        {

        }

        private void Pct_comprar_Click(object sender, EventArgs e)
        {
            //Mensaje de despedida :D
            MessageBox.Show("¡GRACIAS POR SU COMPRA! \nSe le estará notificando del estado de las misma.");

            Application.Exit(); //La aplicación se cierra
        }

        private void Txt_tlfCel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
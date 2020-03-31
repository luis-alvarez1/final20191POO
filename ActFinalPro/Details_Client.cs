using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActFinalPro

{
    public partial class Details_Client : Form
    {

        // se crea el objeto para emplear los metodos soloLetras() y soloNumeros()
        Solo_Numeros_Letras v = new Solo_Numeros_Letras();

        public Details_Client()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //La ventana se cierra para escoger otra opción
            this.Close();
        }

        private void pct_comprar_Click(object sender, EventArgs e)
        {//Se presiona el carrito

            if (validarCorreo() == false) //validamos el correo
            {
                //uso de excepcion personalizada
                throw new Exception_Correo("Correo no valido");

            }
            
            //validamos el número de caracteres de la tarjeta
            //No puede ser mayor o menor a 16
            else if (txt_numTarjeta.Text.Length < 16 || txt_numTarjeta.Text.Length > 16)
            {
                //uso de excepcion personalizada
                throw new Exception_Credit_Card("El número de caracteres no es valido");
            }
            else if (txt_celular.Text.Length != 10)
            {
                MessageBox.Show("Número de Celular no valido");
            }
            else //Si todo está con su debido formato
            {
                //Validar que todos los campos estén llenados
                if (txt_nombre.Text == null || txt_numTarjeta.Text == null ||
                    cmb_pago.Text == "Seleccione..." || txt_adress.Text == null || txt_correo.Text == null)
                {
                    //Breve mensaje de error
                    MessageBox.Show("Introduzca todos los datos para poder continuar con la compra");
                }
                else//Todo está correcto
                {
                    //Se genera un nuevo formulario de muestreo de datos
                    Resumen v = new Resumen(txt_nombre.Text, cmb_pago.Text, txt_numTarjeta.Text,
                    txt_adress.Text, txt_correo.Text, txt_celular.Text);
                    v.Show();
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Details_Client_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public bool validarCorreo() //Método para validar correo  electrónico
        {
            try
            {
                //el parametro es el TextBox a validar
                new MailAddress(txt_correo.Text);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetras(e); //solo se permiten letras en el apartado del nombre
        }

        private void Txt_numTargeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e); //solo se permiten números en el aprtado de tarjeta
        }
    }
}
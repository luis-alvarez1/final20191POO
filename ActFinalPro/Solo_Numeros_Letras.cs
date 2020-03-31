using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActFinalPro
{
    class Solo_Numeros_Letras
    {
        public void soloLetras(KeyPressEventArgs e)
        {
            //el valor e.Handled = false significa que la tecla estará permitida de digitar
            try
            {
                if (char.IsLetter(e.KeyChar)) //Si es una letra
                {
                    e.Handled = false; 

                }else if(char.IsControl(e.KeyChar)) 
                {

                    e.Handled = false;

                }else if (char.IsSeparator(e.KeyChar)) //Si es un separador (espacio/tabulación)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true; //no se permiten números
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Algo falló en la ejecución del programa.");
            }
        }

        public void soloNumeros(KeyPressEventArgs e)
        {

            try
            {
                if (char.IsNumber(e.KeyChar)) //Si es un número
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar)) //Si es una tecla de control (borrar/suprimir)
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))//Si es un separador (espacio/tabulación)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true; //No se permiten letras
                }
            }
            catch (Exception ex) //try/catch de orevención para posibles errores en el programa
            {
                MessageBox.Show("Algo falló en la ejecución del programa.");
            }

        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActFinalPro
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainPage());

            }
            //Se controlan las excepciones personalizadas
            catch (Exception_Correo e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception_Credit_Card e)
            {
                MessageBox.Show(e.Message);
            }
            catch (FormatException)
            {
                MessageBox.Show("Introduzca todos los datos para poder continuar con la compra");
            }
        }
    }
}

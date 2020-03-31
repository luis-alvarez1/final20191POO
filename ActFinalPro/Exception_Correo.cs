using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActFinalPro
{
    class Exception_Correo: Exception
    {//Excepción para validar el correo introducido y verificar que cumpla con el formato
        public Exception_Correo(String message):base(message)
        {
        }
    }
}

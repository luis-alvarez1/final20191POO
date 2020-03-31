using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActFinalPro
{
    public class Exception_Credit_Card : Exception
    {//Excepción para verificar los digitos introducidos de la targeta de debito/credito
        public Exception_Credit_Card(string message):base(message)
        {
        }
    }
}
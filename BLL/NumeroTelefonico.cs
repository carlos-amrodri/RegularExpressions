using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NumeroTelefonico : AbstractMyRegex
    {
        public NumeroTelefonico(string texto) : base(texto) {}


        protected override string getPatern()
        {
            return @"\A[0-9]{3} [0-9]{3} [0-9]{3}\Z";
        }

        protected override string errorMessage()
        {
            return "Ops! no es un teléfono";
        }

        protected override string succesMessage()
        {
            return "Exito!! parece un teléfono válido";
        }
    }
}

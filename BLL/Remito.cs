using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Remito : AbstractMyRegex
    {
        public Remito(string texto) : base(texto) {}

        protected override string errorMessage()
        {
            return "Ops! no es un remito válido";
        }

        protected override string getPatern()
        {
            return @"\A[AB]([0-9]{9})\Z";
        }

        protected override string succesMessage()
        {
            return "Excelente!! es un remito válido";
        }
    }
}

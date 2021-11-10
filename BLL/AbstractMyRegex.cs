using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace BLL
{
    public abstract class AbstractMyRegex
    {
        protected string textoAnalizado;

        public AbstractMyRegex( string texto) {
            textoAnalizado = texto;
        }

        protected abstract string errorMessage();
        protected abstract string succesMessage();
        protected abstract string getPatern();

        protected virtual bool isMatch() {
            string patern = getPatern();
            Regex regex = new Regex(patern);
            return regex.IsMatch(textoAnalizado);
        }

        public virtual string validarCadena()
        {
            string respuesta = isMatch() ? succesMessage() : errorMessage();
            return respuesta;
        }
    }
}

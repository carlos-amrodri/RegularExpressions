using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace BLL
{
    public class Subcadenas
    {
        private string texto;
        private string pattern;

        public Subcadenas(string texto, string pattern) {
            this.texto = @""+texto;
            this.pattern = pattern;
        }

        public List<string> getCoincidencias()
        {
            List<string> lista = new List<string>();
            Regex regex = new Regex(pattern);
            MatchCollection collection = regex.Matches(texto);
            foreach(Match m in collection)
            {
                lista.Add(m.ToString());
            }
            return lista;
        }
    }
}

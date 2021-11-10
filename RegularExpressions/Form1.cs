using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace RegularExpressions
{
    public partial class Form1 : Form
    {

        AbstractMyRegex regex;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTE_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
            regex = new NumeroTelefonico(texto);
            validar();
        }


        private void btnRemito_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
            regex = new Remito(texto);
            validar();
        }



        private void validar() {
            string resultado = regex.validarCadena();
            MessageBox.Show(resultado);
        }

        private void btnSubcadenas_Click(object sender, EventArgs e)
        {
            Subcadenas subcadenas = new Subcadenas(textSubcadena.Text, textPatternSubcadena.Text);
            List<string> resultado = subcadenas.getCoincidencias();
            listBoxSubcadena.DataSource = resultado;
        }
    }
}

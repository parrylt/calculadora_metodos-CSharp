using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_metodos
{
    public partial class btMult : Form
    {

        public btMult()
        {
            InitializeComponent();
        }

        Calculadora_POO calc = new Calculadora_POO();
        double valor1, valor2;

        private void entradaDados()
        {
            valor1 = Convert.ToDouble(tb1valor.Text);
            valor2 = Convert.ToDouble(tb2valor.Text);
        }

        private void btnMultiplica_Click(object sender, EventArgs e)
        {
            entradaDados();
            lblResultado.Text = calc.Multiplicar(valor1, valor2).ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            entradaDados();
            lblResultado.Text = calc.Subtracao(valor1, valor2).ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            entradaDados();
            lblResultado.Text = calc.Divisao(valor1, valor2).ToString();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            entradaDados();
            lblResultado.Text = calc.Somar(valor1, valor2).ToString();
        }
    }
}

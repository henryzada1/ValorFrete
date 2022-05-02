using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValorFrete.view
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void Calcular()
        {
            decimal valor = 0;
            decimal frete = 0;

            valor = Convert.ToDecimal(tbValor.Text);

            switch (cboUF1.Text.ToUpper())
            {
                case "AM":
                    frete = 0.6m;
                    break;
                case "MG":
                    frete = 0.35m;
                    break;
                case "RJ":
                    frete = 0.30m;
                    break;
                case "SP":
                    frete = 0.20m;
                    break;
                default:
                    frete = 0.70m;
                    break;
            }

            tbPorcFrete.Text = frete.ToString();
            lblValorFrete.Text = (valor * (1 + frete)).ToString();
        }

        private void LimparTela()
        {
            tbCliente.Text = string.Empty;
            tbValor.Text = string.Empty;
            cboUF1.SelectedIndex = -1;
            tbPorcFrete.Text = string.Empty;
            lblValorFrete.Text = string.Empty;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calcular();
           
        }
    }
}

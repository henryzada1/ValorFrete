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

        decimal frete = 0;

        private void CalcularFrete()
        { 
            switch (cboUF1.Text.ToUpper())
            {
                case "ESCOLHA UF":
                    frete = 0;   
                    break;

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

            tbPorcFrete.Text = frete.ToString("P0");  
            
        }
            
        private void LimparTela()   
        {
            tbCliente.Text = string.Empty;
            tbValor.Text = string.Empty;
            cboUF1.SelectedIndex = 0;
            tbPorcFrete.Text = string.Empty;
            lblValorFrete.Text = string.Empty;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal valor = 0;

            if(tbValor.Text == "")
            {
                MessageBox.Show("O valor está em branco.");
            }
            else 
            { 
                valor = Convert.ToDecimal(tbValor.Text);
                lblValorFrete.Text = (valor * (frete + 1)).ToString("c2");
            }


        }

        private void cboUF1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularFrete();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            cboUF1.SelectedIndex = 0;
        }

        private void TelaPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 27)
            {
                LimparTela();
            }
        }
    }
}

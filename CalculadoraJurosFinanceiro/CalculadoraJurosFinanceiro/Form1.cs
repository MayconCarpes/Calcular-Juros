using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraJurosFinanceiro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //P= (L*i) / (1−(1+i)^−n)
        /*valorDaParcela = principal * (taxaDeJurosMensal 
         * / (1 - Math.Pow(1 + taxaDeJurosMensal, -numeroDeParcelas)));*/
        private void label4_Click(object sender, EventArgs e)
        {
            

        }
     /*   
    Onde:P é o valor da parcela mensal (valorDaParcela).      
    L é o valor principal do empréstimo (principal).       
    i é a taxa de juros mensal (taxaDeJurosMensal).
    Pegue a taxa anual e divida por 12.       
    n é o número total de parcelas (numeroDeParcelas).*/

        //debug em cima da linha no atalho f9
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double taxaAnual = Convert.ToDouble(txttaxaDeJurosMensal.Text);
            double principal = Convert.ToDouble(txtPrincipal.Text);
            double numeroParcela = Convert.ToDouble(txtnumeroDeParcelas.Text);

            double taxaDeJurosMensal = (taxaAnual / 100) / 12;
            
            //                                P= (L*i)              /          (1−(1+i)^−n)
            double valorDaParcela = principal * (taxaDeJurosMensal / (1 - Math.Pow(1 + taxaDeJurosMensal, -numeroParcela) ));
            double TotalDeJuros = numeroParcela * valorDaParcela;
            double valorTotal = TotalDeJuros - principal;

            lblResultado.Text = "Valor da Parcela: " + valorDaParcela.ToString("N2");
            lblJuros.Text = "Total em juros: " + TotalDeJuros.ToString("N2");
            lblPago.Text = "Total Pago: " + valorTotal.ToString("N2");

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void lblJuros_Click(object sender, EventArgs e)
        {

        }

        private void lblPago_Click(object sender, EventArgs e)
        {

        }
    }
}

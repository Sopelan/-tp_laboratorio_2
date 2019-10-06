using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        bool flag = false;
        public FormCalculadora()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.Text = "Calculadora de sopelana marcos del curso 2B";
            this.cmbOperador.Items.Add("+");
            this.cmbOperador.Items.Add("-");
            this.cmbOperador.Items.Add("*");
            this.cmbOperador.Items.Add("/");
            this.cmbOperador.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnCerra_CLick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNumero1.Clear();
            this.txtNumero2.Clear();
            this.lblResultado.Text = "";
        }
        private static double Operar(string numero1 , string numero2, string operador)
        {
            Numero n1 = new Numero(numero1);
            Numero n2 = new Numero(numero2);
            double retorno = Calculadora.Operar(n1, n2, operador);
            return retorno;
        }

        private void btnOpera_Click(object sender, EventArgs e)
        {
            double numero = Operar(txtNumero1.Text, txtNumero2.Text , cmbOperador.Text);
            this.lblResultado.Text = Convert.ToString(numero);
        }

        private void btnConvertirABinario(object sender, EventArgs e)
        {
            if(flag == false)
            {
                Numero n1 = new Numero(lblResultado.Text);
                lblResultado.Text = n1.DecimalBinario(lblResultado.Text);
                flag = true;
            }
            
        }

        private void btnConvertirADecimal(object sender, EventArgs e)
        {
            if(flag == true)
            {
                Numero n1 = new Numero(lblResultado.Text);
                lblResultado.Text = n1.BinarioDecimal(lblResultado.Text);
                flag = false;
            }
            
        }
    }
}

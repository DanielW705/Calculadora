using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_V2
{
    public partial class CalculadoraV2 : Form
    {
        #region Atributos
        private string Num1 = string.Empty, Num2 = string.Empty , simbolo=string.Empty, operador=string.Empty, simbolonum2=string.Empty;
        private int i = 1, j = 1, k = 1;
        Operaciones objet1= new Operaciones(); 
        #endregion
        #region constructor
        public CalculadoraV2()
        {
            InitializeComponent();
        }
        #endregion
        #region Metodos
        private void seleccion(string operador)
        {
            Num1 = simbolo + Num1;
            Num2 = simbolonum2 + Num2;
            if (operador == "+")
            {
                txtResultado.Text = objet1.Suma(Num1,Num2);
                Num1 = txtResultado.Text;
                Num2 = string.Empty;
                simbolo = string.Empty;
                simbolonum2 = string.Empty;
                operador = string.Empty;

            }
            if (operador == "-")
            {
                txtResultado.Text = objet1.Resta(Num1, Num2);
                Num1 = txtResultado.Text;
                Num2 = string.Empty;
                simbolo = string.Empty;
                simbolonum2 = string.Empty;
                operador = string.Empty;
            }
            if (operador == "*")
            {
                txtResultado.Text = objet1.Multiplicacion(Num1, Num2);
                Num1 = txtResultado.Text;
                Num2 = string.Empty;
                simbolo = string.Empty;
                simbolonum2 = string.Empty;
                operador = string.Empty;
            }
            if (operador == "/")
            {
                txtResultado.Text = objet1.Division(Num1, Num2);
                Num1 = txtResultado.Text;
                Num2 = string.Empty;
                simbolo = string.Empty;
                simbolonum2 = string.Empty;
                operador = string.Empty;
            }
            if (operador == "%")
            {
                txtResultado.Text = objet1.Modulo(Num1, Num2);
                Num1 = txtResultado.Text;
                Num2 = string.Empty;
                simbolo = string.Empty;
                simbolonum2 = string.Empty;
                operador = string.Empty;
            }
        }
        #endregion
        #region eventos
        private void Button1_Click(object sender, EventArgs e)
        {
            if(operador == string.Empty)
            {
                Num1 = Num1 + "1";
                txtResultado.Text = simbolo + " " + Num1;
            }
            else
            {
                Num2 = Num2 + "1";
                txtResultado.Text = simbolo + " " + Num1 + " " + operador + " " + simbolonum2 + " " + Num2;
            }


        }
        private void Button2_Click(object sender, EventArgs e)
        {
            if(operador == string.Empty)
            {
                Num1 = Num1 + "2";
                txtResultado.Text = simbolo + " " + Num1;
            }
            else 
            {
                Num2 = Num2 + "2";
                txtResultado.Text = simbolo + " " + Num1 + " " + operador + " " + simbolonum2 + " " + Num2;
            }
            
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            if(operador == string.Empty)
            { 
            Num1 = Num1 + "3";
            txtResultado.Text = simbolo + " " + Num1;
             }
            else
            {
                Num2 = Num2 + "3";
                txtResultado.Text = simbolo + " " + Num1 + " " + operador + " " + simbolonum2 + " " + Num2;
            }
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            if (operador == string.Empty)
            {
                Num1 = Num1 + "4";
                txtResultado.Text = simbolo + " " + Num1;
            }
            else
            {
                Num2 = Num2 + "4";
                txtResultado.Text = simbolo + " " + Num1 + " " + operador + " " + simbolonum2 + " " + Num2;
            }
        }
        private void Button5_Click(object sender, EventArgs e)
        {

            if (operador == string.Empty)
            {
                Num1 = Num1 + "5";
                txtResultado.Text = simbolo+ " " + Num1;
            }
            else
            {
                Num2 = Num2 + "5";
                txtResultado.Text = simbolo + " " + Num1 + " " + operador + " " + simbolonum2 + " " + Num2;
            }
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            if (operador == string.Empty)
            {
                Num1 = Num1 + "6";
                txtResultado.Text = simbolo + " " + Num1;
            }
            else
            {
                Num2 = Num2 + "6";
                txtResultado.Text = simbolo + " " + Num1 + " " + operador + " " + simbolonum2 + " " + Num2;
            }
        }
        private void Button7_Click(object sender, EventArgs e)
        {
            if (operador == string.Empty)
            {
                Num1 = Num1 + "7";
                txtResultado.Text = simbolo + " " + Num1;
            }
            else
            {
                Num2 = Num2 + "7";
                txtResultado.Text = simbolo + " " + Num1 + " " + operador + " " + simbolonum2 + " " + Num2;
            }
        }
        private void Button8_Click(object sender, EventArgs e)
        {
            if (operador == string.Empty)
            {
                Num1 = Num1 + "8";
                txtResultado.Text = simbolo + " " + Num1;
            }
            else
            {
                Num2 = Num2 + "8";
                txtResultado.Text = simbolo + " " + Num1 + " " + operador + " " + simbolonum2 + " " + Num2;
            }
        }
        private void Button9_Click(object sender, EventArgs e)
        {
            if (operador == string.Empty)
            {
                Num1 = Num1 + "9";
                txtResultado.Text = simbolo + " " + Num1;
            }
            else
            {
                Num2 = Num2 + "9";
                txtResultado.Text = simbolo + " " + Num1 + " " + operador + " " + simbolonum2 + " " + Num2;
            }
        }
        private void Button0_Click(object sender, EventArgs e)
        {
            if (operador == string.Empty)
            { 
            Num1 = Num1 + "0";
            txtResultado.Text = simbolo + " " + Num1;
        }
            else
            {
                Num2 = Num2 + "0";
                txtResultado.Text = simbolo + " " + Num1 + " " + operador + " " + simbolonum2 + " " + Num2;
            }
        }
        private void Buttonpoint_Click(object sender, EventArgs e)
        {
            if (operador == string.Empty)
            {
                Num1 = Num1 + ".";
                txtResultado.Text = simbolo + " " + Num1;
            }
            else
            {
                Num2 = Num2 + ".";
                txtResultado.Text = simbolo + " " + Num1 + " " + operador + " " + simbolonum2 + " " + Num2;
            }
        }
        private void Buttoncambiosigno_Click(object sender, EventArgs e)
        {
            if (operador== string.Empty)
            {
                if (i % 2 == 0)
                {
                    simbolo = string.Empty;
                    txtResultado.Text = simbolo + " " + Num1;

                }
                if (i % 2 != 0)
                {
                    simbolo = "-";
                    txtResultado.Text = simbolo + " " + Num1;
                }
                i++;
            }
            if (operador != string.Empty)
            {
                if (j % 2 == 0)
                {
                    simbolonum2 = string.Empty;
                    txtResultado.Text = simbolo + " " + Num1 + " " + operador +" "+ simbolonum2 + " " + Num2;

                }
                if (j % 2 != 0)
                {
                    simbolonum2 = "-";
                    txtResultado.Text = simbolo + " " + Num1 + " " + operador + " " + simbolonum2 + " " + Num2;
                }
                j++;
            }
        }
        private void ButtonIgual_Click(object sender, EventArgs e)
        {
            if (Num1 == string.Empty)
            {
                Num1 = "0";
            }
            if (Num2==string.Empty)
            {
                Num2 = "0";
            }
          seleccion(operador);   
        }
        private void ButtonMul_Click(object sender, EventArgs e)
        {
            operador = "*";
            txtResultado.Text = simbolo + " " + Num1 + " " + operador;
        }
        private void ButtonSum_Click(object sender, EventArgs e)
        {
            operador = "+";
            txtResultado.Text = simbolo + " " + Num1 + " " + operador;
        }
        private void ButtonDIv_Click(object sender, EventArgs e)
        {
            operador = "/";
            txtResultado.Text = simbolo + " " + Num1 + " " + operador;
        }

        private void ButtonRes_Click(object sender, EventArgs e)
        {
            operador = "-";
            txtResultado.Text = simbolo + " " + Num1 + " " + operador;
        }

        private void ButtonMod_Click(object sender, EventArgs e)
        {
            operador = "%";
            txtResultado.Text = simbolo + " " + Num1 + " " + operador;
        }

        private void CalculadoraV2_Load(object sender, EventArgs e)
        {

        }
        private void ButtonLimp_Click(object sender, EventArgs e)
        {
            if(k%2!=0)
            {
                Num1 = string.Empty;
                simbolo = string.Empty;
                operador = string.Empty;
                txtResultado.Text = simbolo + " " + Num1;
                i = 1;
                j = 1;
            }
            if(k%2==0)
            {
                operador = string.Empty;
                Num2 = string.Empty;
                simbolonum2 = string.Empty;
                txtResultado.Text = simbolo + " " + Num1 + " " + operador + " " + simbolonum2 + " " + Num2;
                i = 1;
                j = 1;
            }
            k++;
            if(txtResultado.Text=="Math errror")
            {
                txtResultado.Text = string.Empty;
                Num1 = string.Empty;
                Num2 = string.Empty;
                simbolo = string.Empty;
                simbolonum2 = string.Empty;
                operador = string.Empty;
                i = 1;
                j = 1;
                k = 1;
            }
        }
        #endregion
    }
}

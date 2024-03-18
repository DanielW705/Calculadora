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
        private string Num1 = string.Empty, Num2 = string.Empty, simbolo = string.Empty, operador = string.Empty, simbolonum2 = string.Empty;
        private int i = 1, j = 1, k = 1;
        private double ans = 0.0, varM = 0.0;
        private bool point = false, operation = false, firsNumber = false, isAnswered = false, isResult = false;
        Operaciones objet1 = new Operaciones();
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
                ans = isAnswered ? objet1.Suma(ans.ToString(), Num1) : objet1.Suma(Num1, Num2);
                txtResultado.Text = ans.ToString();
            }
            else if (operador == "-")
            {
                ans = isAnswered ? objet1.Resta(ans.ToString(), Num1) : objet1.Resta(Num1, Num2);
                txtResultado.Text = ans.ToString();
            }
            else if (operador == "*")
            {
                ans = isAnswered ? objet1.Multiplicacion(ans.ToString(), Num1) : objet1.Multiplicacion(Num1, Num2);
                txtResultado.Text = ans.ToString();
            }
            else if (operador == "/")
            {
                if (isAnswered)
                {
                    if (!objet1.Division(ans.ToString(), Num1, out ans))
                        txtResultado.Text = "Math error";
                    else
                        txtResultado.Text = ans.ToString();
                }
                else
                {
                    if (!objet1.Division(Num1, Num2, out ans))
                        txtResultado.Text = "Math error";
                    else
                        txtResultado.Text = ans.ToString();
                }
            }
            else
            {
                ans = isAnswered ? objet1.Modulo(ans.ToString(), Num1) : objet1.Modulo(Num1, Num2);
                txtResultado.Text = ans.ToString();
            }
            Num1 = string.Empty;
            Num2 = string.Empty;
            simbolo = string.Empty;
            simbolonum2 = string.Empty;
            operador = string.Empty;
        }
        #endregion
        #region eventos
        private void Button1_Click(object sender, EventArgs e)
        {
            if (operador == string.Empty || isAnswered)
            {
                firsNumber = true;
                Num1 = Num1 + "1";
                if (!firsNumber || isAnswered)
                    txtResultado.Text = $"Ans {operador} {simbolo} {Num1}";
                else
                {
                    txtResultado.Text = simbolo + " " + Num1;
                }
            }
            else
            {
                Num2 = Num2 + "1";
                txtResultado.Text = simbolo + " " + Num1 + " " + operador + " " + simbolonum2 + " " + Num2;
            }
            operation = false;

        }
        private void Button2_Click(object sender, EventArgs e)
        {
            if (operador == string.Empty || isAnswered)
            {
                firsNumber = true;
                Num1 = Num1 + "2";
                if (!firsNumber || isAnswered)
                    txtResultado.Text = $"Ans {operador} {simbolo} {Num1}";
                else
                {
                    txtResultado.Text = simbolo + " " + Num1;
                }
            }
            else
            {
                Num2 = Num2 + "2";
                txtResultado.Text = simbolo + " " + Num1 + " " + operador + " " + simbolonum2 + " " + Num2;
            }
            operation = false;
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            if (operador == string.Empty || isAnswered)
            {
                firsNumber = true;
                Num1 = Num1 + "3";
                if (!firsNumber || isAnswered)
                    txtResultado.Text = $"Ans {operador} {simbolo} {Num1}";
                else
                {
                    txtResultado.Text = simbolo + " " + Num1;
                }
            }
            else
            {
                Num2 = Num2 + "3";
                txtResultado.Text = simbolo + " " + Num1 + " " + operador + " " + simbolonum2 + " " + Num2;
            }
            operation = false;
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            if (operador == string.Empty || isAnswered)
            {
                firsNumber = true;
                Num1 = Num1 + "4";
                if (!firsNumber || isAnswered)
                    txtResultado.Text = $"Ans {operador} {simbolo} {Num1}";
                else
                {
                    txtResultado.Text = simbolo + " " + Num1;
                }
            }
            else
            {
                Num2 = Num2 + "4";
                txtResultado.Text = simbolo + " " + Num1 + " " + operador + " " + simbolonum2 + " " + Num2;
            }
            operation = false;
        }
        private void Button5_Click(object sender, EventArgs e)
        {

            if (operador == string.Empty || isAnswered)
            {
                firsNumber = true;
                Num1 = Num1 + "5";
                if (!firsNumber || isAnswered)
                    txtResultado.Text = $"Ans {operador} {simbolo} {Num1}";
                else
                {
                    txtResultado.Text = simbolo + " " + Num1;
                }
            }
            else
            {
                Num2 = Num2 + "5";
                txtResultado.Text = simbolo + " " + Num1 + " " + operador + " " + simbolonum2 + " " + Num2;
            }
            operation = false;
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            if (operador == string.Empty || isAnswered)
            {
                firsNumber = true;
                Num1 = Num1 + "6";
                if (!firsNumber || isAnswered)
                    txtResultado.Text = $"Ans {operador} {simbolo} {Num1}";
                else
                {
                    txtResultado.Text = simbolo + " " + Num1;
                }
            }
            else
            {
                Num2 = Num2 + "6";
                txtResultado.Text = simbolo + " " + Num1 + " " + operador + " " + simbolonum2 + " " + Num2;
            }
            operation = false;
        }
        private void Button7_Click(object sender, EventArgs e)
        {
            if (operador == string.Empty)
            {
                firsNumber = true;
                Num1 = Num1 + "7";
                if (!firsNumber || isAnswered)
                    txtResultado.Text = $"Ans {operador} {simbolo} {Num1}";
                else
                {
                    txtResultado.Text = simbolo + " " + Num1;
                }
            }
            else
            {
                Num2 = Num2 + "7";
                txtResultado.Text = simbolo + " " + Num1 + " " + operador + " " + simbolonum2 + " " + Num2;
            }
            operation = false;
        }
        private void Button8_Click(object sender, EventArgs e)
        {
            if (operador == string.Empty || isAnswered)
            {
                firsNumber = true;
                Num1 = Num1 + "8";
                if (!firsNumber || isAnswered)
                    txtResultado.Text = $"Ans {operador} {simbolo} {Num1}";
                else
                {
                    txtResultado.Text = simbolo + " " + Num1;
                }
            }
            else
            {
                Num2 = Num2 + "8";
                txtResultado.Text = simbolo + " " + Num1 + " " + operador + " " + simbolonum2 + " " + Num2;
            }
            operation = false;
        }
        private void Button9_Click(object sender, EventArgs e)
        {
            if (operador == string.Empty || isAnswered)
            {
                firsNumber = true;
                Num1 = Num1 + "9";
                if (!firsNumber || isAnswered)
                    txtResultado.Text = $"Ans {operador} {simbolo} {Num1}";
                else
                {
                    txtResultado.Text = simbolo + " " + Num1;
                }
            }
            else
            {
                Num2 = Num2 + "9";
                txtResultado.Text = simbolo + " " + Num1 + " " + operador + " " + simbolonum2 + " " + Num2;
            }
            operation = false;
        }
        private void Button0_Click(object sender, EventArgs e)
        {
            if (operador == string.Empty || isAnswered)
            {
                firsNumber = true;
                Num1 = Num1 + "0";
                if (!firsNumber || isAnswered)
                    txtResultado.Text = $"Ans {operador} {simbolo} {Num1}";
                else
                {
                    txtResultado.Text = simbolo + " " + Num1;
                }
            }
            else
            {
                Num2 = Num2 + "0";
                txtResultado.Text = simbolo + " " + Num1 + " " + operador + " " + simbolonum2 + " " + Num2;
            }
            operation = false;
        }
        private void Buttonpoint_Click(object sender, EventArgs e)
        {
            if (!point)
            {
                if (operador == string.Empty)
                {
                    Num1 = Num1 + ".";
                    txtResultado.Text = simbolo + " " + Num1;
                    point = true;
                }
                else
                {
                    Num2 = Num2 + ".";
                    txtResultado.Text = simbolo + " " + Num1 + " " + operador + " " + simbolonum2 + " " + Num2;
                    point = true;
                }
            }
        }

        private void btnMres_Click(object sender, EventArgs e)
        {
            txtResultado.Text = varM.ToString();
        }

        private void MClean_Click(object sender, EventArgs e)
        {
            varM = 0;
            txtResultado.Text = string.Empty;

        }

        private void btnMmenos_Click(object sender, EventArgs e)
        {
            if (isResult || isAnswered)
                varM -= ans;
            else if(!firsNumber)
                varM -= double.Parse(txtResultado.Text);
        }

        private void bntMmas_Click(object sender, EventArgs e)
        {
            if (isResult || isAnswered)
                varM += ans;
            else if(!firsNumber)
                varM += double.Parse(txtResultado.Text);
        }

        private void Buttoncambiosigno_Click(object sender, EventArgs e)
        {
            if (operador == string.Empty)
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
                    txtResultado.Text = simbolo + " " + Num1 + " " + operador + " " + simbolonum2 + " " + Num2;

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
            if (Num2 == string.Empty)
            {
                Num2 = "0";
            }
            txtResultado.Text = string.Empty;
            point = false;
            operation = false;
            firsNumber = false;
            isResult = true;
            seleccion(operador);
        }
        private void ButtonMul_Click(object sender, EventArgs e)
        {
            if (!operation)
            {
                operador = "*";
                if (!firsNumber)
                {

                    txtResultado.Text = $"Ans {operador} {simbolo} {Num1}";
                    isAnswered = true;
                }
                else
                    txtResultado.Text = simbolo + " " + Num1 + " " + operador;
                point = false;
                operation = true;
                isResult = false;
            }
        }
        private void ButtonSum_Click(object sender, EventArgs e)
        {
            if (!operation)
            {
                operador = "+";
                if (!firsNumber)
                {

                    txtResultado.Text = $"Ans {operador} {simbolo} {Num1}";
                    isAnswered = true;
                }
                else
                    txtResultado.Text = simbolo + " " + Num1 + " " + operador;
                point = false;
                operation = true;
                isResult = false;
            }
        }
        private void ButtonDIv_Click(object sender, EventArgs e)
        {
            if (!operation)
            {
                operador = "/";
                if (!firsNumber)
                {

                    txtResultado.Text = $"Ans {operador} {simbolo} {Num1}";
                    isAnswered = true;
                }
                else
                    txtResultado.Text = simbolo + " " + Num1 + " " + operador;
                point = false;
                operation = true;
                isResult = false;
            }
        }

        private void ButtonRes_Click(object sender, EventArgs e)
        {
            if (!operation)
            {
                operador = "-";
                if (!firsNumber)
                {

                    txtResultado.Text = $"Ans {operador} {simbolo} {Num1}";
                    isAnswered = true;
                }
                else
                    txtResultado.Text = simbolo + " " + Num1 + " " + operador;
                point = false;
                operation = true;
                isResult = false;
            }
        }

        private void ButtonMod_Click(object sender, EventArgs e)
        {
            if (!operation)
            {
                operador = "%";
                if (!firsNumber)
                {

                    txtResultado.Text = $"Ans {operador} {simbolo} {Num1}";
                    isAnswered = true;
                }
                else
                    txtResultado.Text = simbolo + " " + Num1 + " " + operador;
                point = false;
                operation = true;
                isResult = false;
            }
        }

        private void CalculadoraV2_Load(object sender, EventArgs e)
        {

        }
        private void ButtonLimp_Click(object sender, EventArgs e)
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
            point = false;
            operation = false;
            firsNumber = false;
            isAnswered = false;
        }
        #endregion
    }
}

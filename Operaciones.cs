using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_V2
{
    class Operaciones
    {
        #region Atributos
        private double resultado = 0;
        #endregion
        #region Constructor
        public Operaciones()
        { }
        #endregion
        #region Metodos
        public double Suma(string num1, string num2)
        {
            resultado = double.Parse(num1) + double.Parse(num2);
            return resultado;
        }
        public double Resta(string num1, string num2)
        {
            resultado = double.Parse(num1) - double.Parse(num2);
            return resultado;
        }
        public double Multiplicacion(string num1, string num2)
        {
            resultado = double.Parse(num1) * double.Parse(num2);
            return resultado;
        }
        public bool Division(string num1, string num2, out double res)
        {
            if (num2 == "0" || num2 == "-0")
            {
                res = 0;
                return false;
            }
            else
            {
                resultado = double.Parse(num1) / double.Parse(num2);
                res = resultado;
                return true;
            }
        }
        public double Modulo(string num1, string num2)
        {
            resultado = double.Parse(num1) % double.Parse(num2);
            return resultado;
        }
        #endregion
        #region Eventos
        #endregion
    }
}

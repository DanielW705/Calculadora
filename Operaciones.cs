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
        private double resultado = 0 ;
        #endregion
        #region Constructor
        public Operaciones()
        { }
        #endregion
        #region Metodos
        public string Suma(string num1, string num2)
        {
            resultado = double.Parse(num1) + double.Parse(num2);
            return Convert.ToString(resultado);
        }
        public string Resta(string num1, string num2)
        {
            resultado = double.Parse(num1) - double.Parse(num2);
            return Convert.ToString(resultado);
        }
        public string Multiplicacion(string num1, string num2)
        {
            resultado = double.Parse(num1) * double.Parse(num2);
            return Convert.ToString(resultado);
        }
        public string Division(string num1, string num2)
        {
            if (num1 != "0" && num2 == "0" || num1 != "0" && num2=="-0") 
            {
                return ("Math error");
            }
            else
            {
                resultado = double.Parse(num1) / double.Parse(num2);
                return Convert.ToString(resultado);
            }
        }
        public string Modulo(string num1, string num2)
        {
            resultado = double.Parse(num1) % double.Parse(num2);
            return Convert.ToString(resultado);
        }
        #endregion
        #region Eventos
        #endregion
    }
}

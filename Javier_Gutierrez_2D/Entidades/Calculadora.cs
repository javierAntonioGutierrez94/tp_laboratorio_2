using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    static public class Calculadora
    {
        #region Metodos
        /// <summary>
        /// Realiza una operacion entre dos objetos en funcion de la operacion elegida.
        /// </summary>
        /// <param name="num1">Primer dato Numero</param>
        /// <param name="num2">Segundo dato Numero</param>
        /// <param name="operador">Operacion a realizar</param>
        /// <returns>Retornara el resultado de la operacion.</returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double retorno = 0;
            switch (ValidarOperador(operador))
            {
                case "+":
                    retorno = (num1 + num2);
                    break;
                case "-":
                    retorno = (num1 - num2);
                    break;
                case "/":
                    retorno = (num1 / num2);
                    break;
                case "*":
                    retorno = (num1 * num2);
                    break;
                default:
                    break;
            }
            return retorno;
        }

        /// <summary>
        /// Metodo para validar el operador ingresado.
        /// </summary>
        /// <param name="operador">Operador a validar</param>
        /// <returns> Retorna el operador ingresado originalmente si la validacion es correcta. Sino retornara Suma. </returns>
        private static string ValidarOperador(string operador)
        {
            if (operador == "+" || operador == "-" || operador == "/" || operador == "*")
            {
                return operador;
            }
            else
            {
                return "+";
            }
        }

        #endregion
    }
}

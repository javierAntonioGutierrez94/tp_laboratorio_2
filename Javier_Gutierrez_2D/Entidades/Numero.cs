using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        #region Atributos
        private double numero;
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad para poder setea un numero valido
        /// </summary>
        public string SetNumero 
        {
            set 
            {
                this.numero = ValidarNumero(value);
            }
        }
        #endregion

        #region Construtores
        /// <summary>
        /// Constructor por defecto que asigna cero al atributo numero
        /// </summary>
        public Numero() : this(0)
        {
            
        }
        /// <summary>
        /// Constructor con parametro del tipo double para poder inicializar 
        /// </summary>
        /// <param name="numero">Parametro del tipo double asignado</param>
        public Numero(double numero) : this(numero.ToString())
        {
        }
        /// <summary>
        /// Constructor con parametro de tipo string para inicializar, usado como base para el resto
        /// </summary>
        /// <param name="strNumero">Parametro string pasado</param>
        public Numero(string strNumero)
        {
            SetNumero = strNumero;
        }

        #endregion

        #region Metodos
        /// <summary>
        /// Metodo para transformar numero binario string a decimal string
        /// </summary>
        /// <param name="binario">String numero binario</param>
        /// <returns>Devuelve el numero decimal, en caso de el string pasado sea invalido, retornara "valor invalido"</returns>
        public string BinarioDecimal(string binario)
        {
            string retorno = "Valor invalido";
            bool valido = true;
            foreach (var c in binario)
            {
                if (c != '0' && c != '1')
                    valido = false;
            }
            if (valido == true)
            {
                retorno = Convert.ToInt32(binario, 2).ToString();
            }
            return retorno;
        }

        /// <summary>
        /// Metodo para pasar de decimal a binario pasando un numero double
        /// </summary>
        /// <param name="numero">numero decimal a pasar double</param>
        /// <returns>retorna el resultado en forma de string, de ser un dato inavlido retorna "Valor invalido"</returns>
        public string DecimalBinario(double numero)
        {
            return DecimalBinario(numero.ToString());
        }

        /// <summary>
        /// Metodo para pasar de decimal a binario pasando un numero string
        /// </summary>
        /// <param name="numero">numero decimal a pasar string</param>
        /// <returns>retorna el resultado en forma de string, de ser un dato inavlido retorna "Valor invalido"</returns>
        public string DecimalBinario(string numero)
        {
            string retorno = "Valor invalido";
            decimal value;
            uint value2;
            if (Decimal.TryParse(numero, out value))
            {
                if (UInt32.TryParse(numero, out value2))
                {
                    retorno = Convert.ToString(Convert.ToInt32(numero, 10), 2);
                }
            }
            return retorno;
        }

        /// <summary>
        /// Comprobara que el valor recibido sea numerico
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns>Retornara el valor en formato double, sino retornara 0</returns>
        private double ValidarNumero(string strNumero)
        {
            double retorno;
            double.TryParse(strNumero, out retorno);
            return retorno;
        }
        #endregion

        #region Sobrecargas
        /// <summary>
        /// Sobrecarga de operador "+" a realizar con dos datos tipo Numero
        /// </summary>
        /// <param name="n1">Primer numero</param>
        /// <param name="n2">Segundo numero</param>
        /// <returns>Retorna el resultado de la operacion</returns>
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// Sobrecarga de operador "-" a realizar con dos datos tipo Numero
        /// </summary>
        /// <param name="n1">Primer numero</param>
        /// <param name="n2">Segundo numero</param>
        /// <returns>Retorna el resultado de la operacion</returns>
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Sobrecarga de operador "*" a realizar con dos datos tipo Numero
        /// </summary>
        /// <param name="n1">Primer numero</param>
        /// <param name="n2">Segundo numero</param>
        /// <returns>Retorna el resultado de la operacion</returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// Sobrecarga de operador "/" a realizar con dos datos tipo Numero
        /// </summary>
        /// <param name="n1">Primer numero</param>
        /// <param name="n2">Segundo numero</param>
        /// <returns>Retorna el resultado de la operacion</returns>
        public static double operator /(Numero n1, Numero n2)
        {
            if (n2.numero == 0)
            {
                return double.MinValue;
            }
            else
            {
                return n1.numero / n2.numero;
            }
        }
        #endregion

    }
}

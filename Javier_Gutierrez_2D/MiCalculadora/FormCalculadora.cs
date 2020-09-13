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
        public FormCalculadora()
        {
            InitializeComponent();

            this.cmbOperator.Items.Add("+");
            this.cmbOperator.Items.Add("-");
            this.cmbOperator.Items.Add("*");
            this.cmbOperator.Items.Add("/");
            btnConvABinario.Enabled = false;
            btnConvADecimal.Enabled = false;
        }

        /// <summary>
        /// Logica de el Boton para poder Cerrar de manera correcta la calculadora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Logica de el boton Convertir a binario, llama al metodo DecimalBinario de la clase Numero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvABinario_Click(object sender, EventArgs e)
        {
            Numero aBinario = new Numero();
            lblResultado.Text = aBinario.DecimalBinario(lblResultado.Text);
            btnConvABinario.Enabled = false;
            btnConvADecimal.Enabled = true;
        }
        /// <summary>
        /// Logica de el boton Convertir a Decimal, llama al metodo BinarioDecimal de la clase Numero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvADecimal_Click(object sender, EventArgs e)
        {
            Numero aDecimal = new Numero();
            lblResultado.Text = aDecimal.BinarioDecimal(lblResultado.Text);
            btnConvADecimal.Enabled = false;
            btnConvABinario.Enabled = true;
        }
        /// <summary>
        /// logica de el boton Limpiar para resetear los espacios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }
        /// <summary>
        /// Logica del boton Operar, llama al metodo statico Operar de la clase FormCalculadora y le pasa los valores
        /// ingresados en pantalla en los TextBox y ComboBox y lo devuelve en lblResultado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = (Operar(txtBoxNum1.Text, txtBoxNum2.Text, cmbOperator.Text)).ToString();
            btnConvABinario.Enabled = true;
            btnConvADecimal.Enabled = false;
        }

        /// <summary>
        /// Logica para limpiar el TextBox, ComboBox y Label de la pantalla y desactivar la conversion
        /// </summary>
        private void Limpiar()
        {
            this.txtBoxNum1.Text = "";
            this.txtBoxNum2.Text = "";
            this.lblResultado.Text = "";
            this.cmbOperator.SelectedIndex = -1;
            btnConvABinario.Enabled = false;
            btnConvADecimal.Enabled = false;
        }

        /// <summary>
        /// El metodo crea dos objetos de la clase Numero. 
        /// Pasa los datos en los texBox y el comboBox al metodo Operar de la clase Calculadora
        /// luego retorna el resultado.
        /// </summary>
        /// <param name="numero1">Numero 1 string pasado</param>
        /// <param name="numero2">Numero 2 string pasado</param>
        /// <param name="operador">Operador string pasado</param>
        /// <returns>Resultado</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);

            return Calculadora.Operar(num1, num2, operador);
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {

        }
    }
}

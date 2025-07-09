using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp // Asegúrate de que este sea el nombre de tu proyecto
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            // Limpiar los labels de resultados al inicio
            lblDepreciacionAnual.Text = "";
            basura.Text = "";
            lblValorEnLibros.Text = "";
            // Centrar el formulario al iniciar
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // 1. Obtener los valores ingresados por el usuario
            // Usamos 'decimal' para cálculos monetarios, es más preciso que 'double' o 'float'
            decimal costoOriginal;
            decimal valorResidual;
            int vidaUtilAnios;
            int anioCalculo; // Para el año específico que el usuario quiere calcular

            // Intentar convertir el texto de las cajas a números.
            // Si el usuario escribe algo que no es un número, mostraremos un error.
            if (!decimal.TryParse(txtCostoOriginal.Text, out costoOriginal))
            {
                MessageBox.Show("Por favor, ingrese un número válido para el Costo Original.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCostoOriginal.Focus();
                return; // Detiene la ejecución si hay un error
            }

            if (!decimal.TryParse(txtValorResidual.Text, out valorResidual))
            {
                MessageBox.Show("Por favor, ingrese un número válido para el Valor Residual.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValorResidual.Focus();
                return;
            }

            if (!int.TryParse(txtVidaUtil.Text, out vidaUtilAnios))
            {
                MessageBox.Show("Por favor, ingrese un número entero válido para la Vida Útil (años).", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtVidaUtil.Focus();
                return;
            }

            if (!int.TryParse(txtAnioCalculo.Text, out anioCalculo))
            {
                MessageBox.Show("Por favor, ingrese un número entero válido para el Año de Cálculo.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAnioCalculo.Focus();
                return;
            }

            // Validaciones adicionales
            if (costoOriginal < 0 || valorResidual < 0)
            {
                MessageBox.Show("El Costo Original y el Valor Residual no pueden ser negativos.", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (vidaUtilAnios <= 0)
            {
                MessageBox.Show("La Vida Útil debe ser un número mayor que cero.", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (valorResidual >= costoOriginal)
            {
                MessageBox.Show("El Valor Residual debe ser menor que el Costo Original.", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (anioCalculo <= 0)
            {
                MessageBox.Show("El Año de Cálculo debe ser un número mayor que cero.", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Realizar los cálculos (Método de Línea Recta)

            // Base de depreciación = Costo Original - Valor Residual
            decimal baseDepreciacion = costoOriginal - valorResidual;

            // Depreciación Anual = Base de Depreciación / Vida Útil
            decimal depreciacionAnual = baseDepreciacion / vidaUtilAnios;

            // Depreciación Acumulada para el año especificado
            decimal depreciacionAcumulada = depreciacionAnual * anioCalculo;

            // Asegurarse de que la depreciación acumulada no exceda la base de depreciación
            if (depreciacionAcumulada > baseDepreciacion)
            {
                depreciacionAcumulada = baseDepreciacion; // No se puede depreciar más allá de la base
            }

            // Valor en Libros = Costo Original - Depreciación Acumulada
            decimal valorEnLibros = costoOriginal - depreciacionAcumulada;

            // Asegurarse de que el valor en libros no sea menor que el valor residual
            if (valorEnLibros < valorResidual)
            {
                valorEnLibros = valorResidual; // El activo no puede valer menos que su valor residual
            }


            // 3. Mostrar los resultados en los Labels
            // Usamos .ToString("C") para formatear como moneda local (ej. $1,234.56)
            // Opcional: Puedes usar .ToString("N2") para 2 decimales sin símbolo de moneda.
            lblDepreciacionAnual.Text = depreciacionAnual.ToString("C");
            lblDepreciacionAcumulada.Text = depreciacionAcumulada.ToString("C");
            lblValorEnLibros.Text = valorEnLibros.ToString("C");

            // Opcional: Mostrar un mensaje de éxito
            // MessageBox.Show("Cálculo completado para el activo: " + txtNombreActivo.Text, "Cálculo Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtIrEmpleados_Click(object sender, EventArgs e)
        {
            FormEmpleados formEmpleados = new FormEmpleados();
            formEmpleados.ShowDialog();
        }
    }
}
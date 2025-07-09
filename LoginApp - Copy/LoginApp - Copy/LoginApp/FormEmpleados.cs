using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Windows.Forms;
using System.Collections.Generic; // Necesario para List

namespace LoginApp // Asegúrate de que este sea el nombre de tu proyecto
{
    public partial class FormEmpleados : Form
    {
        public FormEmpleados()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar el formulario
        }

        // Este método se ejecuta cuando el formulario de empleados se carga (aparece en pantalla)
        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            // Creamos una lista de nombres de empleados
            List<string> listaEmpleados = new List<string>
            {
                "Juan Pérez",
                "María García",
                "Carlos Rodríguez",
                "Ana López",
                "Pedro Martínez",
                "Sofía Sánchez",
                "Luis Fernández",
                "Elena González",
                "Miguel Ruiz",
                "Laura Díaz",
                "David Vargas",
                "Isabel Moreno",
                "Ricardo Blanco",
                "Paula Castro",
                "Diego Ramos",
                "Andrea Silva",
                "Javier Torres",
                "Marta Ortega",
                "Fernando Navarro",
                "Patricia Gil"
            };

            // Agregamos cada empleado de la lista al ListBox
            foreach (string empleado in listaEmpleados)
            {
                lstEmpleados.Items.Add(empleado);
            }
        }

       
    }
}
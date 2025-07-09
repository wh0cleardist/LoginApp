using LoginApp;
using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LoginApp
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> usuariosPermitidos = new Dictionary<string, string>()
        {
            {"admin", "12345"},
            {"usuario1", "clave1"},
            {"juan", "secreto"},
            {"maria", "mipass"},
            {"invitado", "entrada"}
        };

        public Form1()
        {
            InitializeComponent();
            lblMensaje.Text = "";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = txtUsuario.Text;
            string contrasenaIngresada = txtContrasena.Text;

            string contrasenaCorrecta;

            if (usuariosPermitidos.TryGetValue(usuarioIngresado, out contrasenaCorrecta) && contrasenaIngresada == contrasenaCorrecta)
            {
                this.Hide(); // Oculta el formulario de login

                FormPrincipal formPrincipal = new FormPrincipal();

                // ¡AÑADE ESTA LÍNEA AQUÍ!
                // Esto le dice a Form1: "Cuando FormPrincipal se cierre, entonces ciérrate tú también."
                formPrincipal.FormClosed += (s, args) => this.Close();

                formPrincipal.Show(); // Muestra el formulario principal
            }
            else
            {
                lblMensaje.Text = "Usuario o contraseña incorrectos.";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                txtUsuario.Clear();
                txtContrasena.Clear();
                txtUsuario.Focus();
            }
        }
    }
}
using AsistenteMigracionApp.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsistenteMigracionApp.Forms
{
    public partial class ConexionForm: Form
    {
        public ConexionForm()
        {
            InitializeComponent();
        }

        private void ConexionForm_Load(object sender, EventArgs e)
        {
            var datos = GestorConexionMySQL.CargarConexion();
            tbServidor.Text = datos.Server;
            tbPuerto.Text = datos.Port;
            tbUsuario.Text = datos.User;
            tbPassword.Text = datos.Password;
            tbBaseDeDatos.Text = datos.Database;
        }


        private void ConexionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Verifica si la razón del cierre es que el usuario lo está cerrando (botón X, Alt+F4, etc.)
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Muestra un cuadro de diálogo de confirmación
                DialogResult result = MessageBox.Show(
                    "Se perderán los datos sin guardar, ¿Desea salir?", // Mensaje
                    "Confirmar Cierre", // Título del cuadro de diálogo
                    MessageBoxButtons.YesNo, // Botones: Sí y No
                    MessageBoxIcon.Question); // Icono de pregunta

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void tbPuerto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo dejamos ingresar números y la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            if (ProbarConexion(tbServidor.Text, tbPuerto.Text, tbUsuario.Text, tbPassword.Text, tbBaseDeDatos.Text))
            {
                MessageBox.Show("Conexión exitosa", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool ProbarConexion(string servidor, string puerto, string usuario, string password, string baseDatos)
        {
            string cadenaConexion = $"server={servidor};port={puerto};user={usuario};password={password};database={baseDatos};SslMode=none;";

            try
            {
                using (var conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar:\n" + ex.Message, "Fallo de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnGuardarConexion_Click(object sender, EventArgs e)
        {
            GestorConexionMySQL.GuardarConexionMySQL(
                tbServidor.Text,
                tbPuerto.Text,
                tbUsuario.Text,
                tbPassword.Text,
                tbBaseDeDatos.Text
             );
            MessageBox.Show("Conexión cifrada y guardada.");
        }
    }
}

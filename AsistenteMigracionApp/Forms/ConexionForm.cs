using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            bool ConexionExitosa = false;


            // Aquí iría la lógica para probar la conexión a la base de datos

            //ConexionExitosa = true; // Cambia esto según el resultado de tu prueba de conexión




            if (ConexionExitosa)
            {
                MessageBox.Show("Conexión exitosa", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al conectar, revise los datos de conexión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

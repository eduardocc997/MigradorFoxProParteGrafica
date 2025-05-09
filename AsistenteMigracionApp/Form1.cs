using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AsistenteMigracionApp.Forms;
using AsistenteMigracionApp.Helpers;

namespace AsistenteMigracionApp
{
    public partial class frmInicio : Form
    {
        private PublicLogReader publicLogReader;
        static string mysqlConnectionString = "Server=localhost;Database=migracion_test;Uid=root;Pwd=camacho123;AllowLoadLocalInfile=true;";
        static private int timersIntervals = 500;
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            dgvLog.BackgroundColor = SystemColors.Window;
            string rutaLog = @"C:\Logs\MigracionFoxPro\PublicLog.csv";
            publicLogReader = new PublicLogReader(rutaLog);

            logTimer = new Timer();
            logTimer.Interval = timersIntervals;
            logTimer.Tick += (s, ev) => ActualizarLog();
            logTimer.Start();

            verificacionProcesoTimer = new Timer();
            verificacionProcesoTimer.Interval = timersIntervals;
            verificacionProcesoTimer.Tick += (s, ev) => VerificarEstadoEjecucionMigracion(); 
            verificacionProcesoTimer.Start();

            VerificarEstadoEjecucionMigracion();
            ActualizarLog();
        }

        private void ActualizarLog()
        {
            if (publicLogReader.HaCambiado())
            {
                dgvLog.DataSource = publicLogReader.LeerLog();
                if (dgvLog.Rows.Count > 0)
                {
                    dgvLog.FirstDisplayedScrollingRowIndex = dgvLog.Rows.Count - 1;
                }

                AjustarColumnasLog();
            }
        }
        private void AjustarColumnasLog()
        {
            //dgvLog.Columns["Fecha"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dgvLog.Columns["Tipo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dgvLog.Columns["Mensaje"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }


        private void VerificarEstadoEjecucionMigracion()
        {
            btnConexion.Enabled = false;
            panelColorIndicador.BackColor = Color.Gray; //Proceso detenido
            lblEstadoMigracion.Text = "Verificando...";

            if (EnEjecucionMigracion())
            {
                panelColorIndicador.BackColor = Color.Yellow; //Proceso en ejecucion
                lblEstadoMigracion.Text = "Migraciónn en ejecución";
                btnEjecutarManualmente.Enabled = false;
            }
            else
            {
                panelColorIndicador.BackColor = Color.Green; //Proceso detenido
                lblEstadoMigracion.Text = "No se está ejecutando la migración";
                btnEjecutarManualmente.Enabled = true;
            }
            btnConexion.Enabled = true;
        }

        private bool EnEjecucionMigracion()
        {
            var procesos = Process.GetProcessesByName("AsistenteMigracionVFP"); // sin ".exe"
            return procesos.Length > 0;
        }

        private void btnConexion_Click(object sender, EventArgs e)
        {
            ConexionForm conexionForm = new ConexionForm();
            conexionForm.ShowDialog();
        }
    }
}

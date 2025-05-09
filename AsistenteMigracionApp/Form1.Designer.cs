
namespace AsistenteMigracionApp
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblEstadoMigracion = new System.Windows.Forms.Label();
            this.panelColorIndicador = new System.Windows.Forms.Panel();
            this.btnConexion = new System.Windows.Forms.Button();
            this.logTimer = new System.Windows.Forms.Timer(this.components);
            this.dgvLog = new System.Windows.Forms.DataGridView();
            this.verificacionProcesoTimer = new System.Windows.Forms.Timer(this.components);
            this.btnEjecutarManualmente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEstadoMigracion
            // 
            this.lblEstadoMigracion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstadoMigracion.Location = new System.Drawing.Point(407, 12);
            this.lblEstadoMigracion.Name = "lblEstadoMigracion";
            this.lblEstadoMigracion.Size = new System.Drawing.Size(189, 18);
            this.lblEstadoMigracion.TabIndex = 0;
            this.lblEstadoMigracion.Text = "Verificando estado...";
            this.lblEstadoMigracion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelColorIndicador
            // 
            this.panelColorIndicador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelColorIndicador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelColorIndicador.Location = new System.Drawing.Point(602, 12);
            this.panelColorIndicador.Name = "panelColorIndicador";
            this.panelColorIndicador.Size = new System.Drawing.Size(18, 18);
            this.panelColorIndicador.TabIndex = 1;
            // 
            // btnConexion
            // 
            this.btnConexion.Location = new System.Drawing.Point(12, 10);
            this.btnConexion.Name = "btnConexion";
            this.btnConexion.Size = new System.Drawing.Size(93, 23);
            this.btnConexion.TabIndex = 2;
            this.btnConexion.Text = "🔗 Conexión";
            this.btnConexion.UseVisualStyleBackColor = true;
            this.btnConexion.Click += new System.EventHandler(this.btnConexion_Click);
            // 
            // dgvLog
            // 
            this.dgvLog.AllowUserToAddRows = false;
            this.dgvLog.AllowUserToDeleteRows = false;
            this.dgvLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLog.Location = new System.Drawing.Point(12, 39);
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.ReadOnly = true;
            this.dgvLog.Size = new System.Drawing.Size(665, 308);
            this.dgvLog.TabIndex = 3;
            // 
            // btnEjecutarManualmente
            // 
            this.btnEjecutarManualmente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEjecutarManualmente.Enabled = false;
            this.btnEjecutarManualmente.Location = new System.Drawing.Point(626, 10);
            this.btnEjecutarManualmente.Name = "btnEjecutarManualmente";
            this.btnEjecutarManualmente.Size = new System.Drawing.Size(51, 23);
            this.btnEjecutarManualmente.TabIndex = 4;
            this.btnEjecutarManualmente.Text = "▶️";
            this.btnEjecutarManualmente.UseVisualStyleBackColor = true;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(689, 555);
            this.Controls.Add(this.btnEjecutarManualmente);
            this.Controls.Add(this.dgvLog);
            this.Controls.Add(this.btnConexion);
            this.Controls.Add(this.lblEstadoMigracion);
            this.Controls.Add(this.panelColorIndicador);
            this.Name = "frmInicio";
            this.Text = "Migrador FoxPro";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEstadoMigracion;
        private System.Windows.Forms.Panel panelColorIndicador;
        private System.Windows.Forms.Button btnConexion;
        private System.Windows.Forms.Timer logTimer;
        private System.Windows.Forms.DataGridView dgvLog;
        private System.Windows.Forms.Timer verificacionProcesoTimer;
        private System.Windows.Forms.Button btnEjecutarManualmente;
    }
}


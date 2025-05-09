namespace AsistenteMigracionApp.Forms
{
    partial class ConexionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbServidor = new System.Windows.Forms.TextBox();
            this.tbPuerto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbContrasenia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbBaseDeDatos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGuardarConexion = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnProbarConexion = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servidor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(431, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Puerto";
            // 
            // tbServidor
            // 
            this.tbServidor.Location = new System.Drawing.Point(15, 25);
            this.tbServidor.MaxLength = 1000;
            this.tbServidor.Name = "tbServidor";
            this.tbServidor.Size = new System.Drawing.Size(398, 20);
            this.tbServidor.TabIndex = 2;
            // 
            // tbPuerto
            // 
            this.tbPuerto.Location = new System.Drawing.Point(434, 25);
            this.tbPuerto.MaxLength = 5;
            this.tbPuerto.Name = "tbPuerto";
            this.tbPuerto.Size = new System.Drawing.Size(138, 20);
            this.tbPuerto.TabIndex = 3;
            this.tbPuerto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPuerto_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre de usuario";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(15, 90);
            this.tbUsuario.MaxLength = 200;
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(277, 20);
            this.tbUsuario.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contraseña";
            // 
            // tbContrasenia
            // 
            this.tbContrasenia.Location = new System.Drawing.Point(15, 129);
            this.tbContrasenia.MaxLength = 200;
            this.tbContrasenia.Name = "tbContrasenia";
            this.tbContrasenia.PasswordChar = '*';
            this.tbContrasenia.Size = new System.Drawing.Size(277, 20);
            this.tbContrasenia.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Base de datos";
            // 
            // tbBaseDeDatos
            // 
            this.tbBaseDeDatos.Location = new System.Drawing.Point(15, 168);
            this.tbBaseDeDatos.MaxLength = 200;
            this.tbBaseDeDatos.Name = "tbBaseDeDatos";
            this.tbBaseDeDatos.Size = new System.Drawing.Size(277, 20);
            this.tbBaseDeDatos.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(298, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nombre de usuario para la conexión";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(298, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Contraseña para la establecer la conexión";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(298, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(270, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Nombre de la base de datos donde se hará la migración";
            // 
            // btnGuardarConexion
            // 
            this.btnGuardarConexion.Location = new System.Drawing.Point(448, 226);
            this.btnGuardarConexion.Name = "btnGuardarConexion";
            this.btnGuardarConexion.Size = new System.Drawing.Size(124, 23);
            this.btnGuardarConexion.TabIndex = 13;
            this.btnGuardarConexion.Text = "💾 Guardar conexión";
            this.btnGuardarConexion.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(12, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(335, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Nombre o servidor IP donde se hará la conexión (puede ser localhost)";
            // 
            // btnProbarConexion
            // 
            this.btnProbarConexion.Location = new System.Drawing.Point(12, 194);
            this.btnProbarConexion.Name = "btnProbarConexion";
            this.btnProbarConexion.Size = new System.Drawing.Size(138, 23);
            this.btnProbarConexion.TabIndex = 15;
            this.btnProbarConexion.Text = "🔗 Probar conexión";
            this.btnProbarConexion.UseVisualStyleBackColor = true;
            this.btnProbarConexion.Click += new System.EventHandler(this.btnProbarConexion_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(271, 226);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(171, 23);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = " ❌ Salir sin guardar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ConexionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnProbarConexion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnGuardarConexion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbBaseDeDatos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbContrasenia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPuerto);
            this.Controls.Add(this.tbServidor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "ConexionForm";
            this.Text = "Migrador FoxPro - Configurar conexión";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConexionForm_FormClosing);
            this.Load += new System.EventHandler(this.ConexionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbServidor;
        private System.Windows.Forms.TextBox tbPuerto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbContrasenia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbBaseDeDatos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGuardarConexion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnProbarConexion;
        private System.Windows.Forms.Button btnSalir;
    }
}
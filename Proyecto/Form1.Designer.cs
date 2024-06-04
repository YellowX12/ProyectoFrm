namespace Proyecto
{
    partial class FrmLogin
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
            this.BtnIniciarSesion = new System.Windows.Forms.Button();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.LblInicioSesion = new System.Windows.Forms.Label();
            this.LblCrearCuenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnIniciarSesion
            // 
            this.BtnIniciarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnIniciarSesion.Location = new System.Drawing.Point(321, 240);
            this.BtnIniciarSesion.Name = "BtnIniciarSesion";
            this.BtnIniciarSesion.Size = new System.Drawing.Size(109, 22);
            this.BtnIniciarSesion.TabIndex = 0;
            this.BtnIniciarSesion.Text = "Iniciar Sesion";
            this.BtnIniciarSesion.UseVisualStyleBackColor = true;
            this.BtnIniciarSesion.Click += new System.EventHandler(this.BtnIniciarSesion_Click);
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(312, 79);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(286, 20);
            this.TxtUsuario.TabIndex = 3;
            this.TxtUsuario.Text = "Usuario";
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Location = new System.Drawing.Point(312, 160);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Size = new System.Drawing.Size(286, 20);
            this.TxtContraseña.TabIndex = 4;
            this.TxtContraseña.Text = "Contraseña";
            // 
            // LblInicioSesion
            // 
            this.LblInicioSesion.AutoSize = true;
            this.LblInicioSesion.Location = new System.Drawing.Point(413, 36);
            this.LblInicioSesion.Name = "LblInicioSesion";
            this.LblInicioSesion.Size = new System.Drawing.Size(80, 13);
            this.LblInicioSesion.TabIndex = 5;
            this.LblInicioSesion.Text = "Inicio de sesion";
            this.LblInicioSesion.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblCrearCuenta
            // 
            this.LblCrearCuenta.Location = new System.Drawing.Point(471, 240);
            this.LblCrearCuenta.Name = "LblCrearCuenta";
            this.LblCrearCuenta.Size = new System.Drawing.Size(109, 23);
            this.LblCrearCuenta.TabIndex = 6;
            this.LblCrearCuenta.Text = "Crear cuenta";
            this.LblCrearCuenta.UseVisualStyleBackColor = true;
            this.LblCrearCuenta.Click += new System.EventHandler(this.LblCrearCuenta_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 356);
            this.Controls.Add(this.LblCrearCuenta);
            this.Controls.Add(this.LblInicioSesion);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.BtnIniciarSesion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnIniciarSesion;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.Label LblInicioSesion;
        private System.Windows.Forms.Button LblCrearCuenta;
    }
}


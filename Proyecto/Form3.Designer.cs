namespace Proyecto
{
    partial class FrmCrearCuenta
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
            this.LblRegistro = new System.Windows.Forms.Label();
            this.TxtNewUsuario = new System.Windows.Forms.TextBox();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.TxtConfirContraseña = new System.Windows.Forms.TextBox();
            this.BtnCrear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblRegistro
            // 
            this.LblRegistro.AutoSize = true;
            this.LblRegistro.Location = new System.Drawing.Point(347, 52);
            this.LblRegistro.Name = "LblRegistro";
            this.LblRegistro.Size = new System.Drawing.Size(69, 13);
            this.LblRegistro.TabIndex = 0;
            this.LblRegistro.Text = "Crear Cuenta";
            this.LblRegistro.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtNewUsuario
            // 
            this.TxtNewUsuario.Location = new System.Drawing.Point(280, 87);
            this.TxtNewUsuario.Multiline = true;
            this.TxtNewUsuario.Name = "TxtNewUsuario";
            this.TxtNewUsuario.Size = new System.Drawing.Size(229, 21);
            this.TxtNewUsuario.TabIndex = 4;
            this.TxtNewUsuario.Text = "Nuevo Usuario";
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Location = new System.Drawing.Point(280, 137);
            this.TxtContraseña.Multiline = true;
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Size = new System.Drawing.Size(229, 21);
            this.TxtContraseña.TabIndex = 5;
            this.TxtContraseña.Text = "Contaseña";
            // 
            // TxtConfirContraseña
            // 
            this.TxtConfirContraseña.Location = new System.Drawing.Point(280, 183);
            this.TxtConfirContraseña.Multiline = true;
            this.TxtConfirContraseña.Name = "TxtConfirContraseña";
            this.TxtConfirContraseña.Size = new System.Drawing.Size(229, 21);
            this.TxtConfirContraseña.TabIndex = 6;
            this.TxtConfirContraseña.Text = "Confirmar Contraseña";
            // 
            // BtnCrear
            // 
            this.BtnCrear.Location = new System.Drawing.Point(330, 233);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(102, 21);
            this.BtnCrear.TabIndex = 7;
            this.BtnCrear.Text = "Crear Cuenta";
            this.BtnCrear.UseVisualStyleBackColor = true;
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // FrmCrearCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 318);
            this.Controls.Add(this.BtnCrear);
            this.Controls.Add(this.TxtConfirContraseña);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.TxtNewUsuario);
            this.Controls.Add(this.LblRegistro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCrearCuenta";
            this.Text = "CrearCuenta";
            this.Load += new System.EventHandler(this.FrmCrearCuenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblRegistro;
        private System.Windows.Forms.TextBox TxtNewUsuario;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.TextBox TxtConfirContraseña;
        private System.Windows.Forms.Button BtnCrear;
    }
}
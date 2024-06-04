using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "Usuario" && TxtContraseña.Text == "Contraseña")
            {
                MessageBox.Show("Inico de Sesion correctamente", "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide ();
                FrmMenu InicioSesion = new FrmMenu();

                InicioSesion.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LblCrearCuenta_Click(object sender, EventArgs e)
        {
            FrmCrearCuenta CrearCuenta = new FrmCrearCuenta();
            this.Hide();
            CrearCuenta.Show();
        }
    }
}

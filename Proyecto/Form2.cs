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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnJugar_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult Resultado = MessageBox.Show("¿Salir de la App?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnPuntuacion_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPuntuacion puntuacion= new FrmPuntuacion();
            puntuacion.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracker
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Validamos que se haya ingresado un usuario
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Debe ingresar un usuario");
                return;

            }

            //Validamos que se haya ingresado una contraseña
            if (txtContraseña.Text == "")
            {
                MessageBox.Show("Debe ingresar una contraseña");
                return;

            }
            MessageBox.Show("Usted ha ingresado al sistema");
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Mercado
{
    public partial class frmLogin : Form

    {
        frmprincipal logeo;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void pnlcentral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor no se permiten campos vacios", "Valide de nuevo");
            }
            else if (txtusuario.Text == "Jesus" && txtpassword.Text == "12345")
            {
                logeo = new frmprincipal();
                logeo.Show();
                this.Hide();

            }
            else
                MessageBox.Show("Usuario o contraseña incorrectas", "Valide de nuevo");
        }
    }
}

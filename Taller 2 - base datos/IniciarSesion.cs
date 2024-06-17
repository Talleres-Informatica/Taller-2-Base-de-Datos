using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller_2___base_datos
{
    public partial class IniciarSesion : Form
    {
        private string usuario = "pamela";
        private string clave = "123";
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (TextoUsuario.Text == usuario && TextoClave.Text == clave)
            {
                MenuAdmin menuAdmin = new MenuAdmin();
                menuAdmin.Show();
            }

            else
            {
                MessageBox.Show("Usuario o clave inválida.");
            }


        }
    }
}

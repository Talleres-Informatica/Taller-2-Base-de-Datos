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
    public partial class MenuCliente : Form
    {
        public MenuCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVerInUsuario_Click(object sender, EventArgs e)
        {
            IngresarUsuario ingresarUsuario = new IngresarUsuario();
            ingresarUsuario.Show();
        }

        private void btnVerElimCliente_Click(object sender, EventArgs e)
        {
            EliminarCliente eliminarCliente = new EliminarCliente();
            eliminarCliente.Show();
        }

        private void BtnListaCliente_Click(object sender, EventArgs e)
        {
            ListaCliente listaCliente = new ListaCliente();
            listaCliente.Show();
        }
    }
}

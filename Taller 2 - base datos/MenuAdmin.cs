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
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {

        }

        // USUARIOS
        private void BtnVerElimCliente_Click_1(object sender, EventArgs e)
        {
            EliminarCliente eliminarCliente = new EliminarCliente();
            eliminarCliente.Show();

        }

        private void BtnModificarCliente_Click(object sender, EventArgs e)
        {
            ModificarClientecs modificarCliente = new ModificarClientecs();
            modificarCliente.Show();
        }

        private void BtnVerInUsuario_Click(object sender, EventArgs e)
        {
            IngresarUsuario ingresarUsuario = new IngresarUsuario();
            ingresarUsuario.Show();
        }


        // PRODUCTOS

        private void BtnModificarProducto_Click(object sender, EventArgs e)
        {
            ModificarProducto modificarProducto = new ModificarProducto();
            modificarProducto.Show();
        }

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            IngresarProducto ingresarProducto = new IngresarProducto();
            ingresarProducto.Show();
        }

        private void BtnVerEliminarProducto_Click(object sender, EventArgs e)
        {
            EliminarProducto eliminarProducto = new EliminarProducto();
            eliminarProducto.Show();
        }
    }
}

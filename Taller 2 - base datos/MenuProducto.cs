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
    public partial class MenuProducto : Form
    {
        public MenuProducto()
        {
            InitializeComponent();
        }

        private void BtnModificarProducto_Click(object sender, EventArgs e)
        {
            ModificarProducto modificarProducto = new ModificarProducto();
            modificarProducto.Show();
        }

        private void BtnListaProducto_Click(object sender, EventArgs e)
        {
            ListaProducto listaProducto = new ListaProducto();
            listaProducto.Show();
        }
    }
}

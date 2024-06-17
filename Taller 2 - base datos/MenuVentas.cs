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
    public partial class MenuVentas : Form
    {
        public MenuVentas()
        {
            InitializeComponent();
        }

        private void BtnListaVenta_Click(object sender, EventArgs e)
        {
            ListaVenta listaVenta = new ListaVenta();
            listaVenta.Show();
        }

        private void BtnRealizarVenta_Click(object sender, EventArgs e)
        {
            IngresarVenta ingresarVenta = new IngresarVenta();
            ingresarVenta.Show();
            //RealizarVenta realizarVenta = new RealizarVenta();  
            //realizarVenta.Show();
        }

        private void RealizarVenta_Load(object sender, EventArgs e)
        {

        }

        private void BtnVentasCliente_Click(object sender, EventArgs e)
        {
            // ACCEDER A VENTAS CLIENTE
            VentasCliente cliente = new VentasCliente();
            cliente.Show();
        }
    }
}

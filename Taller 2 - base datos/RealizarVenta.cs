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
    public partial class RealizarVenta : Form
    {
        public RealizarVenta()
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
            RealizarVenta realizarVenta = new RealizarVenta();  
            realizarVenta.Show();
        }
    }
}

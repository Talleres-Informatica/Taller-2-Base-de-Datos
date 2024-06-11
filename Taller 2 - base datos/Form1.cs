using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taller2;

namespace Taller_2___base_datos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnVerProyecto_Click(object sender, EventArgs e)
        {
            IngresarProducto ingresarProducto = new IngresarProducto();
            ingresarProducto.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ConnectMySQL.Instance.OpenConnection();
            //ConnectMySQL.Instance.CloseConnection();
            ConnectMySQL.Instance.SelectQuery(null);
            ConnectMySQL.Instance.SelectQueryScalar(null);
            ConnectMySQL.Instance.ExecuteQuery(null);
        }

        private void BtnVerCliente_Click(object sender, EventArgs e)
        {
            MenuCliente menuCliente = new MenuCliente();
            menuCliente.Show();

        }

        private void BtnVerVenta_Click(object sender, EventArgs e)
        {
            RealizarVenta realizarVenta = new RealizarVenta();
            realizarVenta.Show();
        }
    }
}

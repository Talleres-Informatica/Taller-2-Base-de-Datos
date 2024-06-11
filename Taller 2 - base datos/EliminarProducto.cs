using MySql.Data.MySqlClient;
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
    public partial class EliminarProducto : Form
    {
        public EliminarProducto()
        {
            InitializeComponent();
        }

        private void EliminarProducto_Load(object sender, EventArgs e)
        {
            string query = "SELECT idProducto, nombre, stockProducto, precioProducto  FROM productos WHERE estado = 0";
            DataTable data = ConnectMySQL.Instance.SelectQuery(query);
            dataListaProducto.DataSource = data;
        }

        private void BtnEliminarProducto_Click(object sender, EventArgs e)
        {
            string query = "UPDATE producto SET estado = 1 WHERE idProducto = @idProducto";

            MySqlParameter[] parameters = {
                new MySqlParameter("@idProducto", dataListaProducto.CurrentCell.Value)
            };

            ConnectMySQL.Instance.ExecuteQuery(query, parameters);
            MessageBox.Show("Producto eliminado con exito");


            query = "SELECT idProducto, nombre, stockProducto, precioProducto FROM productos WHERE estado = 0";
            DataTable data = ConnectMySQL.Instance.SelectQuery(query);
            dataListaProducto.DataSource = data;
        }
    }
}

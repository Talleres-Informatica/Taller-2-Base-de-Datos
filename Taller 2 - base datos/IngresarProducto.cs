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
    public partial class IngresarProducto : Form
    {
        public IngresarProducto()
        {
            InitializeComponent();
        }

        private void NombreProductoInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void StockProductoInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrecioProductoInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnIngresarProducto_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO producto (nombreProducto, stockProducto, precioProducto) VALUES (@nombreProducto, @stockProducto, @precioProducto);";

            MySqlParameter[] parameters =
            {
            new MySqlParameter("@nombreProducto", NombreProductoInput.Text),
            new MySqlParameter("@stockProducto", StockProductoInput.Text),
            new MySqlParameter("@precioProducto", PrecioProductoInput.Text)
            };

            Console.WriteLine(NombreProductoInput.Text + " ");

            ConnectMySQL.Instance.ExecuteQuery(query, parameters);
            MessageBox.Show("Producto ingresado con exito");
            //TODO: HACER ERROR
        }
    }
}

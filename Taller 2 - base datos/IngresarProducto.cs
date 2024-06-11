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
            string query = "INSERT INTO Producto(nombreProducto, stockProducto, precioProducto) VALUES(@nombreProducto, @stockProducto, @precioProducto)";

            MySqlParameter[] parameters =
            {
            new MySqlParameter("@nombreProducto", NombreProductoInput),
            new MySqlParameter("@stockProducto", StockProductoInput),
            new MySqlParameter("@precioProdcuto", PrecioProductoInput)
            };
            ConnectMySQL.Instance.ExecuteQuery(query, parameters);
            //MensageBox.Show("Cliente normal ingresado con exito");
            //TODO: HACER ERROR
            

        }
    }
}

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
            // validaciones
            if (string.IsNullOrWhiteSpace(NombreProductoInput.Text) || string.IsNullOrWhiteSpace(StockProductoInput.Text) || string.IsNullOrWhiteSpace(PrecioProductoInput.Text))
            {
                MessageBox.Show("No puedes dejar campos vacíos");
                return;
            }

            // validaciones
            int nuevoStock;

            // Validar que el valor ingresado sea un número entero positivo
            if (!int.TryParse(StockProductoInput.Text, out nuevoStock) || nuevoStock < 0)
            {
                MessageBox.Show("Ingrese una cantidad válida para el stock.");
                return;
            }
            if (!int.TryParse(PrecioProductoInput.Text, out nuevoStock) || nuevoStock <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida para el precio.");
                return;
            }


            string query = "INSERT INTO producto (nombreProducto, stockProducto, precioProducto, estado) VALUES (@nombreProducto, @stockProducto, @precioProducto, 0);";

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

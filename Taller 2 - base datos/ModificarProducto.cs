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
    public partial class ModificarProducto : Form
    {
        public ModificarProducto()
        {
            InitializeComponent();
        }

        private void ModificarProducto_Load(object sender, EventArgs e)
        {

            string query = "SELECT nombreProducto FROM producto WHERE estado = 0";

            DataTable nombres = ConnectMySQL.Instance.SelectQuery(query);
            for (int i = 0; i < nombres.Rows.Count; i++)
            {
                ListaProductos.Items.Add(nombres.Rows[i]["NombreProducto"]);
            }

            ConnectMySQL.Instance.CloseConnection();

        }

        private void ListaProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Establecer stock Actual de un producto
            string query = "SELECT stockProducto FROM producto WHERE nombreProducto = @nombreProducto";
            string[] parameters = { "@nombreProducto", ListaProductos.Text };
            string stock = ConnectMySQL.Instance.SelectQueryScalar(query, parameters);
            StockActualText.Text = stock;

            //establece precio Actual de un preducto
            string query2 = "SELECT precioProducto FROM producto WHERE nombreProducto = @nombreProducto";
            string[] parameters2 = { "@nombreProducto", ListaProductos.Text };
            string precio = ConnectMySQL.Instance.SelectQueryScalar(query2, parameters2);
            PrecioActualText.Text = precio;
        }

        private void BtnActualizarStock_Click(object sender, EventArgs e)
        {
            string query = "UPDATE producto SET stockProducto = @stockProducto WHERE nombreProducto = @nomnreProducto";

            
                MySqlParameter[] parameters =
                {
                new MySqlParameter("@stock", int.Parse(StockActualText.Text) + int.Parse(StockNuevoText.Text)),
                new MySqlParameter("@nombreProducto", ListaProductos.Text)
                };

                ConnectMySQL.Instance.ExecuteQuery(query, parameters);
                     
        }

        private void BtnActualizarPrecio_Click(object sender, EventArgs e)
        {
            string query = "UPDATE producto SET precioProducto = @precioProducto WHERE nombreProducto = @nomnreProducto";
                        
            MySqlParameter[] parameters =
            {
                new MySqlParameter("@precio", PrecioNuevoText.Text),
                new MySqlParameter("@nombreProducto", ListaProductos.Text)
            };

            ConnectMySQL.Instance.ExecuteQuery(query,parameters);
            
        }
                       
    }
}

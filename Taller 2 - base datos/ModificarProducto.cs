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
            //consulta a sql
            string query = "SELECT nombreProducto FROM producto WHERE estado = 0";

            DataTable nombres = ConnectMySQL.Instance.SelectQuery(query);

            //agrega el nombre de un producto a la listaProductosBox
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
            //consulta a sql
            string query = "UPDATE producto SET stockProducto = @stockProducto WHERE nombreProducto = @nombreProducto";

                
            //que hacer en sql
            MySqlParameter[] parameters =
            {
            new MySqlParameter("@stockProducto", int.Parse(StockActualText.Text) + int.Parse(StockNuevoText.Text)),
            new MySqlParameter("@nombreProducto", ListaProductos.Text)
            };

            ConnectMySQL.Instance.ExecuteQuery(query, parameters);

            MessageBox.Show("Stock actualizado con exito");

        }

        private void BtnActualizarPrecio_Click(object sender, EventArgs e)
        {
            //consulta sql
            string query = "UPDATE producto SET precioProducto = @precioProducto WHERE nombreProducto = @nombreProducto";
                        
            //que hacer en sql
            MySqlParameter[] parameters =
            {
                new MySqlParameter("@precioProducto", PrecioNuevoText.Text),
                new MySqlParameter("@nombreProducto", ListaProductos.Text)
            };

            ConnectMySQL.Instance.ExecuteQuery(query,parameters);


            MessageBox.Show("Precio actualizado con exito");

        }
                       
    }
}

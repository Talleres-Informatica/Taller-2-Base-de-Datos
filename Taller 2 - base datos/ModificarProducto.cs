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

            StockNuevoText.Enabled = false;
            
            BtnActualizarStock.Enabled = false;
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

            // Verifica si se ha seleccionado un producto
            if (ListaProductos.SelectedItem != null)
            {
                // Habilita botones y inputs
                StockNuevoText.Enabled = true;
                BtnActualizarStock.Enabled = true;
            }

            //Establecer stock Actual de un producto
            string query = "SELECT stockProducto FROM producto WHERE nombreProducto = @nombreProducto";
            string[] parameters = { "@nombreProducto", ListaProductos.Text };
            string stock = ConnectMySQL.Instance.SelectQueryScalar(query, parameters);
            StockActualText.Text = stock;
        }

        private void BtnActualizarStock_Click(object sender, EventArgs e)
        {


            // validaciones
            if (string.IsNullOrWhiteSpace(StockNuevoText.Text))
            {
                MessageBox.Show("Ingrese un nuevo stock antes de modificar el stock del producto");
                return;
            }

            // validaciones
            int nuevoStock;

            // Validar que el valor ingresado sea un número entero positivo
            if (!int.TryParse(StockNuevoText.Text, out nuevoStock) || nuevoStock < 0)
            {
                MessageBox.Show("Ingrese una cantidad válida para actualizar el stock.");
                return;
            }

            

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

        
                       
    }
}

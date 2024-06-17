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
    public partial class PrecioProducto : Form
    {
        public PrecioProducto()
        {
            InitializeComponent();
            PrecioNuevoText.Enabled = false;

            BtnActualizarPrecio.Enabled = false;
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
                PrecioNuevoText.Enabled = true;

                BtnActualizarPrecio.Enabled = true;
            }

            //establece precio Actual de un preducto
            string query2 = "SELECT precioProducto FROM producto WHERE nombreProducto = @nombreProducto";
            string[] parameters2 = { "@nombreProducto", ListaProductos.Text };
            string precio = ConnectMySQL.Instance.SelectQueryScalar(query2, parameters2);
            PrecioActualText.Text = precio;
        }

        private void BtnActualizarPrecio_Click(object sender, EventArgs e)
        {
            // validacion vacio
            if (string.IsNullOrWhiteSpace(PrecioNuevoText.Text))
            {
                MessageBox.Show("Ingrese un precio nuevo antes de modificar el precio del producto");
                return;
            }

            int nuevoPrecio;
            // Validar que el valor ingresado sea un número entero positivo
            if (!int.TryParse(PrecioNuevoText.Text, out nuevoPrecio) || nuevoPrecio < 0)
            {
                MessageBox.Show("Ingrese una cantidad válida para actualizar el precio.");
                return;
            }

            //consulta sql
            string query = "UPDATE producto SET precioProducto = @precioProducto WHERE nombreProducto = @nombreProducto";

            //que hacer en sql
            MySqlParameter[] parameters =
            {
                new MySqlParameter("@precioProducto", PrecioNuevoText.Text),
                new MySqlParameter("@nombreProducto", ListaProductos.Text)
            };

            ConnectMySQL.Instance.ExecuteQuery(query, parameters);


            MessageBox.Show("Precio actualizado con exito");

        }
    }
}

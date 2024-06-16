using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections;
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
    public partial class IngresarVenta : Form
    {
        private int IdVentaActual; // IdVenta Actual
        public IngresarVenta()
        {
            InitializeComponent();
            CargarClientes();
            SetIdVentaActual();
            NombreProductoTexto.Enabled = false;
            TextoIngreseProducto.Enabled = false;
            TextoIngreseCantidad.Enabled = false;

            CantidadVenderTexto.Enabled = false;

            BtnAgregarProducto.Enabled = false;
            BtnAtenderCliente.Enabled = false;
            ListaClientesNombres.Enabled = true;

            // DataGrid de Ventas

            string query = "SELECT v.idVenta, v.idCliente FROM venta v";
            DataTable data = ConnectMySQL.Instance.SelectQuery(query);
            dataGridVentas.DataSource = data;

            string query2 = "SELECT dv.idVenta, dv.idProducto, dv.cantidadProducto FROM detalleventa dv";
            DataTable data2 = ConnectMySQL.Instance.SelectQuery(query2);
            dataGridVentasProductos.DataSource = data2;

            IdVentaTexto.Enabled = false;

        }

        // ignorar
        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Metodo que habilita Agregar producto y prohibe presionar este boton de nuevo Atender Cliente
        private void BtnAtenderCliente_Click(object sender, EventArgs e)
        {
            // Hace que la idVenta sea +1 al realizar otra venta. Debe partir desde la última venta.

            // Solo se actualiza la idVenta con +1 cuando se presione BtnAtenderCliente y debe funcionar aunque
            // se cierre esta ventana, es decir, debe obtener el mayor IDVenta que haya en la tabla venta y según eso ver
            // cual IDVenta debe estar actualmente (si ya hay 3 ventas, debe partir desde la idVenta = 4)
            
            BtnAtenderCliente.Enabled = false;

            ListaClientesNombres.Enabled = false;

            NombreProductoTexto.Enabled = true;

            TextoIngreseProducto.Enabled = true;
            TextoIngreseCantidad.Enabled = true;

            CantidadVenderTexto.Enabled = true;

            BtnFinalizarAtencion.Enabled = true;
            BtnAgregarProducto.Enabled = true;

            IdVentaTexto.Enabled = true;

            string query = "SELECT MAX(v.idVenta)+1 FROM venta v";
            string resultado = ConnectMySQL.Instance.SelectQueryScalar(query);

            IdVentaTexto.Text = resultado;

        }

        // Obtiene la ultima IdVenta de la Base de Datos como IdVentaActual y le suma 1
        private void SetIdVentaActual()
        {
            string query = "SELECT MAX(v.idVenta) FROM venta v";

            try
            {
                string resultado = ConnectMySQL.Instance.SelectQueryScalar(query);

                // Entrega el ultimo IdVenta+1 o entrega un 1 solamente
                IdVentaActual = string.IsNullOrEmpty(resultado) ? 1 : int.Parse(resultado) + 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el ID de venta actual: " + ex.Message);
            }
        }

        //ignorar
        private void ListaClientesNombres_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica si se ha seleccionado un cliente
            if (ListaClientesNombres.SelectedItem != null)
            {
                // Habilita el botón BtnAtenderCliente
                BtnAtenderCliente.Enabled = true;
            }
        }


       
        //ignorar
        private void NombreProductoTexto_TextChanged(object sender, EventArgs e)
        {
        }


        private void AgregarProductoVentaActual(string nombreProducto)
        {
            string nombreCliente = ListaClientesNombres.SelectedItem?.ToString();
            
            if (string.IsNullOrWhiteSpace(nombreCliente))
            {
                MessageBox.Show("Seleccione un cliente antes de agregar productos.");
                return;
            }



            // Obtener IdCliente
            string queryCliente = "SELECT c.id FROM cliente c " +
                "WHERE c.nombre = @nombre";
            string IdCliente;

            try
            {
                DataTable clientData = ConnectMySQL.Instance.SelectQuery(queryCliente, "@nombre", nombreCliente);

                if (clientData.Rows.Count > 0)
                {
                    IdCliente = clientData.Rows[0]["id"].ToString();
                }

                else
                {
                    MessageBox.Show("Cliente no encontrado.");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el ID del cliente: " + ex.Message);
                return;

            }



            // obtener IdProducto y stockProducto

            string queryProducto = "SELECT p.idProducto, p.stockProducto FROM producto p " +
                "WHERE p.nombreProducto = @nombreProducto";

            string IdProducto;
            int stockProducto;


            try
            {
                DataTable productData = ConnectMySQL.Instance.SelectQuery(queryProducto, "@nombreProducto", nombreProducto);
                if (productData.Rows.Count > 0)
                {
                    IdProducto = productData.Rows[0]["idProducto"].ToString();
                    stockProducto = Convert.ToInt32(productData.Rows[0]["stockProducto"]);
                }
                else
                {
                    MessageBox.Show("Producto no encontrado.");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el ID del producto: " + ex.Message);
                return;
            }


            // Verificar si hay stock del producto
            int cantidadVender;
            if (!int.TryParse(CantidadVenderTexto.Text, out cantidadVender) || cantidadVender <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida para vender.");
                return;
            }

            if (cantidadVender > stockProducto)
            {
                MessageBox.Show("No hay suficiente stock para este producto");
                return;

            }


            // Actualizar el stock del producto
            string actualizarStockQuery = "UPDATE producto SET stockProducto = stockProducto - @cantidadVender WHERE idProducto = @idProducto";
            try
            {
                ConnectMySQL.Instance.ExecuteQuery(actualizarStockQuery,
                    new MySqlParameter("@cantidadVender", cantidadVender),
                    new MySqlParameter("@idProducto", IdProducto));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el stock del producto: " + ex.Message);
                return;
            }


            // Insertar en la tabla venta si no existe aún
            string ventaQuery = "INSERT INTO venta (idVenta, idCliente, fecha) VALUES (@idVenta, @idCliente, NOW())";
            try
            {
                ConnectMySQL.Instance.ExecuteQuery(ventaQuery,
                    new MySqlParameter("@idVenta", IdVentaActual),
                    new MySqlParameter("@idCliente", IdCliente));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar en la tabla venta: " + ex.Message);
                return;
            }

            // Insertar en la tabla detalleventa
            string detalleVentaQuery = "INSERT INTO detalleventa (idVenta, idProducto, cantidadProducto) VALUES (@idVenta, @idProducto, @cantidadProducto)";
            try
            {
                ConnectMySQL.Instance.ExecuteQuery(detalleVentaQuery,
                    new MySqlParameter("@idVenta", IdVentaActual),
                    new MySqlParameter("@idProducto", IdProducto),
                    new MySqlParameter("@cantidadProducto", cantidadVender) );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar en la tabla detalleventa: " + ex.Message);
            }

        }
            







        // Metodo para cargar los clientes de la Base de Datos a la ComboBox "ListaClientesNombres"
        private void CargarClientes()
        {
            string query = "SELECT c.nombre FROM cliente c ";

            try
            {
                DataTable data = ConnectMySQL.Instance.SelectQuery(query);

                // va agregando cada nombre que recibe de la query en la ComboBox
                foreach (DataRow row in data.Rows)
                {
                    ListaClientesNombres.Items.Add(row["nombre"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los nombres de los clientes: " + ex.Message);
            }
        }














        private void BtnFinalizarAtencion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IdVentaTexto_Click(object sender, EventArgs e)
        {

        }

        private void dataGridVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            // Input de Producto para invocar AgregarProductoVentaActual( nombreProducto )
            string nombreProducto = NombreProductoTexto.Text;

            if (!string.IsNullOrWhiteSpace(nombreProducto))
            {
                if (ListaClientesNombres.SelectedItem != null)
                {
                    AgregarProductoVentaActual(nombreProducto);
                }
                else
                {
                    MessageBox.Show("Seleccione un cliente antes de agregar productos.");
                }
            }
        }
    }
}

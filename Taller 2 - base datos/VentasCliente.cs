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
    public partial class VentasCliente : Form
    {
        public VentasCliente()
        {
            InitializeComponent();
        }

        private void VentasCliente_Load(object sender, EventArgs e)
        {
           
        }

        private void BtnVerVenta_Click(object sender, EventArgs e)
        {
            //asigna el nombre ingresado por pantalla
            string nombre = NombreBuscar.Text;
            DateTime fecha = fechaBuscar.Value;

            // Validar las entradas
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Por favor ingrese un nombre.");
                return;
            }

            string fechaFormateada = fecha.ToString("yyyy-MM-dd");
            
            string query = "SELECT v.fecha, dv.idProducto, p.nombreProducto, dv.cantidadProducto " +
                           "FROM venta v " +
                           "JOIN detalleventa dv ON v.idVenta = dv.idVenta " +
                           "JOIN producto p ON dv.idProducto = p.idProducto " +
                           "JOIN cliente c ON v.idCliente = c.id " +
                           "WHERE v.fecha = '" +fechaFormateada+"' AND c.nombre = '"+nombre+"'";

            DataTable data = ConnectMySQL.Instance.SelectQuery(query);
            dataVentasCliente.DataSource = data;
            
        }

        
    }
}

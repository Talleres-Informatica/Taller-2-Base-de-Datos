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
    public partial class ListaVenta : Form
    {
        public ListaVenta()
        {
            InitializeComponent();
        }

        private void ListaVenta_Load(object sender, EventArgs e)             
        {

            //CANTIDAD PRODUCTOS VENDIDOS EN EL ULTIMO AÑO
            string query = "SELECT SUM(dv.cantidadProducto) AS cantidad_total_vendida " +
                "FROM detalleventa dv JOIN venta v ON dv.idVenta = v.idVenta " + 
                "WHERE YEAR(v.fecha) = YEAR(CURDATE());";

            string text = ConnectMySQL.Instance.SelectQueryScalar(query);

            //muesta lo obtenido de la query en el formulario
            cantVendidos.Text = text;



            //PRODUCTOS VENDIDOS EN LOS ULTIMOS 2 AÑOS
            string query2 = "SELECT DISTINCT p.idProducto, p.nombreProducto, v.fecha " +
                "FROM producto p " +
                "JOIN detalleventa dv ON p.idProducto = dv.idProducto " +
                "JOIN venta v ON dv.idVenta = v.idVenta " +
                "WHERE v.fecha >= DATE_SUB(CURDATE(), INTERVAL 2 YEAR);";

            DataTable data = ConnectMySQL.Instance.SelectQuery(query2);
            dataLista.DataSource = data;

            
        }

    }
}

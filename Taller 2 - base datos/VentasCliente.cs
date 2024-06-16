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

            string query = "SELECT ";

            SELECT v.idVenta, v.idCliente,
            FROM cliente c, venta v
            WHERE 

            /*
            string query = "INSERT INTO venta ( idCliente, fecha) VALUES (@idCliente, @fecha)";
                        
            MySqlParameter[] parameters =
                {
                new MySqlParameter("@idVenta", ListaCliente.Text),
                new MySqlParameter("@idCliente", id),
                new MySqlParameter("@fecha", fechaBuscar)
            };
            ConnectMySQL.Instance.ExecuteQuery(query, parameters);
            MessageBox.Show("Cliente normal ingresado con exito");
            //TODO: HACER ERROR
            */

        }

        
    }
}

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
            //consulta a sql
            string query = "SELECT nombre FROM cliente WHERE estado = 0";

            DataTable nombres = ConnectMySQL.Instance.SelectQuery(query);

            //agrega el nombre de un producto a la listaCliente
            for (int i = 0; i < nombres.Rows.Count; i++)
            {
                ListaCliente.Items.Add(nombres.Rows[i]["Nombre"]);
            }

            ConnectMySQL.Instance.CloseConnection();
        }

        private void BtnVerVenta_Click(object sender, EventArgs e)
        {

        }

        
    }
}

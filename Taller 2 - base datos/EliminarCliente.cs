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
    public partial class EliminarCliente : Form
    {
        public EliminarCliente()
        {
            InitializeComponent();
        }

        private void dataLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EliminarCliente_Load(object sender, EventArgs e)
        {
            string query = "SELECT id, nombre,ciudad  FROM cliente WHERE estado = 0";
            DataTable data = ConnectMySQL.Instance.SelectQuery(query);
            dataLista.DataSource = data;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string query = "UPDATE cliente SET estado = 1 WHERE id = @id;";

            MySqlParameter[] parameters = {
                new MySqlParameter("@id", dataLista.CurrentCell.Value) 
            };

            ConnectMySQL.Instance.ExecuteQuery(query, parameters);
            MessageBox.Show("Cliente eliminado con exito");


            query = "SELECT id, nombre, ciudad FROM cliente WHERE estado = 0;";
            DataTable data = ConnectMySQL.Instance.SelectQuery(query);
            dataLista.DataSource = data;

        }
    }
}

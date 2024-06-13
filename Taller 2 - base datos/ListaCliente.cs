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
    public partial class ListaCliente : Form
    {
        public ListaCliente()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void BtnVerListaCliente_Click(object sender, EventArgs e)
        {


            if (ListaTipobox.Text == "Normal")
            {
                string query = "SELECT id, nombre, ciudad  FROM cliente WHERE tipo = 1";
                DataTable data = ConnectMySQL.Instance.SelectQuery(query);
                dataListaCliente.DataSource = data;
            }

            else if (ListaTipobox.Text == "Premium")
            {
                string query = "SELECT id, nombre, ciudad  FROM cliente WHERE tipo = 2";
                DataTable data = ConnectMySQL.Instance.SelectQuery(query);
                dataListaCliente.DataSource = data;
            }

            else if (ListaTipobox.Text == "Todos")
            {
                string query = "SELECT id, nombre, ciudad  FROM cliente WHERE estado = 0";
                DataTable data = ConnectMySQL.Instance.SelectQuery(query);
                dataListaCliente.DataSource = data;
            }

            else
            {
                MessageBox.Show("Debes ingresar un tipo de cliente");
            }
        }

        private void CtnClientes_Click(object sender, EventArgs e)
        {
            
        }

        private void ListaCliente_Load(object sender, EventArgs e)
        {
            string query = "SELECT COUNT(*) FROM cliente WHERE tipo = 1";

            DataTable data = ConnectMySQL.Instance.SelectQuery(query);

            // Tomar la tabla que se obtuvo de la query

            CtnClientes.Text = $"{Convert.ToInt32(data.Rows[0][0])}";
        }

        private void ListaTipobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

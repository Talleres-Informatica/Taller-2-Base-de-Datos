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
    public partial class ModificarClientecs : Form
    {
        

        public ModificarClientecs()
        {
            InitializeComponent();

            BtnNormal.Enabled = false;
            BtnPremium.Enabled = false;
            
        }
        
        private void ModificarClientecs_Load(object sender, EventArgs e)
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

        
        private void BtnNormal_Click(object sender, EventArgs e)
        {
            //consulta a sql
            string query = "UPDATE cliente SET tipo = @tipo WHERE nombre = @nombre";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@tipo", 1),
                new MySqlParameter("@nombre", ListaCliente.Text)
            };

            ConnectMySQL.Instance.ExecuteQuery(query, parameters);


            MessageBox.Show("Cliente cambiado a Normal con exito");
        }

        private void BtnPremium_Click(object sender, EventArgs e)
        {
            //consulta a sql
            string query = "UPDATE cliente SET tipo = @tipo WHERE nombre = @nombre";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@tipo", 2),
                new MySqlParameter("@nombre", ListaCliente.Text)
            };

            ConnectMySQL.Instance.ExecuteQuery(query, parameters);

            MessageBox.Show("Cliente cambiado a Premium con exito");
        }

        private void ListaCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaCliente.SelectedItem != null)
            {
                BtnPremium.Enabled = true;
                BtnNormal.Enabled = true;
            }
        }
    }
}

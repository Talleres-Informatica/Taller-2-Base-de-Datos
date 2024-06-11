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
    public partial class IngresarUsuario : Form
    {
        public IngresarUsuario()
        {
            InitializeComponent();
        }

        private void NombreInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void CiudadInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListaCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnIngresarCliente_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO clientes(nombre, ciudad, tipo) VALUES(@nombre, @ciudad, @tipo)";

            if (ListaCliente.Text == "Normal")
            {
                MySqlParameter[] parameters =
                    {
                    new MySqlParameter("@nombre", NombreInput),
                    new MySqlParameter("@ciudad", CiudadInput),
                    new MySqlParameter("@tipo", 1)
                };
                ConnectMySQL.Instance.ExecuteQuery(query, parameters);
                MessageBox.Show("Cliente normal ingresado con exito");
                //TODO: HACER ERROR
            }

            else if (ListaCliente.Text == "Premium")
            {
                MySqlParameter[] parameters = {
                    new MySqlParameter("@nombre", NombreInput),
                    new MySqlParameter("@ciudad", CiudadInput),
                    new MySqlParameter("@tipo", 1)
                };
                ConnectMySQL.Instance.ExecuteQuery(query, parameters);
                MessageBox.Show("Cliente premium ingresado con exito");
                //TODO: HACER ERROR
            }

            else
            {
                MessageBox.Show("debes ingresar un tipo de cliente");
            }

        }
    }
}

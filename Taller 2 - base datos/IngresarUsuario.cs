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
            // validaciones
            if (string.IsNullOrWhiteSpace(NombreInput.Text) || string.IsNullOrWhiteSpace(CiudadInput.Text) || ListaCliente.SelectedItem == null)
            {
                MessageBox.Show("No puedes dejar campos vacíos");
                return;
            }

            string query = "INSERT INTO cliente (nombre, ciudad, tipo, estado) VALUES (@nombre, @ciudad, @tipo, 0)";

            if (ListaCliente.Text == "Normal")
            {
                MySqlParameter[] parameters =
                    {
                    new MySqlParameter("@nombre", NombreInput.Text),
                    new MySqlParameter("@ciudad", CiudadInput.Text),
                    new MySqlParameter("@tipo", 1)
                };
                ConnectMySQL.Instance.ExecuteQuery(query, parameters);
                MessageBox.Show("Cliente normal ingresado con exito");
                //TODO: HACER ERROR
            }

            else if (ListaCliente.Text == "Premium")
            {
                MySqlParameter[] parameters = {
                    new MySqlParameter("@nombre", NombreInput.Text),
                    new MySqlParameter("@ciudad", CiudadInput.Text),
                    new MySqlParameter("@tipo", 2),
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void IngresarUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}

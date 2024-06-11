﻿using System;
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
            if(ListaTipobox.Text == "Normal")
            {
                string query = "SELECT id, nombre, ciudad  FROM clientes WHERE tipo = 1";
                DataTable data = ConnectMySQL.Instance.SelectQuery(query);
                dataListaCliente.DataSource = data;
            }

            else if (ListaTipobox.Text == "Premium") 
            {
                string query = "SELECT id, nombre, ciudad  FROM clientes WHERE tipo = 0";
                DataTable data = ConnectMySQL.Instance.SelectQuery(query);
                dataListaCliente.DataSource = data;
            }

            else if (ListaTipobox.Text == "Todos")
            {
                string query = "SELECT id, nombre, ciudad  FROM clientes WHERE estado = 0";
                DataTable data = ConnectMySQL.Instance.SelectQuery(query);
                dataListaCliente.DataSource = data;
            }

            else
            {
                MessageBox.Show("Debes ingresar un tipo de cliente");
            }
        }
    }
}
﻿using MySql.Data.MySqlClient;
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
    public partial class ListaProducto : Form
    {
        public ListaProducto()
        {
            InitializeComponent();
        }

        private void ListaProducto_Load(object sender, EventArgs e)
        {
            string query = "SELECT idProducto, nombreProducto, stockProducto, precioProducto  FROM producto WHERE estado = 0";
            DataTable data = ConnectMySQL.Instance.SelectQuery(query);
            dataLista.DataSource = data;
        }

       
    }
}

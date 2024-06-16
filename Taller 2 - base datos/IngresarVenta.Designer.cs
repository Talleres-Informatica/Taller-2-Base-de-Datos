namespace Taller_2___base_datos
{
    partial class IngresarVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TituloVentaCliente = new System.Windows.Forms.Label();
            this.TextoIngreseProducto = new System.Windows.Forms.Label();
            this.NombreProductoTexto = new System.Windows.Forms.TextBox();
            this.BtnAgregarProducto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.IdVentaTexto = new System.Windows.Forms.Label();
            this.ListaClientesNombres = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnAtenderCliente = new System.Windows.Forms.Button();
            this.BtnFinalizarAtencion = new System.Windows.Forms.Button();
            this.dataGridVentas = new System.Windows.Forms.DataGridView();
            this.texto1 = new System.Windows.Forms.Label();
            this.dataGridVentasProductos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CantidadVenderTexto = new System.Windows.Forms.TextBox();
            this.TextoIngreseCantidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVentasProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // TituloVentaCliente
            // 
            this.TituloVentaCliente.AutoSize = true;
            this.TituloVentaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloVentaCliente.Location = new System.Drawing.Point(542, 22);
            this.TituloVentaCliente.Name = "TituloVentaCliente";
            this.TituloVentaCliente.Size = new System.Drawing.Size(203, 26);
            this.TituloVentaCliente.TabIndex = 0;
            this.TituloVentaCliente.Text = "Venta de Productos";
            this.TituloVentaCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TituloVentaCliente.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextoIngreseProducto
            // 
            this.TextoIngreseProducto.AutoSize = true;
            this.TextoIngreseProducto.Location = new System.Drawing.Point(24, 303);
            this.TextoIngreseProducto.Name = "TextoIngreseProducto";
            this.TextoIngreseProducto.Size = new System.Drawing.Size(193, 16);
            this.TextoIngreseProducto.TabIndex = 4;
            this.TextoIngreseProducto.Text = "Ingrese el nombre del producto";
            this.TextoIngreseProducto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NombreProductoTexto
            // 
            this.NombreProductoTexto.Location = new System.Drawing.Point(27, 322);
            this.NombreProductoTexto.Name = "NombreProductoTexto";
            this.NombreProductoTexto.Size = new System.Drawing.Size(190, 22);
            this.NombreProductoTexto.TabIndex = 3;
            this.NombreProductoTexto.TextChanged += new System.EventHandler(this.NombreProductoTexto_TextChanged);
            // 
            // BtnAgregarProducto
            // 
            this.BtnAgregarProducto.Location = new System.Drawing.Point(27, 419);
            this.BtnAgregarProducto.Name = "BtnAgregarProducto";
            this.BtnAgregarProducto.Size = new System.Drawing.Size(140, 31);
            this.BtnAgregarProducto.TabIndex = 5;
            this.BtnAgregarProducto.Text = "Agregar producto";
            this.BtnAgregarProducto.UseVisualStyleBackColor = true;
            this.BtnAgregarProducto.Click += new System.EventHandler(this.BtnAgregarProducto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Venta N°";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // IdVentaTexto
            // 
            this.IdVentaTexto.AutoSize = true;
            this.IdVentaTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdVentaTexto.Location = new System.Drawing.Point(105, 22);
            this.IdVentaTexto.Name = "IdVentaTexto";
            this.IdVentaTexto.Size = new System.Drawing.Size(18, 20);
            this.IdVentaTexto.TabIndex = 8;
            this.IdVentaTexto.Text = "0";
            this.IdVentaTexto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.IdVentaTexto.Click += new System.EventHandler(this.IdVentaTexto_Click);
            // 
            // ListaClientesNombres
            // 
            this.ListaClientesNombres.FormattingEnabled = true;
            this.ListaClientesNombres.Location = new System.Drawing.Point(27, 150);
            this.ListaClientesNombres.Name = "ListaClientesNombres";
            this.ListaClientesNombres.Size = new System.Drawing.Size(121, 24);
            this.ListaClientesNombres.TabIndex = 9;
            this.ListaClientesNombres.SelectedIndexChanged += new System.EventHandler(this.ListaClientesNombres_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Agrega tus productos:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnAtenderCliente
            // 
            this.BtnAtenderCliente.Location = new System.Drawing.Point(27, 180);
            this.BtnAtenderCliente.Name = "BtnAtenderCliente";
            this.BtnAtenderCliente.Size = new System.Drawing.Size(140, 31);
            this.BtnAtenderCliente.TabIndex = 12;
            this.BtnAtenderCliente.Text = "Atender Cliente";
            this.BtnAtenderCliente.UseVisualStyleBackColor = true;
            this.BtnAtenderCliente.Click += new System.EventHandler(this.BtnAtenderCliente_Click);
            // 
            // BtnFinalizarAtencion
            // 
            this.BtnFinalizarAtencion.Location = new System.Drawing.Point(173, 180);
            this.BtnFinalizarAtencion.Name = "BtnFinalizarAtencion";
            this.BtnFinalizarAtencion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnFinalizarAtencion.Size = new System.Drawing.Size(140, 31);
            this.BtnFinalizarAtencion.TabIndex = 13;
            this.BtnFinalizarAtencion.Text = "Finalizar Atención";
            this.BtnFinalizarAtencion.UseVisualStyleBackColor = true;
            this.BtnFinalizarAtencion.Click += new System.EventHandler(this.BtnFinalizarAtencion_Click);
            // 
            // dataGridVentas
            // 
            this.dataGridVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVentas.Location = new System.Drawing.Point(337, 119);
            this.dataGridVentas.Name = "dataGridVentas";
            this.dataGridVentas.RowHeadersWidth = 51;
            this.dataGridVentas.RowTemplate.Height = 24;
            this.dataGridVentas.Size = new System.Drawing.Size(285, 343);
            this.dataGridVentas.TabIndex = 14;
            this.dataGridVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVentas_CellContentClick);
            // 
            // texto1
            // 
            this.texto1.AutoSize = true;
            this.texto1.Location = new System.Drawing.Point(24, 119);
            this.texto1.Name = "texto1";
            this.texto1.Size = new System.Drawing.Size(191, 16);
            this.texto1.TabIndex = 15;
            this.texto1.Text = "Selecciona el cliente a atender";
            // 
            // dataGridVentasProductos
            // 
            this.dataGridVentasProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVentasProductos.Location = new System.Drawing.Point(653, 122);
            this.dataGridVentasProductos.Name = "dataGridVentasProductos";
            this.dataGridVentasProductos.RowHeadersWidth = 51;
            this.dataGridVentasProductos.RowTemplate.Height = 24;
            this.dataGridVentasProductos.Size = new System.Drawing.Size(416, 340);
            this.dataGridVentasProductos.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ventas a Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(774, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ventas de Productos";
            // 
            // CantidadVenderTexto
            // 
            this.CantidadVenderTexto.Location = new System.Drawing.Point(27, 382);
            this.CantidadVenderTexto.Name = "CantidadVenderTexto";
            this.CantidadVenderTexto.Size = new System.Drawing.Size(76, 22);
            this.CantidadVenderTexto.TabIndex = 19;
            // 
            // TextoIngreseCantidad
            // 
            this.TextoIngreseCantidad.AutoSize = true;
            this.TextoIngreseCantidad.Location = new System.Drawing.Point(24, 363);
            this.TextoIngreseCantidad.Name = "TextoIngreseCantidad";
            this.TextoIngreseCantidad.Size = new System.Drawing.Size(121, 16);
            this.TextoIngreseCantidad.TabIndex = 20;
            this.TextoIngreseCantidad.Text = "Ingrese la cantidad";
            this.TextoIngreseCantidad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // IngresarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 485);
            this.Controls.Add(this.TextoIngreseCantidad);
            this.Controls.Add(this.CantidadVenderTexto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridVentasProductos);
            this.Controls.Add(this.texto1);
            this.Controls.Add(this.dataGridVentas);
            this.Controls.Add(this.BtnFinalizarAtencion);
            this.Controls.Add(this.BtnAtenderCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ListaClientesNombres);
            this.Controls.Add(this.IdVentaTexto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnAgregarProducto);
            this.Controls.Add(this.TextoIngreseProducto);
            this.Controls.Add(this.NombreProductoTexto);
            this.Controls.Add(this.TituloVentaCliente);
            this.Name = "IngresarVenta";
            this.Text = "IngresarVenta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVentasProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TituloVentaCliente;
        private System.Windows.Forms.Label TextoIngreseProducto;
        private System.Windows.Forms.TextBox NombreProductoTexto;
        private System.Windows.Forms.Button BtnAgregarProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label IdVentaTexto;
        private System.Windows.Forms.ComboBox ListaClientesNombres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnAtenderCliente;
        private System.Windows.Forms.Button BtnFinalizarAtencion;
        private System.Windows.Forms.DataGridView dataGridVentas;
        private System.Windows.Forms.Label texto1;
        private System.Windows.Forms.DataGridView dataGridVentasProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CantidadVenderTexto;
        private System.Windows.Forms.Label TextoIngreseCantidad;
    }
}
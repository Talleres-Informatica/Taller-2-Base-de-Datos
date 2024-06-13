namespace Taller_2___base_datos
{
    partial class ModificarProducto
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
            this.ProductoText = new System.Windows.Forms.Label();
            this.StockActualText = new System.Windows.Forms.TextBox();
            this.StockNuevoText = new System.Windows.Forms.TextBox();
            this.PrecioActualText = new System.Windows.Forms.TextBox();
            this.PrecioNuevoText = new System.Windows.Forms.TextBox();
            this.PrecioText = new System.Windows.Forms.Label();
            this.BtnActualizarStock = new System.Windows.Forms.Button();
            this.StockText = new System.Windows.Forms.Label();
            this.BtnActualizarPrecio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ListaProductos = new System.Windows.Forms.ComboBox();
            this.nuevoStock = new System.Windows.Forms.Label();
            this.NuevoPrecio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProductoText
            // 
            this.ProductoText.AutoSize = true;
            this.ProductoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductoText.Location = new System.Drawing.Point(52, 126);
            this.ProductoText.Name = "ProductoText";
            this.ProductoText.Size = new System.Drawing.Size(90, 25);
            this.ProductoText.TabIndex = 1;
            this.ProductoText.Text = "Producto";
            // 
            // StockActualText
            // 
            this.StockActualText.Location = new System.Drawing.Point(229, 226);
            this.StockActualText.Name = "StockActualText";
            this.StockActualText.Size = new System.Drawing.Size(118, 22);
            this.StockActualText.TabIndex = 2;
            // 
            // StockNuevoText
            // 
            this.StockNuevoText.Location = new System.Drawing.Point(452, 225);
            this.StockNuevoText.Name = "StockNuevoText";
            this.StockNuevoText.Size = new System.Drawing.Size(118, 22);
            this.StockNuevoText.TabIndex = 3;
            // 
            // PrecioActualText
            // 
            this.PrecioActualText.Location = new System.Drawing.Point(229, 330);
            this.PrecioActualText.Name = "PrecioActualText";
            this.PrecioActualText.Size = new System.Drawing.Size(118, 22);
            this.PrecioActualText.TabIndex = 4;
            // 
            // PrecioNuevoText
            // 
            this.PrecioNuevoText.Location = new System.Drawing.Point(452, 330);
            this.PrecioNuevoText.Name = "PrecioNuevoText";
            this.PrecioNuevoText.Size = new System.Drawing.Size(118, 22);
            this.PrecioNuevoText.TabIndex = 5;
            // 
            // PrecioText
            // 
            this.PrecioText.AutoSize = true;
            this.PrecioText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioText.Location = new System.Drawing.Point(47, 330);
            this.PrecioText.Name = "PrecioText";
            this.PrecioText.Size = new System.Drawing.Size(67, 25);
            this.PrecioText.TabIndex = 7;
            this.PrecioText.Text = "Precio";
            // 
            // BtnActualizarStock
            // 
            this.BtnActualizarStock.Location = new System.Drawing.Point(646, 225);
            this.BtnActualizarStock.Name = "BtnActualizarStock";
            this.BtnActualizarStock.Size = new System.Drawing.Size(120, 23);
            this.BtnActualizarStock.TabIndex = 8;
            this.BtnActualizarStock.Text = "Actualiza Stock";
            this.BtnActualizarStock.UseVisualStyleBackColor = true;
            this.BtnActualizarStock.Click += new System.EventHandler(this.BtnActualizarStock_Click);
            // 
            // StockText
            // 
            this.StockText.AutoSize = true;
            this.StockText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockText.Location = new System.Drawing.Point(52, 221);
            this.StockText.Name = "StockText";
            this.StockText.Size = new System.Drawing.Size(62, 25);
            this.StockText.TabIndex = 9;
            this.StockText.Text = "Stock";
            // 
            // BtnActualizarPrecio
            // 
            this.BtnActualizarPrecio.Location = new System.Drawing.Point(646, 332);
            this.BtnActualizarPrecio.Name = "BtnActualizarPrecio";
            this.BtnActualizarPrecio.Size = new System.Drawing.Size(120, 23);
            this.BtnActualizarPrecio.TabIndex = 10;
            this.BtnActualizarPrecio.Text = "Actualizar Precio";
            this.BtnActualizarPrecio.UseVisualStyleBackColor = true;
            this.BtnActualizarPrecio.Click += new System.EventHandler(this.BtnActualizarPrecio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Actualiza Producto";
            // 
            // ListaProductos
            // 
            this.ListaProductos.FormattingEnabled = true;
            this.ListaProductos.Location = new System.Drawing.Point(34, 154);
            this.ListaProductos.Name = "ListaProductos";
            this.ListaProductos.Size = new System.Drawing.Size(121, 24);
            this.ListaProductos.TabIndex = 12;
            this.ListaProductos.SelectedIndexChanged += new System.EventHandler(this.ListaProductos_SelectedIndexChanged);
            // 
            // nuevoStock
            // 
            this.nuevoStock.AutoSize = true;
            this.nuevoStock.Location = new System.Drawing.Point(467, 206);
            this.nuevoStock.Name = "nuevoStock";
            this.nuevoStock.Size = new System.Drawing.Size(84, 16);
            this.nuevoStock.TabIndex = 13;
            this.nuevoStock.Text = "Nuevo Stock";
            // 
            // NuevoPrecio
            // 
            this.NuevoPrecio.AutoSize = true;
            this.NuevoPrecio.Location = new System.Drawing.Point(467, 311);
            this.NuevoPrecio.Name = "NuevoPrecio";
            this.NuevoPrecio.Size = new System.Drawing.Size(88, 16);
            this.NuevoPrecio.TabIndex = 14;
            this.NuevoPrecio.Text = "Nuevo precio";
            // 
            // ModificarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NuevoPrecio);
            this.Controls.Add(this.nuevoStock);
            this.Controls.Add(this.ListaProductos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnActualizarPrecio);
            this.Controls.Add(this.StockText);
            this.Controls.Add(this.BtnActualizarStock);
            this.Controls.Add(this.PrecioText);
            this.Controls.Add(this.PrecioNuevoText);
            this.Controls.Add(this.PrecioActualText);
            this.Controls.Add(this.StockNuevoText);
            this.Controls.Add(this.StockActualText);
            this.Controls.Add(this.ProductoText);
            this.Name = "ModificarProducto";
            this.Text = "ModificarProducto";
            this.Load += new System.EventHandler(this.ModificarProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ProductoText;
        private System.Windows.Forms.TextBox StockActualText;
        private System.Windows.Forms.TextBox StockNuevoText;
        private System.Windows.Forms.TextBox PrecioActualText;
        private System.Windows.Forms.TextBox PrecioNuevoText;
        private System.Windows.Forms.Label PrecioText;
        private System.Windows.Forms.Button BtnActualizarStock;
        private System.Windows.Forms.Label StockText;
        private System.Windows.Forms.Button BtnActualizarPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ListaProductos;
        private System.Windows.Forms.Label nuevoStock;
        private System.Windows.Forms.Label NuevoPrecio;
    }
}
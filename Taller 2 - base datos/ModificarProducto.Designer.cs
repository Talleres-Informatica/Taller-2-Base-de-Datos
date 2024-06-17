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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarProducto));
            this.ProductoText = new System.Windows.Forms.Label();
            this.StockNuevoText = new System.Windows.Forms.TextBox();
            this.BtnActualizarStock = new System.Windows.Forms.Button();
            this.StockText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ListaProductos = new System.Windows.Forms.ComboBox();
            this.nuevoStock = new System.Windows.Forms.Label();
            this.StockActualText = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductoText
            // 
            this.ProductoText.AutoSize = true;
            this.ProductoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductoText.Location = new System.Drawing.Point(30, 237);
            this.ProductoText.Name = "ProductoText";
            this.ProductoText.Size = new System.Drawing.Size(90, 25);
            this.ProductoText.TabIndex = 1;
            this.ProductoText.Text = "Producto";
            // 
            // StockNuevoText
            // 
            this.StockNuevoText.Location = new System.Drawing.Point(407, 259);
            this.StockNuevoText.Name = "StockNuevoText";
            this.StockNuevoText.Size = new System.Drawing.Size(118, 22);
            this.StockNuevoText.TabIndex = 3;
            // 
            // BtnActualizarStock
            // 
            this.BtnActualizarStock.Location = new System.Drawing.Point(548, 249);
            this.BtnActualizarStock.Name = "BtnActualizarStock";
            this.BtnActualizarStock.Size = new System.Drawing.Size(120, 32);
            this.BtnActualizarStock.TabIndex = 8;
            this.BtnActualizarStock.Text = "Actualizar";
            this.BtnActualizarStock.UseVisualStyleBackColor = true;
            this.BtnActualizarStock.Click += new System.EventHandler(this.BtnActualizarStock_Click);
            // 
            // StockText
            // 
            this.StockText.AutoSize = true;
            this.StockText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockText.Location = new System.Drawing.Point(190, 255);
            this.StockText.Name = "StockText";
            this.StockText.Size = new System.Drawing.Size(62, 25);
            this.StockText.TabIndex = 9;
            this.StockText.Text = "Stock";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Agregar stock a un producto";
            // 
            // ListaProductos
            // 
            this.ListaProductos.FormattingEnabled = true;
            this.ListaProductos.Location = new System.Drawing.Point(12, 265);
            this.ListaProductos.Name = "ListaProductos";
            this.ListaProductos.Size = new System.Drawing.Size(121, 24);
            this.ListaProductos.TabIndex = 12;
            this.ListaProductos.SelectedIndexChanged += new System.EventHandler(this.ListaProductos_SelectedIndexChanged);
            // 
            // nuevoStock
            // 
            this.nuevoStock.AutoSize = true;
            this.nuevoStock.Location = new System.Drawing.Point(404, 240);
            this.nuevoStock.Name = "nuevoStock";
            this.nuevoStock.Size = new System.Drawing.Size(123, 16);
            this.nuevoStock.TabIndex = 13;
            this.nuevoStock.Text = "Cantidad a agregar";
            // 
            // StockActualText
            // 
            this.StockActualText.AutoSize = true;
            this.StockActualText.Location = new System.Drawing.Point(271, 263);
            this.StockActualText.Name = "StockActualText";
            this.StockActualText.Size = new System.Drawing.Size(0, 16);
            this.StockActualText.TabIndex = 15;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(12, 128);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(122, 93);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // ModificarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.StockActualText);
            this.Controls.Add(this.nuevoStock);
            this.Controls.Add(this.ListaProductos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StockText);
            this.Controls.Add(this.BtnActualizarStock);
            this.Controls.Add(this.StockNuevoText);
            this.Controls.Add(this.ProductoText);
            this.Name = "ModificarProducto";
            this.Text = "ModificarProducto";
            this.Load += new System.EventHandler(this.ModificarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ProductoText;
        private System.Windows.Forms.TextBox StockNuevoText;
        private System.Windows.Forms.Button BtnActualizarStock;
        private System.Windows.Forms.Label StockText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ListaProductos;
        private System.Windows.Forms.Label nuevoStock;
        private System.Windows.Forms.Label StockActualText;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
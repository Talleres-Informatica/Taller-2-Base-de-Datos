namespace Taller_2___base_datos
{
    partial class PrecioProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrecioProducto));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.PrecioActualText = new System.Windows.Forms.Label();
            this.NuevoPrecio = new System.Windows.Forms.Label();
            this.ListaProductos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnActualizarPrecio = new System.Windows.Forms.Button();
            this.PrecioText = new System.Windows.Forms.Label();
            this.PrecioNuevoText = new System.Windows.Forms.TextBox();
            this.ProductoText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(25, 123);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(122, 93);
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            // 
            // PrecioActualText
            // 
            this.PrecioActualText.AutoSize = true;
            this.PrecioActualText.Location = new System.Drawing.Point(284, 263);
            this.PrecioActualText.Name = "PrecioActualText";
            this.PrecioActualText.Size = new System.Drawing.Size(0, 16);
            this.PrecioActualText.TabIndex = 30;
            // 
            // NuevoPrecio
            // 
            this.NuevoPrecio.AutoSize = true;
            this.NuevoPrecio.Location = new System.Drawing.Point(435, 241);
            this.NuevoPrecio.Name = "NuevoPrecio";
            this.NuevoPrecio.Size = new System.Drawing.Size(88, 16);
            this.NuevoPrecio.TabIndex = 28;
            this.NuevoPrecio.Text = "Nuevo precio";
            // 
            // ListaProductos
            // 
            this.ListaProductos.FormattingEnabled = true;
            this.ListaProductos.Location = new System.Drawing.Point(25, 260);
            this.ListaProductos.Name = "ListaProductos";
            this.ListaProductos.Size = new System.Drawing.Size(121, 24);
            this.ListaProductos.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 26);
            this.label1.TabIndex = 25;
            this.label1.Text = "Cambiar precio de un producto";
            // 
            // BtnActualizarPrecio
            // 
            this.BtnActualizarPrecio.Location = new System.Drawing.Point(561, 255);
            this.BtnActualizarPrecio.Name = "BtnActualizarPrecio";
            this.BtnActualizarPrecio.Size = new System.Drawing.Size(120, 32);
            this.BtnActualizarPrecio.TabIndex = 24;
            this.BtnActualizarPrecio.Text = "Actualizar";
            this.BtnActualizarPrecio.UseVisualStyleBackColor = true;
            // 
            // PrecioText
            // 
            this.PrecioText.AutoSize = true;
            this.PrecioText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioText.Location = new System.Drawing.Point(198, 256);
            this.PrecioText.Name = "PrecioText";
            this.PrecioText.Size = new System.Drawing.Size(67, 25);
            this.PrecioText.TabIndex = 21;
            this.PrecioText.Text = "Precio";
            // 
            // PrecioNuevoText
            // 
            this.PrecioNuevoText.Location = new System.Drawing.Point(420, 260);
            this.PrecioNuevoText.Name = "PrecioNuevoText";
            this.PrecioNuevoText.Size = new System.Drawing.Size(118, 22);
            this.PrecioNuevoText.TabIndex = 20;
            // 
            // ProductoText
            // 
            this.ProductoText.AutoSize = true;
            this.ProductoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductoText.Location = new System.Drawing.Point(43, 232);
            this.ProductoText.Name = "ProductoText";
            this.ProductoText.Size = new System.Drawing.Size(90, 25);
            this.ProductoText.TabIndex = 18;
            this.ProductoText.Text = "Producto";
            // 
            // PrecioProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.PrecioActualText);
            this.Controls.Add(this.NuevoPrecio);
            this.Controls.Add(this.ListaProductos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnActualizarPrecio);
            this.Controls.Add(this.PrecioText);
            this.Controls.Add(this.PrecioNuevoText);
            this.Controls.Add(this.ProductoText);
            this.Name = "PrecioProducto";
            this.Text = "PrecioProducto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label PrecioActualText;
        private System.Windows.Forms.Label NuevoPrecio;
        private System.Windows.Forms.ComboBox ListaProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnActualizarPrecio;
        private System.Windows.Forms.Label PrecioText;
        private System.Windows.Forms.TextBox PrecioNuevoText;
        private System.Windows.Forms.Label ProductoText;
    }
}
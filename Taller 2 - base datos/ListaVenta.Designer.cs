namespace Taller_2___base_datos
{
    partial class ListaVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaVenta));
            this.dataLista = new System.Windows.Forms.DataGridView();
            this.DetalleVenta = new System.Windows.Forms.Label();
            this.CantVendido1anio = new System.Windows.Forms.Label();
            this.cantVendidos = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLista
            // 
            this.dataLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLista.Location = new System.Drawing.Point(12, 88);
            this.dataLista.Name = "dataLista";
            this.dataLista.RowHeadersWidth = 51;
            this.dataLista.RowTemplate.Height = 24;
            this.dataLista.Size = new System.Drawing.Size(776, 406);
            this.dataLista.TabIndex = 1;
            // 
            // DetalleVenta
            // 
            this.DetalleVenta.AutoSize = true;
            this.DetalleVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetalleVenta.Location = new System.Drawing.Point(173, 33);
            this.DetalleVenta.Name = "DetalleVenta";
            this.DetalleVenta.Size = new System.Drawing.Size(436, 26);
            this.DetalleVenta.TabIndex = 3;
            this.DetalleVenta.Text = "Detalles de las ventas en los últimos 2 años";
            // 
            // CantVendido1anio
            // 
            this.CantVendido1anio.AutoSize = true;
            this.CantVendido1anio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantVendido1anio.Location = new System.Drawing.Point(12, 517);
            this.CantVendido1anio.Name = "CantVendido1anio";
            this.CantVendido1anio.Size = new System.Drawing.Size(384, 25);
            this.CantVendido1anio.TabIndex = 4;
            this.CantVendido1anio.Text = "Cantidad de productos vendidos en el año:";
            // 
            // cantVendidos
            // 
            this.cantVendidos.AutoSize = true;
            this.cantVendidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantVendidos.Location = new System.Drawing.Point(474, 517);
            this.cantVendidos.Name = "cantVendidos";
            this.cantVendidos.Size = new System.Drawing.Size(0, 25);
            this.cantVendidos.TabIndex = 6;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(12, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(72, 68);
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // ListaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.cantVendidos);
            this.Controls.Add(this.CantVendido1anio);
            this.Controls.Add(this.DetalleVenta);
            this.Controls.Add(this.dataLista);
            this.Name = "ListaVenta";
            this.Text = "ListaVenta";
            this.Load += new System.EventHandler(this.ListaVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataLista;
        private System.Windows.Forms.Label DetalleVenta;
        private System.Windows.Forms.Label CantVendido1anio;
        private System.Windows.Forms.Label cantVendidos;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}
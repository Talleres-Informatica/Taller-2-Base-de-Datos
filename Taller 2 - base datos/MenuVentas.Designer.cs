namespace Taller_2___base_datos
{
    partial class MenuVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuVentas));
            this.ListaVentaText = new System.Windows.Forms.Label();
            this.RealizarVentaText = new System.Windows.Forms.Label();
            this.BtnRealizarVenta = new System.Windows.Forms.Button();
            this.BtnListaVenta = new System.Windows.Forms.Button();
            this.MenuVenta = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.BtnVentasCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaVentaText
            // 
            this.ListaVentaText.AutoSize = true;
            this.ListaVentaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaVentaText.Location = new System.Drawing.Point(40, 249);
            this.ListaVentaText.Name = "ListaVentaText";
            this.ListaVentaText.Size = new System.Drawing.Size(143, 25);
            this.ListaVentaText.TabIndex = 0;
            this.ListaVentaText.Text = "Lista de ventas";
            // 
            // RealizarVentaText
            // 
            this.RealizarVentaText.AutoSize = true;
            this.RealizarVentaText.BackColor = System.Drawing.Color.Transparent;
            this.RealizarVentaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RealizarVentaText.Location = new System.Drawing.Point(246, 248);
            this.RealizarVentaText.Name = "RealizarVentaText";
            this.RealizarVentaText.Size = new System.Drawing.Size(173, 25);
            this.RealizarVentaText.TabIndex = 1;
            this.RealizarVentaText.Text = "Realizar una venta";
            // 
            // BtnRealizarVenta
            // 
            this.BtnRealizarVenta.Location = new System.Drawing.Point(271, 293);
            this.BtnRealizarVenta.Name = "BtnRealizarVenta";
            this.BtnRealizarVenta.Size = new System.Drawing.Size(120, 53);
            this.BtnRealizarVenta.TabIndex = 2;
            this.BtnRealizarVenta.Text = "Ver";
            this.BtnRealizarVenta.UseVisualStyleBackColor = true;
            this.BtnRealizarVenta.Click += new System.EventHandler(this.BtnRealizarVenta_Click);
            // 
            // BtnListaVenta
            // 
            this.BtnListaVenta.Location = new System.Drawing.Point(54, 293);
            this.BtnListaVenta.Name = "BtnListaVenta";
            this.BtnListaVenta.Size = new System.Drawing.Size(120, 53);
            this.BtnListaVenta.TabIndex = 3;
            this.BtnListaVenta.Text = "Ver";
            this.BtnListaVenta.UseVisualStyleBackColor = true;
            this.BtnListaVenta.Click += new System.EventHandler(this.BtnListaVenta_Click);
            // 
            // MenuVenta
            // 
            this.MenuVenta.AutoSize = true;
            this.MenuVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuVenta.Location = new System.Drawing.Point(255, 42);
            this.MenuVenta.Name = "MenuVenta";
            this.MenuVenta.Size = new System.Drawing.Size(170, 26);
            this.MenuVenta.TabIndex = 4;
            this.MenuVenta.Text = "Menu de Ventas";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(291, 89);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 93);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // BtnVentasCliente
            // 
            this.BtnVentasCliente.Location = new System.Drawing.Point(493, 293);
            this.BtnVentasCliente.Name = "BtnVentasCliente";
            this.BtnVentasCliente.Size = new System.Drawing.Size(120, 53);
            this.BtnVentasCliente.TabIndex = 13;
            this.BtnVentasCliente.Text = "Ver";
            this.BtnVentasCliente.UseVisualStyleBackColor = true;
            this.BtnVentasCliente.Click += new System.EventHandler(this.BtnVentasCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(469, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ventas de un cliente";
            // 
            // MenuVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(696, 423);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnVentasCliente);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.MenuVenta);
            this.Controls.Add(this.BtnListaVenta);
            this.Controls.Add(this.BtnRealizarVenta);
            this.Controls.Add(this.RealizarVentaText);
            this.Controls.Add(this.ListaVentaText);
            this.Name = "MenuVentas";
            this.Text = "Menu de ventas";
            this.Load += new System.EventHandler(this.RealizarVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ListaVentaText;
        private System.Windows.Forms.Label RealizarVentaText;
        private System.Windows.Forms.Button BtnRealizarVenta;
        private System.Windows.Forms.Button BtnListaVenta;
        private System.Windows.Forms.Label MenuVenta;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button BtnVentasCliente;
        private System.Windows.Forms.Label label1;
    }
}
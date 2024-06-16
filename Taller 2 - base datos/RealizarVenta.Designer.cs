namespace Taller_2___base_datos
{
    partial class RealizarVenta
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
            this.ListaVentaText = new System.Windows.Forms.Label();
            this.RealizarVentaText = new System.Windows.Forms.Label();
            this.BtnRealizarVenta = new System.Windows.Forms.Button();
            this.BtnListaVenta = new System.Windows.Forms.Button();
            this.MenuVenta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListaVentaText
            // 
            this.ListaVentaText.AutoSize = true;
            this.ListaVentaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaVentaText.Location = new System.Drawing.Point(582, 170);
            this.ListaVentaText.Name = "ListaVentaText";
            this.ListaVentaText.Size = new System.Drawing.Size(120, 25);
            this.ListaVentaText.TabIndex = 0;
            this.ListaVentaText.Text = "Lista Ventas";
            // 
            // RealizarVentaText
            // 
            this.RealizarVentaText.AutoSize = true;
            this.RealizarVentaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RealizarVentaText.Location = new System.Drawing.Point(64, 170);
            this.RealizarVentaText.Name = "RealizarVentaText";
            this.RealizarVentaText.Size = new System.Drawing.Size(139, 25);
            this.RealizarVentaText.TabIndex = 1;
            this.RealizarVentaText.Text = "Realizar Venta";
            // 
            // BtnRealizarVenta
            // 
            this.BtnRealizarVenta.Location = new System.Drawing.Point(93, 218);
            this.BtnRealizarVenta.Name = "BtnRealizarVenta";
            this.BtnRealizarVenta.Size = new System.Drawing.Size(75, 23);
            this.BtnRealizarVenta.TabIndex = 2;
            this.BtnRealizarVenta.Text = "Ver";
            this.BtnRealizarVenta.UseVisualStyleBackColor = true;
            this.BtnRealizarVenta.Click += new System.EventHandler(this.BtnRealizarVenta_Click);
            // 
            // BtnListaVenta
            // 
            this.BtnListaVenta.Location = new System.Drawing.Point(604, 219);
            this.BtnListaVenta.Name = "BtnListaVenta";
            this.BtnListaVenta.Size = new System.Drawing.Size(75, 23);
            this.BtnListaVenta.TabIndex = 3;
            this.BtnListaVenta.Text = "Ver";
            this.BtnListaVenta.UseVisualStyleBackColor = true;
            this.BtnListaVenta.Click += new System.EventHandler(this.BtnListaVenta_Click);
            // 
            // MenuVenta
            // 
            this.MenuVenta.AutoSize = true;
            this.MenuVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuVenta.Location = new System.Drawing.Point(329, 57);
            this.MenuVenta.Name = "MenuVenta";
            this.MenuVenta.Size = new System.Drawing.Size(129, 26);
            this.MenuVenta.TabIndex = 4;
            this.MenuVenta.Text = "Menu Venta";
            // 
            // RealizarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MenuVenta);
            this.Controls.Add(this.BtnListaVenta);
            this.Controls.Add(this.BtnRealizarVenta);
            this.Controls.Add(this.RealizarVentaText);
            this.Controls.Add(this.ListaVentaText);
            this.Name = "RealizarVenta";
            this.Text = "RealizarVenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ListaVentaText;
        private System.Windows.Forms.Label RealizarVentaText;
        private System.Windows.Forms.Button BtnRealizarVenta;
        private System.Windows.Forms.Button BtnListaVenta;
        private System.Windows.Forms.Label MenuVenta;
    }
}
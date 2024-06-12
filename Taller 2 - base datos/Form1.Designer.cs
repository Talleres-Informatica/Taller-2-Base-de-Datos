namespace Taller_2___base_datos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnVerProyecto = new System.Windows.Forms.Button();
            this.BtnVerCliente = new System.Windows.Forms.Button();
            this.ClienteText = new System.Windows.Forms.Label();
            this.NombreLocal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnVerVenta = new System.Windows.Forms.Button();
            this.ProductoText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnVerProyecto
            // 
            this.BtnVerProyecto.Location = new System.Drawing.Point(303, 226);
            this.BtnVerProyecto.Name = "BtnVerProyecto";
            this.BtnVerProyecto.Size = new System.Drawing.Size(137, 45);
            this.BtnVerProyecto.TabIndex = 0;
            this.BtnVerProyecto.Text = "Ver";
            this.BtnVerProyecto.UseVisualStyleBackColor = true;
            this.BtnVerProyecto.Click += new System.EventHandler(this.BtnVerProyecto_Click);
            // 
            // BtnVerCliente
            // 
            this.BtnVerCliente.Location = new System.Drawing.Point(37, 226);
            this.BtnVerCliente.Name = "BtnVerCliente";
            this.BtnVerCliente.Size = new System.Drawing.Size(137, 45);
            this.BtnVerCliente.TabIndex = 1;
            this.BtnVerCliente.Text = "Ver";
            this.BtnVerCliente.UseVisualStyleBackColor = true;
            this.BtnVerCliente.Click += new System.EventHandler(this.BtnVerCliente_Click);
            // 
            // ClienteText
            // 
            this.ClienteText.AutoSize = true;
            this.ClienteText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteText.Location = new System.Drawing.Point(67, 181);
            this.ClienteText.Name = "ClienteText";
            this.ClienteText.Size = new System.Drawing.Size(80, 26);
            this.ClienteText.TabIndex = 3;
            this.ClienteText.Text = "Cliente";
            // 
            // NombreLocal
            // 
            this.NombreLocal.AutoSize = true;
            this.NombreLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreLocal.Location = new System.Drawing.Point(297, 48);
            this.NombreLocal.Name = "NombreLocal";
            this.NombreLocal.Size = new System.Drawing.Size(198, 31);
            this.NombreLocal.TabIndex = 4;
            this.NombreLocal.Text = "Vitoko’s Coffee";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(620, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Venta";
            // 
            // BtnVerVenta
            // 
            this.BtnVerVenta.Location = new System.Drawing.Point(586, 226);
            this.BtnVerVenta.Name = "BtnVerVenta";
            this.BtnVerVenta.Size = new System.Drawing.Size(137, 45);
            this.BtnVerVenta.TabIndex = 6;
            this.BtnVerVenta.Text = "Ver";
            this.BtnVerVenta.UseVisualStyleBackColor = true;
            this.BtnVerVenta.Click += new System.EventHandler(this.BtnVerVenta_Click);
            // 
            // ProductoText
            // 
            this.ProductoText.AutoSize = true;
            this.ProductoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductoText.Location = new System.Drawing.Point(313, 181);
            this.ProductoText.Name = "ProductoText";
            this.ProductoText.Size = new System.Drawing.Size(116, 26);
            this.ProductoText.TabIndex = 7;
            this.ProductoText.Text = " Productos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProductoText);
            this.Controls.Add(this.BtnVerVenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NombreLocal);
            this.Controls.Add(this.ClienteText);
            this.Controls.Add(this.BtnVerCliente);
            this.Controls.Add(this.BtnVerProyecto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnVerProyecto;
        private System.Windows.Forms.Button BtnVerCliente;
        private System.Windows.Forms.Label ClienteText;
        private System.Windows.Forms.Label NombreLocal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnVerVenta;
        private System.Windows.Forms.Label ProductoText;
    }
}


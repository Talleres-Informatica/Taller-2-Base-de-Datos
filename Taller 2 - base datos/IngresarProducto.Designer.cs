namespace Taller_2___base_datos
{
    partial class IngresarProducto
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
            this.NombreProductoText = new System.Windows.Forms.Label();
            this.StockProductoText = new System.Windows.Forms.Label();
            this.PrecioProductoText = new System.Windows.Forms.Label();
            this.PrecioProductoInput = new System.Windows.Forms.TextBox();
            this.StockProductoInput = new System.Windows.Forms.TextBox();
            this.NombreProductoInput = new System.Windows.Forms.TextBox();
            this.BtnIngresarProducto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NombreProductoText
            // 
            this.NombreProductoText.AutoSize = true;
            this.NombreProductoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreProductoText.Location = new System.Drawing.Point(49, 117);
            this.NombreProductoText.Name = "NombreProductoText";
            this.NombreProductoText.Size = new System.Drawing.Size(90, 26);
            this.NombreProductoText.TabIndex = 0;
            this.NombreProductoText.Text = "Nombre";
            // 
            // StockProductoText
            // 
            this.StockProductoText.AutoSize = true;
            this.StockProductoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockProductoText.Location = new System.Drawing.Point(329, 117);
            this.StockProductoText.Name = "StockProductoText";
            this.StockProductoText.Size = new System.Drawing.Size(67, 26);
            this.StockProductoText.TabIndex = 1;
            this.StockProductoText.Text = "Stock";
            // 
            // PrecioProductoText
            // 
            this.PrecioProductoText.AutoSize = true;
            this.PrecioProductoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioProductoText.Location = new System.Drawing.Point(596, 117);
            this.PrecioProductoText.Name = "PrecioProductoText";
            this.PrecioProductoText.Size = new System.Drawing.Size(74, 26);
            this.PrecioProductoText.TabIndex = 2;
            this.PrecioProductoText.Text = "Precio";
            // 
            // PrecioProductoInput
            // 
            this.PrecioProductoInput.Location = new System.Drawing.Point(562, 180);
            this.PrecioProductoInput.Name = "PrecioProductoInput";
            this.PrecioProductoInput.Size = new System.Drawing.Size(147, 22);
            this.PrecioProductoInput.TabIndex = 3;
            this.PrecioProductoInput.TextChanged += new System.EventHandler(this.PrecioProductoInput_TextChanged);
            // 
            // StockProductoInput
            // 
            this.StockProductoInput.Location = new System.Drawing.Point(292, 180);
            this.StockProductoInput.Name = "StockProductoInput";
            this.StockProductoInput.Size = new System.Drawing.Size(147, 22);
            this.StockProductoInput.TabIndex = 4;
            this.StockProductoInput.TextChanged += new System.EventHandler(this.StockProductoInput_TextChanged);
            // 
            // NombreProductoInput
            // 
            this.NombreProductoInput.Location = new System.Drawing.Point(22, 180);
            this.NombreProductoInput.Name = "NombreProductoInput";
            this.NombreProductoInput.Size = new System.Drawing.Size(147, 22);
            this.NombreProductoInput.TabIndex = 5;
            this.NombreProductoInput.TextChanged += new System.EventHandler(this.NombreProductoInput_TextChanged);
            // 
            // BtnIngresarProducto
            // 
            this.BtnIngresarProducto.Location = new System.Drawing.Point(274, 316);
            this.BtnIngresarProducto.Name = "BtnIngresarProducto";
            this.BtnIngresarProducto.Size = new System.Drawing.Size(165, 56);
            this.BtnIngresarProducto.TabIndex = 6;
            this.BtnIngresarProducto.Text = "Ingresar";
            this.BtnIngresarProducto.UseVisualStyleBackColor = true;
            this.BtnIngresarProducto.Click += new System.EventHandler(this.BtnIngresarProducto_Click);
            // 
            // IngresarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnIngresarProducto);
            this.Controls.Add(this.NombreProductoInput);
            this.Controls.Add(this.StockProductoInput);
            this.Controls.Add(this.PrecioProductoInput);
            this.Controls.Add(this.PrecioProductoText);
            this.Controls.Add(this.StockProductoText);
            this.Controls.Add(this.NombreProductoText);
            this.Name = "IngresarProducto";
            this.Text = "IngresarProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NombreProductoText;
        private System.Windows.Forms.Label StockProductoText;
        private System.Windows.Forms.Label PrecioProductoText;
        private System.Windows.Forms.TextBox PrecioProductoInput;
        private System.Windows.Forms.TextBox StockProductoInput;
        private System.Windows.Forms.TextBox NombreProductoInput;
        private System.Windows.Forms.Button BtnIngresarProducto;
    }
}
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngresarProducto));
            this.NombreProductoText = new System.Windows.Forms.Label();
            this.StockProductoText = new System.Windows.Forms.Label();
            this.PrecioProductoText = new System.Windows.Forms.Label();
            this.PrecioProductoInput = new System.Windows.Forms.TextBox();
            this.StockProductoInput = new System.Windows.Forms.TextBox();
            this.NombreProductoInput = new System.Windows.Forms.TextBox();
            this.BtnIngresarProducto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // NombreProductoText
            // 
            this.NombreProductoText.AutoSize = true;
            this.NombreProductoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreProductoText.Location = new System.Drawing.Point(111, 246);
            this.NombreProductoText.Name = "NombreProductoText";
            this.NombreProductoText.Size = new System.Drawing.Size(90, 26);
            this.NombreProductoText.TabIndex = 0;
            this.NombreProductoText.Text = "Nombre";
            // 
            // StockProductoText
            // 
            this.StockProductoText.AutoSize = true;
            this.StockProductoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockProductoText.Location = new System.Drawing.Point(317, 246);
            this.StockProductoText.Name = "StockProductoText";
            this.StockProductoText.Size = new System.Drawing.Size(67, 26);
            this.StockProductoText.TabIndex = 1;
            this.StockProductoText.Text = "Stock";
            // 
            // PrecioProductoText
            // 
            this.PrecioProductoText.AutoSize = true;
            this.PrecioProductoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioProductoText.Location = new System.Drawing.Point(517, 246);
            this.PrecioProductoText.Name = "PrecioProductoText";
            this.PrecioProductoText.Size = new System.Drawing.Size(74, 26);
            this.PrecioProductoText.TabIndex = 2;
            this.PrecioProductoText.Text = "Precio";
            // 
            // PrecioProductoInput
            // 
            this.PrecioProductoInput.Location = new System.Drawing.Point(483, 289);
            this.PrecioProductoInput.Name = "PrecioProductoInput";
            this.PrecioProductoInput.Size = new System.Drawing.Size(147, 22);
            this.PrecioProductoInput.TabIndex = 3;
            this.PrecioProductoInput.TextChanged += new System.EventHandler(this.PrecioProductoInput_TextChanged);
            // 
            // StockProductoInput
            // 
            this.StockProductoInput.Location = new System.Drawing.Point(281, 289);
            this.StockProductoInput.Name = "StockProductoInput";
            this.StockProductoInput.Size = new System.Drawing.Size(147, 22);
            this.StockProductoInput.TabIndex = 4;
            this.StockProductoInput.TextChanged += new System.EventHandler(this.StockProductoInput_TextChanged);
            // 
            // NombreProductoInput
            // 
            this.NombreProductoInput.Location = new System.Drawing.Point(84, 289);
            this.NombreProductoInput.Name = "NombreProductoInput";
            this.NombreProductoInput.Size = new System.Drawing.Size(147, 22);
            this.NombreProductoInput.TabIndex = 5;
            this.NombreProductoInput.TextChanged += new System.EventHandler(this.NombreProductoInput_TextChanged);
            // 
            // BtnIngresarProducto
            // 
            this.BtnIngresarProducto.Location = new System.Drawing.Point(281, 362);
            this.BtnIngresarProducto.Name = "BtnIngresarProducto";
            this.BtnIngresarProducto.Size = new System.Drawing.Size(147, 41);
            this.BtnIngresarProducto.TabIndex = 6;
            this.BtnIngresarProducto.Text = "Ingresar";
            this.BtnIngresarProducto.UseVisualStyleBackColor = true;
            this.BtnIngresarProducto.Click += new System.EventHandler(this.BtnIngresarProducto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Agregar un nuevo producto";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(306, 107);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(90, 86);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // IngresarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(762, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnIngresarProducto);
            this.Controls.Add(this.NombreProductoInput);
            this.Controls.Add(this.StockProductoInput);
            this.Controls.Add(this.PrecioProductoInput);
            this.Controls.Add(this.PrecioProductoText);
            this.Controls.Add(this.StockProductoText);
            this.Controls.Add(this.NombreProductoText);
            this.Name = "IngresarProducto";
            this.Text = "IngresarProducto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
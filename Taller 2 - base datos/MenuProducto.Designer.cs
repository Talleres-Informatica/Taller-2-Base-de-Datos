namespace Taller_2___base_datos
{
    partial class MenuProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuProducto));
            this.BtnModificarProducto = new System.Windows.Forms.Button();
            this.ModificarProductoText = new System.Windows.Forms.Label();
            this.MenuProductoText = new System.Windows.Forms.Label();
            this.ListaProductoText = new System.Windows.Forms.Label();
            this.BtnListaProducto = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnModificarProducto
            // 
            this.BtnModificarProducto.Location = new System.Drawing.Point(474, 292);
            this.BtnModificarProducto.Name = "BtnModificarProducto";
            this.BtnModificarProducto.Size = new System.Drawing.Size(112, 35);
            this.BtnModificarProducto.TabIndex = 1;
            this.BtnModificarProducto.Text = "Ver";
            this.BtnModificarProducto.UseVisualStyleBackColor = true;
            this.BtnModificarProducto.Click += new System.EventHandler(this.BtnModificarProducto_Click);
            // 
            // ModificarProductoText
            // 
            this.ModificarProductoText.AutoSize = true;
            this.ModificarProductoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarProductoText.Location = new System.Drawing.Point(435, 250);
            this.ModificarProductoText.Name = "ModificarProductoText";
            this.ModificarProductoText.Size = new System.Drawing.Size(199, 25);
            this.ModificarProductoText.TabIndex = 2;
            this.ModificarProductoText.Text = "Modificar un producto";
            // 
            // MenuProductoText
            // 
            this.MenuProductoText.AutoSize = true;
            this.MenuProductoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuProductoText.Location = new System.Drawing.Point(276, 49);
            this.MenuProductoText.Name = "MenuProductoText";
            this.MenuProductoText.Size = new System.Drawing.Size(200, 26);
            this.MenuProductoText.TabIndex = 4;
            this.MenuProductoText.Text = "Menu de Productos";
            // 
            // ListaProductoText
            // 
            this.ListaProductoText.AutoSize = true;
            this.ListaProductoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaProductoText.Location = new System.Drawing.Point(150, 255);
            this.ListaProductoText.Name = "ListaProductoText";
            this.ListaProductoText.Size = new System.Drawing.Size(171, 25);
            this.ListaProductoText.TabIndex = 8;
            this.ListaProductoText.Text = "Lista de productos";
            // 
            // BtnListaProducto
            // 
            this.BtnListaProducto.Location = new System.Drawing.Point(170, 292);
            this.BtnListaProducto.Name = "BtnListaProducto";
            this.BtnListaProducto.Size = new System.Drawing.Size(112, 35);
            this.BtnListaProducto.TabIndex = 7;
            this.BtnListaProducto.Text = "Ver";
            this.BtnListaProducto.UseVisualStyleBackColor = true;
            this.BtnListaProducto.Click += new System.EventHandler(this.BtnListaProducto_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(309, 93);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(122, 93);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // MenuProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.ListaProductoText);
            this.Controls.Add(this.BtnListaProducto);
            this.Controls.Add(this.MenuProductoText);
            this.Controls.Add(this.ModificarProductoText);
            this.Controls.Add(this.BtnModificarProducto);
            this.Name = "MenuProducto";
            this.Text = "MenuProducto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnModificarProducto;
        private System.Windows.Forms.Label ModificarProductoText;
        private System.Windows.Forms.Label MenuProductoText;
        private System.Windows.Forms.Label ListaProductoText;
        private System.Windows.Forms.Button BtnListaProducto;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
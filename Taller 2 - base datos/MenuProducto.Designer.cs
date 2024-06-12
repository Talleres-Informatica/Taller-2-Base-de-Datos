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
            this.BtnAgregarProducto = new System.Windows.Forms.Button();
            this.BtnModificarProducto = new System.Windows.Forms.Button();
            this.ModificarProductoText = new System.Windows.Forms.Label();
            this.AgregarProductoText = new System.Windows.Forms.Label();
            this.MenuProductoText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnAgregarProducto
            // 
            this.BtnAgregarProducto.Location = new System.Drawing.Point(541, 238);
            this.BtnAgregarProducto.Name = "BtnAgregarProducto";
            this.BtnAgregarProducto.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregarProducto.TabIndex = 0;
            this.BtnAgregarProducto.Text = "Ver";
            this.BtnAgregarProducto.UseVisualStyleBackColor = true;
            this.BtnAgregarProducto.Click += new System.EventHandler(this.BtnAgregarProducto_Click);
            // 
            // BtnModificarProducto
            // 
            this.BtnModificarProducto.Location = new System.Drawing.Point(142, 238);
            this.BtnModificarProducto.Name = "BtnModificarProducto";
            this.BtnModificarProducto.Size = new System.Drawing.Size(75, 23);
            this.BtnModificarProducto.TabIndex = 1;
            this.BtnModificarProducto.Text = "Ver";
            this.BtnModificarProducto.UseVisualStyleBackColor = true;
            this.BtnModificarProducto.Click += new System.EventHandler(this.BtnModificarProducto_Click);
            // 
            // ModificarProductoText
            // 
            this.ModificarProductoText.AutoSize = true;
            this.ModificarProductoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarProductoText.Location = new System.Drawing.Point(112, 172);
            this.ModificarProductoText.Name = "ModificarProductoText";
            this.ModificarProductoText.Size = new System.Drawing.Size(174, 25);
            this.ModificarProductoText.TabIndex = 2;
            this.ModificarProductoText.Text = "Modificar Producto";
            // 
            // AgregarProductoText
            // 
            this.AgregarProductoText.AutoSize = true;
            this.AgregarProductoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarProductoText.Location = new System.Drawing.Point(502, 179);
            this.AgregarProductoText.Name = "AgregarProductoText";
            this.AgregarProductoText.Size = new System.Drawing.Size(165, 25);
            this.AgregarProductoText.TabIndex = 3;
            this.AgregarProductoText.Text = "Agregar Producto";
            // 
            // MenuProductoText
            // 
            this.MenuProductoText.AutoSize = true;
            this.MenuProductoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuProductoText.Location = new System.Drawing.Point(326, 54);
            this.MenuProductoText.Name = "MenuProductoText";
            this.MenuProductoText.Size = new System.Drawing.Size(159, 26);
            this.MenuProductoText.TabIndex = 4;
            this.MenuProductoText.Text = "Menu Producto";
            // 
            // MenuProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MenuProductoText);
            this.Controls.Add(this.AgregarProductoText);
            this.Controls.Add(this.ModificarProductoText);
            this.Controls.Add(this.BtnModificarProducto);
            this.Controls.Add(this.BtnAgregarProducto);
            this.Name = "MenuProducto";
            this.Text = "MenuProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAgregarProducto;
        private System.Windows.Forms.Button BtnModificarProducto;
        private System.Windows.Forms.Label ModificarProductoText;
        private System.Windows.Forms.Label AgregarProductoText;
        private System.Windows.Forms.Label MenuProductoText;
    }
}
namespace Taller_2___base_datos
{
    partial class ListaProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaProducto));
            this.dataLista = new System.Windows.Forms.DataGridView();
            this.ListaProductoText = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLista
            // 
            this.dataLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLista.Location = new System.Drawing.Point(12, 92);
            this.dataLista.Name = "dataLista";
            this.dataLista.RowHeadersWidth = 51;
            this.dataLista.RowTemplate.Height = 24;
            this.dataLista.Size = new System.Drawing.Size(759, 411);
            this.dataLista.TabIndex = 0;
            // 
            // ListaProductoText
            // 
            this.ListaProductoText.AutoSize = true;
            this.ListaProductoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaProductoText.Location = new System.Drawing.Point(305, 31);
            this.ListaProductoText.Name = "ListaProductoText";
            this.ListaProductoText.Size = new System.Drawing.Size(162, 26);
            this.ListaProductoText.TabIndex = 1;
            this.ListaProductoText.Text = "Lista Productos";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(12, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(72, 68);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // ListaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.ListaProductoText);
            this.Controls.Add(this.dataLista);
            this.Name = "ListaProducto";
            this.Text = "ListaProducto";
            this.Load += new System.EventHandler(this.ListaProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataLista;
        private System.Windows.Forms.Label ListaProductoText;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
namespace Taller_2___base_datos
{
    partial class EliminarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarProducto));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEliminarProducto = new System.Windows.Forms.Button();
            this.dataListaProducto = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eliminar Producto ";
            // 
            // BtnEliminarProducto
            // 
            this.BtnEliminarProducto.Location = new System.Drawing.Point(330, 429);
            this.BtnEliminarProducto.Name = "BtnEliminarProducto";
            this.BtnEliminarProducto.Size = new System.Drawing.Size(134, 47);
            this.BtnEliminarProducto.TabIndex = 1;
            this.BtnEliminarProducto.Text = "Eliminar";
            this.BtnEliminarProducto.UseVisualStyleBackColor = true;
            this.BtnEliminarProducto.Click += new System.EventHandler(this.BtnEliminarProducto_Click);
            // 
            // dataListaProducto
            // 
            this.dataListaProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataListaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListaProducto.Location = new System.Drawing.Point(37, 86);
            this.dataListaProducto.Name = "dataListaProducto";
            this.dataListaProducto.RowHeadersWidth = 51;
            this.dataListaProducto.RowTemplate.Height = 24;
            this.dataListaProducto.Size = new System.Drawing.Size(728, 323);
            this.dataListaProducto.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selecciona una ID";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(37, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(72, 68);
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // EliminarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataListaProducto);
            this.Controls.Add(this.BtnEliminarProducto);
            this.Controls.Add(this.label1);
            this.Name = "EliminarProducto";
            this.Text = "EliminarProducto";
            this.Load += new System.EventHandler(this.EliminarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataListaProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEliminarProducto;
        private System.Windows.Forms.DataGridView dataListaProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
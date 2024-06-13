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
            this.dataLista = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLista
            // 
            this.dataLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLista.Location = new System.Drawing.Point(385, 86);
            this.dataLista.Name = "dataLista";
            this.dataLista.RowHeadersWidth = 51;
            this.dataLista.RowTemplate.Height = 24;
            this.dataLista.Size = new System.Drawing.Size(375, 219);
            this.dataLista.TabIndex = 1;
            // 
            // ListaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataLista);
            this.Name = "ListaVenta";
            this.Text = "ListaVenta";
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataLista;
    }
}
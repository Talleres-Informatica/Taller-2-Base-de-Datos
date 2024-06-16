namespace Taller_2___base_datos
{
    partial class VentasCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.ClienteText = new System.Windows.Forms.Label();
            this.FechaTezt = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fechaBuscar = new System.Windows.Forms.DateTimePicker();
            this.BtnVerVenta = new System.Windows.Forms.Button();
            this.NombreBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ventas Cliente en Especifico";
            // 
            // ClienteText
            // 
            this.ClienteText.AutoSize = true;
            this.ClienteText.Location = new System.Drawing.Point(47, 156);
            this.ClienteText.Name = "ClienteText";
            this.ClienteText.Size = new System.Drawing.Size(48, 16);
            this.ClienteText.TabIndex = 1;
            this.ClienteText.Text = "Cliente";
            // 
            // FechaTezt
            // 
            this.FechaTezt.AutoSize = true;
            this.FechaTezt.Location = new System.Drawing.Point(50, 228);
            this.FechaTezt.Name = "FechaTezt";
            this.FechaTezt.Size = new System.Drawing.Size(45, 16);
            this.FechaTezt.TabIndex = 2;
            this.FechaTezt.Text = "Fecha";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(310, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(404, 260);
            this.dataGridView1.TabIndex = 4;
            // 
            // fechaBuscar
            // 
            this.fechaBuscar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaBuscar.Location = new System.Drawing.Point(15, 247);
            this.fechaBuscar.Name = "fechaBuscar";
            this.fechaBuscar.Size = new System.Drawing.Size(121, 22);
            this.fechaBuscar.TabIndex = 5;
            // 
            // BtnVerVenta
            // 
            this.BtnVerVenta.Location = new System.Drawing.Point(50, 326);
            this.BtnVerVenta.Name = "BtnVerVenta";
            this.BtnVerVenta.Size = new System.Drawing.Size(75, 23);
            this.BtnVerVenta.TabIndex = 6;
            this.BtnVerVenta.Text = "Ver";
            this.BtnVerVenta.UseVisualStyleBackColor = true;
            this.BtnVerVenta.Click += new System.EventHandler(this.BtnVerVenta_Click);
            // 
            // NombreBuscar
            // 
            this.NombreBuscar.Location = new System.Drawing.Point(15, 175);
            this.NombreBuscar.Name = "NombreBuscar";
            this.NombreBuscar.Size = new System.Drawing.Size(121, 22);
            this.NombreBuscar.TabIndex = 7;
            // 
            // VentasCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NombreBuscar);
            this.Controls.Add(this.BtnVerVenta);
            this.Controls.Add(this.fechaBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.FechaTezt);
            this.Controls.Add(this.ClienteText);
            this.Controls.Add(this.label1);
            this.Name = "VentasCliente";
            this.Text = "VentasCliente";
            this.Load += new System.EventHandler(this.VentasCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ClienteText;
        private System.Windows.Forms.Label FechaTezt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker fechaBuscar;
        private System.Windows.Forms.Button BtnVerVenta;
        private System.Windows.Forms.TextBox NombreBuscar;
    }
}
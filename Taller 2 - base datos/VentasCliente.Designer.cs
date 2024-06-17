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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentasCliente));
            this.label1 = new System.Windows.Forms.Label();
            this.ClienteText = new System.Windows.Forms.Label();
            this.FechaTezt = new System.Windows.Forms.Label();
            this.dataVentasCliente = new System.Windows.Forms.DataGridView();
            this.fechaBuscar = new System.Windows.Forms.DateTimePicker();
            this.BtnVerVenta = new System.Windows.Forms.Button();
            this.NombreBuscar = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataVentasCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar ventas de un cliente";
            // 
            // ClienteText
            // 
            this.ClienteText.AutoSize = true;
            this.ClienteText.Location = new System.Drawing.Point(104, 160);
            this.ClienteText.Name = "ClienteText";
            this.ClienteText.Size = new System.Drawing.Size(48, 16);
            this.ClienteText.TabIndex = 1;
            this.ClienteText.Text = "Cliente";
            // 
            // FechaTezt
            // 
            this.FechaTezt.AutoSize = true;
            this.FechaTezt.Location = new System.Drawing.Point(107, 238);
            this.FechaTezt.Name = "FechaTezt";
            this.FechaTezt.Size = new System.Drawing.Size(45, 16);
            this.FechaTezt.TabIndex = 2;
            this.FechaTezt.Text = "Fecha";
            // 
            // dataVentasCliente
            // 
            this.dataVentasCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataVentasCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVentasCliente.Location = new System.Drawing.Point(264, 89);
            this.dataVentasCliente.Name = "dataVentasCliente";
            this.dataVentasCliente.RowHeadersWidth = 51;
            this.dataVentasCliente.RowTemplate.Height = 24;
            this.dataVentasCliente.Size = new System.Drawing.Size(534, 458);
            this.dataVentasCliente.TabIndex = 4;
            // 
            // fechaBuscar
            // 
            this.fechaBuscar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaBuscar.Location = new System.Drawing.Point(63, 267);
            this.fechaBuscar.Name = "fechaBuscar";
            this.fechaBuscar.Size = new System.Drawing.Size(121, 22);
            this.fechaBuscar.TabIndex = 5;
            // 
            // BtnVerVenta
            // 
            this.BtnVerVenta.Location = new System.Drawing.Point(63, 337);
            this.BtnVerVenta.Name = "BtnVerVenta";
            this.BtnVerVenta.Size = new System.Drawing.Size(121, 43);
            this.BtnVerVenta.TabIndex = 6;
            this.BtnVerVenta.Text = "Buscar";
            this.BtnVerVenta.UseVisualStyleBackColor = true;
            this.BtnVerVenta.Click += new System.EventHandler(this.BtnVerVenta_Click);
            // 
            // NombreBuscar
            // 
            this.NombreBuscar.Location = new System.Drawing.Point(51, 188);
            this.NombreBuscar.Name = "NombreBuscar";
            this.NombreBuscar.Size = new System.Drawing.Size(151, 22);
            this.NombreBuscar.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(72, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(108, 93);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(72, 439);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 93);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // VentasCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(820, 570);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.NombreBuscar);
            this.Controls.Add(this.BtnVerVenta);
            this.Controls.Add(this.fechaBuscar);
            this.Controls.Add(this.dataVentasCliente);
            this.Controls.Add(this.FechaTezt);
            this.Controls.Add(this.ClienteText);
            this.Controls.Add(this.label1);
            this.Name = "VentasCliente";
            this.Text = "Buscar ventas de un cliente";
            this.Load += new System.EventHandler(this.VentasCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataVentasCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ClienteText;
        private System.Windows.Forms.Label FechaTezt;
        private System.Windows.Forms.DataGridView dataVentasCliente;
        private System.Windows.Forms.DateTimePicker fechaBuscar;
        private System.Windows.Forms.Button BtnVerVenta;
        private System.Windows.Forms.TextBox NombreBuscar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}
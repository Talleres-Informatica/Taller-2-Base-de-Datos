﻿namespace Taller_2___base_datos
{
    partial class ListaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaCliente));
            this.listaClientetext = new System.Windows.Forms.Label();
            this.dataListaCliente = new System.Windows.Forms.DataGridView();
            this.BtnVerListaCliente = new System.Windows.Forms.Button();
            this.CtnClientes = new System.Windows.Forms.Label();
            this.Tipotext = new System.Windows.Forms.Label();
            this.ClientePremium = new System.Windows.Forms.Label();
            this.ListaTipobox = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // listaClientetext
            // 
            this.listaClientetext.AutoSize = true;
            this.listaClientetext.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaClientetext.Location = new System.Drawing.Point(295, 9);
            this.listaClientetext.Name = "listaClientetext";
            this.listaClientetext.Size = new System.Drawing.Size(168, 26);
            this.listaClientetext.TabIndex = 0;
            this.listaClientetext.Text = "Lista de clientes";
            // 
            // dataListaCliente
            // 
            this.dataListaCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataListaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListaCliente.Location = new System.Drawing.Point(12, 101);
            this.dataListaCliente.Name = "dataListaCliente";
            this.dataListaCliente.RowHeadersWidth = 51;
            this.dataListaCliente.RowTemplate.Height = 24;
            this.dataListaCliente.Size = new System.Drawing.Size(776, 426);
            this.dataListaCliente.TabIndex = 2;
            this.dataListaCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BtnVerListaCliente
            // 
            this.BtnVerListaCliente.Location = new System.Drawing.Point(300, 57);
            this.BtnVerListaCliente.Name = "BtnVerListaCliente";
            this.BtnVerListaCliente.Size = new System.Drawing.Size(75, 23);
            this.BtnVerListaCliente.TabIndex = 4;
            this.BtnVerListaCliente.Text = "Ver";
            this.BtnVerListaCliente.UseVisualStyleBackColor = true;
            this.BtnVerListaCliente.Click += new System.EventHandler(this.BtnVerListaCliente_Click);
            // 
            // CtnClientes
            // 
            this.CtnClientes.AutoSize = true;
            this.CtnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CtnClientes.Location = new System.Drawing.Point(683, 57);
            this.CtnClientes.Name = "CtnClientes";
            this.CtnClientes.Size = new System.Drawing.Size(86, 25);
            this.CtnClientes.TabIndex = 6;
            this.CtnClientes.Text = "cantidad";
            this.CtnClientes.Click += new System.EventHandler(this.CtnClientes_Click);
            // 
            // Tipotext
            // 
            this.Tipotext.AutoSize = true;
            this.Tipotext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tipotext.Location = new System.Drawing.Point(104, 52);
            this.Tipotext.Name = "Tipotext";
            this.Tipotext.Size = new System.Drawing.Size(51, 25);
            this.Tipotext.TabIndex = 7;
            this.Tipotext.Text = "Tipo";
            // 
            // ClientePremium
            // 
            this.ClientePremium.AutoSize = true;
            this.ClientePremium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientePremium.Location = new System.Drawing.Point(473, 56);
            this.ClientePremium.Name = "ClientePremium";
            this.ClientePremium.Size = new System.Drawing.Size(171, 25);
            this.ClientePremium.TabIndex = 8;
            this.ClientePremium.Text = "Clientes Premium:";
            // 
            // ListaTipobox
            // 
            this.ListaTipobox.FormattingEnabled = true;
            this.ListaTipobox.Items.AddRange(new object[] {
            "Normal",
            "Premium",
            "Todos"});
            this.ListaTipobox.Location = new System.Drawing.Point(161, 56);
            this.ListaTipobox.Name = "ListaTipobox";
            this.ListaTipobox.Size = new System.Drawing.Size(121, 24);
            this.ListaTipobox.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 68);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // ListaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ListaTipobox);
            this.Controls.Add(this.ClientePremium);
            this.Controls.Add(this.Tipotext);
            this.Controls.Add(this.CtnClientes);
            this.Controls.Add(this.BtnVerListaCliente);
            this.Controls.Add(this.dataListaCliente);
            this.Controls.Add(this.listaClientetext);
            this.Name = "ListaCliente";
            this.Text = "ListaCliente";
            this.Load += new System.EventHandler(this.ListaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataListaCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label listaClientetext;
        private System.Windows.Forms.DataGridView dataListaCliente;
        private System.Windows.Forms.Button BtnVerListaCliente;
        private System.Windows.Forms.Label CtnClientes;
        private System.Windows.Forms.Label Tipotext;
        private System.Windows.Forms.Label ClientePremium;
        private System.Windows.Forms.ComboBox ListaTipobox;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
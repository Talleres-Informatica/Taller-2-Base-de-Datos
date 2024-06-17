namespace Taller_2___base_datos
{
    partial class EliminarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarCliente));
            this.EliminarClienteText = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.dataLista = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // EliminarClienteText
            // 
            this.EliminarClienteText.AutoSize = true;
            this.EliminarClienteText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarClienteText.Location = new System.Drawing.Point(309, 30);
            this.EliminarClienteText.Name = "EliminarClienteText";
            this.EliminarClienteText.Size = new System.Drawing.Size(166, 26);
            this.EliminarClienteText.TabIndex = 0;
            this.EliminarClienteText.Text = "Eliminar Cliente";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(332, 429);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(143, 50);
            this.BtnEliminar.TabIndex = 1;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // dataLista
            // 
            this.dataLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLista.Location = new System.Drawing.Point(30, 87);
            this.dataLista.Name = "dataLista";
            this.dataLista.RowHeadersWidth = 51;
            this.dataLista.RowTemplate.Height = 24;
            this.dataLista.Size = new System.Drawing.Size(738, 322);
            this.dataLista.TabIndex = 2;
            this.dataLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLista_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selecciona una ID";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(30, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 68);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // EliminarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataLista);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.EliminarClienteText);
            this.Name = "EliminarCliente";
            this.Text = "EliminarCliente";
            this.Load += new System.EventHandler(this.EliminarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EliminarClienteText;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.DataGridView dataLista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
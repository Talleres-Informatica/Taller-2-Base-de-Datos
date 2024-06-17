namespace Taller_2___base_datos
{
    partial class IngresarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngresarUsuario));
            this.ListaCliente = new System.Windows.Forms.ComboBox();
            this.NombreInput = new System.Windows.Forms.TextBox();
            this.CiudadInput = new System.Windows.Forms.TextBox();
            this.NombreText = new System.Windows.Forms.Label();
            this.CiudadText = new System.Windows.Forms.Label();
            this.Tipo = new System.Windows.Forms.Label();
            this.BtnIngresarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaCliente
            // 
            this.ListaCliente.FormattingEnabled = true;
            this.ListaCliente.Items.AddRange(new object[] {
            "Premium",
            "Normal"});
            this.ListaCliente.Location = new System.Drawing.Point(506, 291);
            this.ListaCliente.Name = "ListaCliente";
            this.ListaCliente.Size = new System.Drawing.Size(137, 24);
            this.ListaCliente.TabIndex = 0;
            this.ListaCliente.SelectedIndexChanged += new System.EventHandler(this.ListaCliente_SelectedIndexChanged);
            // 
            // NombreInput
            // 
            this.NombreInput.Location = new System.Drawing.Point(66, 293);
            this.NombreInput.Name = "NombreInput";
            this.NombreInput.Size = new System.Drawing.Size(155, 22);
            this.NombreInput.TabIndex = 1;
            this.NombreInput.TextChanged += new System.EventHandler(this.NombreInput_TextChanged);
            // 
            // CiudadInput
            // 
            this.CiudadInput.Location = new System.Drawing.Point(287, 293);
            this.CiudadInput.Name = "CiudadInput";
            this.CiudadInput.Size = new System.Drawing.Size(153, 22);
            this.CiudadInput.TabIndex = 2;
            this.CiudadInput.TextChanged += new System.EventHandler(this.CiudadInput_TextChanged);
            // 
            // NombreText
            // 
            this.NombreText.AutoSize = true;
            this.NombreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreText.Location = new System.Drawing.Point(101, 250);
            this.NombreText.Name = "NombreText";
            this.NombreText.Size = new System.Drawing.Size(90, 26);
            this.NombreText.TabIndex = 3;
            this.NombreText.Text = "Nombre";
            // 
            // CiudadText
            // 
            this.CiudadText.AutoSize = true;
            this.CiudadText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CiudadText.Location = new System.Drawing.Point(323, 250);
            this.CiudadText.Name = "CiudadText";
            this.CiudadText.Size = new System.Drawing.Size(81, 26);
            this.CiudadText.TabIndex = 4;
            this.CiudadText.Text = "Ciudad";
            // 
            // Tipo
            // 
            this.Tipo.AutoSize = true;
            this.Tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tipo.Location = new System.Drawing.Point(543, 250);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(53, 26);
            this.Tipo.TabIndex = 5;
            this.Tipo.Text = "Tipo";
            // 
            // BtnIngresarCliente
            // 
            this.BtnIngresarCliente.Location = new System.Drawing.Point(287, 366);
            this.BtnIngresarCliente.Name = "BtnIngresarCliente";
            this.BtnIngresarCliente.Size = new System.Drawing.Size(153, 44);
            this.BtnIngresarCliente.TabIndex = 6;
            this.BtnIngresarCliente.Text = "Ingresar";
            this.BtnIngresarCliente.UseVisualStyleBackColor = true;
            this.BtnIngresarCliente.Click += new System.EventHandler(this.BtnIngresarCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Agregar un cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(313, 106);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(97, 84);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // IngresarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnIngresarCliente);
            this.Controls.Add(this.Tipo);
            this.Controls.Add(this.CiudadText);
            this.Controls.Add(this.NombreText);
            this.Controls.Add(this.CiudadInput);
            this.Controls.Add(this.NombreInput);
            this.Controls.Add(this.ListaCliente);
            this.Name = "IngresarUsuario";
            this.Text = "IngresarUsuario";
            this.Load += new System.EventHandler(this.IngresarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ListaCliente;
        private System.Windows.Forms.TextBox NombreInput;
        private System.Windows.Forms.TextBox CiudadInput;
        private System.Windows.Forms.Label NombreText;
        private System.Windows.Forms.Label CiudadText;
        private System.Windows.Forms.Label Tipo;
        private System.Windows.Forms.Button BtnIngresarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
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
            this.ListaCliente = new System.Windows.Forms.ComboBox();
            this.NombreInput = new System.Windows.Forms.TextBox();
            this.CiudadInput = new System.Windows.Forms.TextBox();
            this.NombreText = new System.Windows.Forms.Label();
            this.CiudadText = new System.Windows.Forms.Label();
            this.Tipo = new System.Windows.Forms.Label();
            this.BtnIngresarCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListaCliente
            // 
            this.ListaCliente.FormattingEnabled = true;
            this.ListaCliente.Items.AddRange(new object[] {
            "Premium",
            "Normal"});
            this.ListaCliente.Location = new System.Drawing.Point(565, 171);
            this.ListaCliente.Name = "ListaCliente";
            this.ListaCliente.Size = new System.Drawing.Size(121, 24);
            this.ListaCliente.TabIndex = 0;
            this.ListaCliente.SelectedIndexChanged += new System.EventHandler(this.ListaCliente_SelectedIndexChanged);
            // 
            // NombreInput
            // 
            this.NombreInput.Location = new System.Drawing.Point(81, 171);
            this.NombreInput.Name = "NombreInput";
            this.NombreInput.Size = new System.Drawing.Size(125, 22);
            this.NombreInput.TabIndex = 1;
            this.NombreInput.TextChanged += new System.EventHandler(this.NombreInput_TextChanged);
            // 
            // CiudadInput
            // 
            this.CiudadInput.Location = new System.Drawing.Point(330, 171);
            this.CiudadInput.Name = "CiudadInput";
            this.CiudadInput.Size = new System.Drawing.Size(125, 22);
            this.CiudadInput.TabIndex = 2;
            this.CiudadInput.TextChanged += new System.EventHandler(this.CiudadInput_TextChanged);
            // 
            // NombreText
            // 
            this.NombreText.AutoSize = true;
            this.NombreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreText.Location = new System.Drawing.Point(100, 128);
            this.NombreText.Name = "NombreText";
            this.NombreText.Size = new System.Drawing.Size(90, 26);
            this.NombreText.TabIndex = 3;
            this.NombreText.Text = "Nombre";
            // 
            // CiudadText
            // 
            this.CiudadText.AutoSize = true;
            this.CiudadText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CiudadText.Location = new System.Drawing.Point(355, 128);
            this.CiudadText.Name = "CiudadText";
            this.CiudadText.Size = new System.Drawing.Size(81, 26);
            this.CiudadText.TabIndex = 4;
            this.CiudadText.Text = "Ciudad";
            // 
            // Tipo
            // 
            this.Tipo.AutoSize = true;
            this.Tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tipo.Location = new System.Drawing.Point(603, 128);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(53, 26);
            this.Tipo.TabIndex = 5;
            this.Tipo.Text = "Tipo";
            // 
            // BtnIngresarCliente
            // 
            this.BtnIngresarCliente.Location = new System.Drawing.Point(302, 318);
            this.BtnIngresarCliente.Name = "BtnIngresarCliente";
            this.BtnIngresarCliente.Size = new System.Drawing.Size(153, 55);
            this.BtnIngresarCliente.TabIndex = 6;
            this.BtnIngresarCliente.Text = "Ingresar";
            this.BtnIngresarCliente.UseVisualStyleBackColor = true;
            this.BtnIngresarCliente.Click += new System.EventHandler(this.BtnIngresarCliente_Click);
            // 
            // IngresarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnIngresarCliente);
            this.Controls.Add(this.Tipo);
            this.Controls.Add(this.CiudadText);
            this.Controls.Add(this.NombreText);
            this.Controls.Add(this.CiudadInput);
            this.Controls.Add(this.NombreInput);
            this.Controls.Add(this.ListaCliente);
            this.Name = "IngresarUsuario";
            this.Text = "IngresarUsuario";
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
    }
}
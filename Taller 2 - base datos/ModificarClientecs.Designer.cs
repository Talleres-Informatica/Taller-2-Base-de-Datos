namespace Taller_2___base_datos
{
    partial class ModificarClientecs
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
            this.Cliente = new System.Windows.Forms.Label();
            this.ModificarClienteText = new System.Windows.Forms.Label();
            this.ListaCliente = new System.Windows.Forms.ComboBox();
            this.BtnPremium = new System.Windows.Forms.Button();
            this.BtnNormal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cliente
            // 
            this.Cliente.AutoSize = true;
            this.Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente.Location = new System.Drawing.Point(351, 137);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(73, 25);
            this.Cliente.TabIndex = 2;
            this.Cliente.Text = "Cliente";
            // 
            // ModificarClienteText
            // 
            this.ModificarClienteText.AutoSize = true;
            this.ModificarClienteText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarClienteText.Location = new System.Drawing.Point(274, 31);
            this.ModificarClienteText.Name = "ModificarClienteText";
            this.ModificarClienteText.Size = new System.Drawing.Size(246, 26);
            this.ModificarClienteText.TabIndex = 5;
            this.ModificarClienteText.Text = "Cambiar Tipo de Cliente";
            // 
            // ListaCliente
            // 
            this.ListaCliente.FormattingEnabled = true;
            this.ListaCliente.Location = new System.Drawing.Point(311, 174);
            this.ListaCliente.Name = "ListaCliente";
            this.ListaCliente.Size = new System.Drawing.Size(156, 24);
            this.ListaCliente.TabIndex = 6;
            // 
            // BtnPremium
            // 
            this.BtnPremium.Location = new System.Drawing.Point(518, 263);
            this.BtnPremium.Name = "BtnPremium";
            this.BtnPremium.Size = new System.Drawing.Size(131, 40);
            this.BtnPremium.TabIndex = 7;
            this.BtnPremium.Text = "Premium";
            this.BtnPremium.UseVisualStyleBackColor = true;
            this.BtnPremium.Click += new System.EventHandler(this.BtnPremium_Click);
            // 
            // BtnNormal
            // 
            this.BtnNormal.Location = new System.Drawing.Point(119, 263);
            this.BtnNormal.Name = "BtnNormal";
            this.BtnNormal.Size = new System.Drawing.Size(128, 40);
            this.BtnNormal.TabIndex = 8;
            this.BtnNormal.Text = "Normal";
            this.BtnNormal.UseVisualStyleBackColor = true;
            this.BtnNormal.Click += new System.EventHandler(this.BtnNormal_Click);
            // 
            // ModificarClientecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnNormal);
            this.Controls.Add(this.BtnPremium);
            this.Controls.Add(this.ListaCliente);
            this.Controls.Add(this.ModificarClienteText);
            this.Controls.Add(this.Cliente);
            this.Name = "ModificarClientecs";
            this.Text = "ModificarClientecs";
            this.Load += new System.EventHandler(this.ModificarClientecs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Cliente;
        private System.Windows.Forms.Label ModificarClienteText;
        private System.Windows.Forms.ComboBox ListaCliente;
        private System.Windows.Forms.Button BtnPremium;
        private System.Windows.Forms.Button BtnNormal;
    }
}
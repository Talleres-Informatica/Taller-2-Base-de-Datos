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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarClientecs));
            this.Cliente = new System.Windows.Forms.Label();
            this.ModificarClienteText = new System.Windows.Forms.Label();
            this.ListaCliente = new System.Windows.Forms.ComboBox();
            this.BtnPremium = new System.Windows.Forms.Button();
            this.BtnNormal = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Cliente
            // 
            this.Cliente.AutoSize = true;
            this.Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente.Location = new System.Drawing.Point(146, 254);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(73, 25);
            this.Cliente.TabIndex = 2;
            this.Cliente.Text = "Cliente";
            // 
            // ModificarClienteText
            // 
            this.ModificarClienteText.AutoSize = true;
            this.ModificarClienteText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarClienteText.Location = new System.Drawing.Point(184, 63);
            this.ModificarClienteText.Name = "ModificarClienteText";
            this.ModificarClienteText.Size = new System.Drawing.Size(235, 26);
            this.ModificarClienteText.TabIndex = 5;
            this.ModificarClienteText.Text = "Cambiar tipo de cliente";
            // 
            // ListaCliente
            // 
            this.ListaCliente.FormattingEnabled = true;
            this.ListaCliente.Location = new System.Drawing.Point(106, 300);
            this.ListaCliente.Name = "ListaCliente";
            this.ListaCliente.Size = new System.Drawing.Size(156, 24);
            this.ListaCliente.TabIndex = 6;
            this.ListaCliente.SelectedIndexChanged += new System.EventHandler(this.ListaCliente_SelectedIndexChanged);
            // 
            // BtnPremium
            // 
            this.BtnPremium.Location = new System.Drawing.Point(337, 254);
            this.BtnPremium.Name = "BtnPremium";
            this.BtnPremium.Size = new System.Drawing.Size(128, 40);
            this.BtnPremium.TabIndex = 7;
            this.BtnPremium.Text = "Premium";
            this.BtnPremium.UseVisualStyleBackColor = true;
            this.BtnPremium.Click += new System.EventHandler(this.BtnPremium_Click);
            // 
            // BtnNormal
            // 
            this.BtnNormal.Location = new System.Drawing.Point(337, 174);
            this.BtnNormal.Name = "BtnNormal";
            this.BtnNormal.Size = new System.Drawing.Size(128, 40);
            this.BtnNormal.TabIndex = 8;
            this.BtnNormal.Text = "Normal";
            this.BtnNormal.UseVisualStyleBackColor = true;
            this.BtnNormal.Click += new System.EventHandler(this.BtnNormal_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(137, 157);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 83);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // ModificarClientecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(610, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BtnNormal);
            this.Controls.Add(this.BtnPremium);
            this.Controls.Add(this.ListaCliente);
            this.Controls.Add(this.ModificarClienteText);
            this.Controls.Add(this.Cliente);
            this.Name = "ModificarClientecs";
            this.Text = "ModificarClientecs";
            this.Load += new System.EventHandler(this.ModificarClientecs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Cliente;
        private System.Windows.Forms.Label ModificarClienteText;
        private System.Windows.Forms.ComboBox ListaCliente;
        private System.Windows.Forms.Button BtnPremium;
        private System.Windows.Forms.Button BtnNormal;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
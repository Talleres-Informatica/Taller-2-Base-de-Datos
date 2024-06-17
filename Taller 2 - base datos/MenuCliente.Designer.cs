namespace Taller_2___base_datos
{
    partial class MenuCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuCliente));
            this.label1 = new System.Windows.Forms.Label();
            this.ListaClientetext = new System.Windows.Forms.Label();
            this.BtnListaCliente = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Menu Cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ListaClientetext
            // 
            this.ListaClientetext.AutoSize = true;
            this.ListaClientetext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaClientetext.Location = new System.Drawing.Point(303, 218);
            this.ListaClientetext.Name = "ListaClientetext";
            this.ListaClientetext.Size = new System.Drawing.Size(156, 25);
            this.ListaClientetext.TabIndex = 5;
            this.ListaClientetext.Text = "Lista de Clientes";
            // 
            // BtnListaCliente
            // 
            this.BtnListaCliente.Location = new System.Drawing.Point(308, 256);
            this.BtnListaCliente.Name = "BtnListaCliente";
            this.BtnListaCliente.Size = new System.Drawing.Size(135, 53);
            this.BtnListaCliente.TabIndex = 6;
            this.BtnListaCliente.Text = "Ver";
            this.BtnListaCliente.UseVisualStyleBackColor = true;
            this.BtnListaCliente.Click += new System.EventHandler(this.BtnListaCliente_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(318, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 93);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // MenuCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(781, 480);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BtnListaCliente);
            this.Controls.Add(this.ListaClientetext);
            this.Controls.Add(this.label1);
            this.Name = "MenuCliente";
            this.Text = "MenuCliente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ListaClientetext;
        private System.Windows.Forms.Button BtnListaCliente;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
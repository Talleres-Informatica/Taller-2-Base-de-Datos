namespace Taller_2___base_datos
{
    partial class IniciarSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IniciarSesion));
            this.TitutloInicioSesion = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TextoUsuario = new System.Windows.Forms.TextBox();
            this.TextoClave = new System.Windows.Forms.TextBox();
            this.TituloUsuario = new System.Windows.Forms.Label();
            this.TituloClave = new System.Windows.Forms.Label();
            this.BtnIniciarSesion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TitutloInicioSesion
            // 
            this.TitutloInicioSesion.AutoSize = true;
            this.TitutloInicioSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitutloInicioSesion.Location = new System.Drawing.Point(153, 26);
            this.TitutloInicioSesion.Name = "TitutloInicioSesion";
            this.TitutloInicioSesion.Size = new System.Drawing.Size(179, 26);
            this.TitutloInicioSesion.TabIndex = 6;
            this.TitutloInicioSesion.Text = "Ingresa tu cuenta";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(188, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 83);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // TextoUsuario
            // 
            this.TextoUsuario.Location = new System.Drawing.Point(118, 217);
            this.TextoUsuario.Name = "TextoUsuario";
            this.TextoUsuario.Size = new System.Drawing.Size(240, 22);
            this.TextoUsuario.TabIndex = 25;
            // 
            // TextoClave
            // 
            this.TextoClave.Location = new System.Drawing.Point(118, 320);
            this.TextoClave.Name = "TextoClave";
            this.TextoClave.Size = new System.Drawing.Size(240, 22);
            this.TextoClave.TabIndex = 26;
            // 
            // TituloUsuario
            // 
            this.TituloUsuario.AutoSize = true;
            this.TituloUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloUsuario.Location = new System.Drawing.Point(192, 178);
            this.TituloUsuario.Name = "TituloUsuario";
            this.TituloUsuario.Size = new System.Drawing.Size(87, 26);
            this.TituloUsuario.TabIndex = 27;
            this.TituloUsuario.Text = "Usuario";
            // 
            // TituloClave
            // 
            this.TituloClave.AutoSize = true;
            this.TituloClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloClave.Location = new System.Drawing.Point(176, 281);
            this.TituloClave.Name = "TituloClave";
            this.TituloClave.Size = new System.Drawing.Size(124, 26);
            this.TituloClave.TabIndex = 28;
            this.TituloClave.Text = "Contraseña";
            // 
            // BtnIniciarSesion
            // 
            this.BtnIniciarSesion.Location = new System.Drawing.Point(158, 376);
            this.BtnIniciarSesion.Name = "BtnIniciarSesion";
            this.BtnIniciarSesion.Size = new System.Drawing.Size(156, 43);
            this.BtnIniciarSesion.TabIndex = 29;
            this.BtnIniciarSesion.Text = "Iniciar sesión";
            this.BtnIniciarSesion.UseVisualStyleBackColor = true;
            this.BtnIniciarSesion.Click += new System.EventHandler(this.BtnIniciarSesion_Click);
            // 
            // IniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(490, 450);
            this.Controls.Add(this.BtnIniciarSesion);
            this.Controls.Add(this.TituloClave);
            this.Controls.Add(this.TituloUsuario);
            this.Controls.Add(this.TextoClave);
            this.Controls.Add(this.TextoUsuario);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.TitutloInicioSesion);
            this.Name = "IniciarSesion";
            this.Text = "IniciarSesion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitutloInicioSesion;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox TextoUsuario;
        private System.Windows.Forms.TextBox TextoClave;
        private System.Windows.Forms.Label TituloUsuario;
        private System.Windows.Forms.Label TituloClave;
        private System.Windows.Forms.Button BtnIniciarSesion;
    }
}
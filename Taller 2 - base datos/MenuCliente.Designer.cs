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
            this.IngresarText = new System.Windows.Forms.Label();
            this.btnVerInUsuario = new System.Windows.Forms.Button();
            this.EliminarText = new System.Windows.Forms.Label();
            this.btnVerElimCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IngresarText
            // 
            this.IngresarText.AutoSize = true;
            this.IngresarText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngresarText.Location = new System.Drawing.Point(96, 192);
            this.IngresarText.Name = "IngresarText";
            this.IngresarText.Size = new System.Drawing.Size(149, 25);
            this.IngresarText.TabIndex = 0;
            this.IngresarText.Text = "Ingresar Cliente";
            // 
            // btnVerInUsuario
            // 
            this.btnVerInUsuario.Location = new System.Drawing.Point(137, 242);
            this.btnVerInUsuario.Name = "btnVerInUsuario";
            this.btnVerInUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnVerInUsuario.TabIndex = 1;
            this.btnVerInUsuario.Text = "Ver";
            this.btnVerInUsuario.UseVisualStyleBackColor = true;
            this.btnVerInUsuario.Click += new System.EventHandler(this.btnVerInUsuario_Click);
            // 
            // EliminarText
            // 
            this.EliminarText.AutoSize = true;
            this.EliminarText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarText.Location = new System.Drawing.Point(468, 192);
            this.EliminarText.Name = "EliminarText";
            this.EliminarText.Size = new System.Drawing.Size(147, 25);
            this.EliminarText.TabIndex = 2;
            this.EliminarText.Text = "Eliminar Cliente";
            // 
            // btnVerElimCliente
            // 
            this.btnVerElimCliente.Location = new System.Drawing.Point(507, 233);
            this.btnVerElimCliente.Name = "btnVerElimCliente";
            this.btnVerElimCliente.Size = new System.Drawing.Size(75, 23);
            this.btnVerElimCliente.TabIndex = 3;
            this.btnVerElimCliente.Text = "Ver";
            this.btnVerElimCliente.UseVisualStyleBackColor = true;
            this.btnVerElimCliente.Click += new System.EventHandler(this.btnVerElimCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Menu Cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MenuCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerElimCliente);
            this.Controls.Add(this.EliminarText);
            this.Controls.Add(this.btnVerInUsuario);
            this.Controls.Add(this.IngresarText);
            this.Name = "MenuCliente";
            this.Text = "MenuCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IngresarText;
        private System.Windows.Forms.Button btnVerInUsuario;
        private System.Windows.Forms.Label EliminarText;
        private System.Windows.Forms.Button btnVerElimCliente;
        private System.Windows.Forms.Label label1;
    }
}
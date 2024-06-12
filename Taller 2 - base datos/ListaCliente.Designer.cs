namespace Taller_2___base_datos
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
            this.label1 = new System.Windows.Forms.Label();
            this.ListaTipobox = new System.Windows.Forms.ComboBox();
            this.dataListaCliente = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnVerListaCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista clientes";
            // 
            // ListaTipobox
            // 
            this.ListaTipobox.FormattingEnabled = true;
            this.ListaTipobox.Items.AddRange(new object[] {
            "Normal",
            "Premium",
            "Todos"});
            this.ListaTipobox.Location = new System.Drawing.Point(28, 191);
            this.ListaTipobox.Name = "ListaTipobox";
            this.ListaTipobox.Size = new System.Drawing.Size(121, 24);
            this.ListaTipobox.TabIndex = 1;
            // 
            // dataListaCliente
            // 
            this.dataListaCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataListaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListaCliente.Location = new System.Drawing.Point(277, 118);
            this.dataListaCliente.Name = "dataListaCliente";
            this.dataListaCliente.RowHeadersWidth = 51;
            this.dataListaCliente.RowTemplate.Height = 24;
            this.dataListaCliente.Size = new System.Drawing.Size(417, 207);
            this.dataListaCliente.TabIndex = 2;
            this.dataListaCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo";
            // 
            // BtnVerListaCliente
            // 
            this.BtnVerListaCliente.Location = new System.Drawing.Point(57, 263);
            this.BtnVerListaCliente.Name = "BtnVerListaCliente";
            this.BtnVerListaCliente.Size = new System.Drawing.Size(75, 23);
            this.BtnVerListaCliente.TabIndex = 4;
            this.BtnVerListaCliente.Text = "Ver";
            this.BtnVerListaCliente.UseVisualStyleBackColor = true;
            this.BtnVerListaCliente.Click += new System.EventHandler(this.BtnVerListaCliente_Click);
            // 
            // ListaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnVerListaCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataListaCliente);
            this.Controls.Add(this.ListaTipobox);
            this.Controls.Add(this.label1);
            this.Name = "ListaCliente";
            this.Text = "ListaCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataListaCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ListaTipobox;
        private System.Windows.Forms.DataGridView dataListaCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnVerListaCliente;
    }
}
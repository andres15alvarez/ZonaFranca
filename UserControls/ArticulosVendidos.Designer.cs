namespace ZonaFranca
{
    partial class ArticulosVendidos
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.gdvarticulos = new System.Windows.Forms.DataGridView();
            this.datefinal = new System.Windows.Forms.DateTimePicker();
            this.entfechafinal = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateinicial = new System.Windows.Forms.DateTimePicker();
            this.entfechainicial = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gdvarticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(216, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Articulos mas vendidos";
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.Gray;
            this.btnbuscar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnbuscar.Location = new System.Drawing.Point(606, 103);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(77, 29);
            this.btnbuscar.TabIndex = 16;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // gdvarticulos
            // 
            this.gdvarticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gdvarticulos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gdvarticulos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gdvarticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvarticulos.Location = new System.Drawing.Point(30, 138);
            this.gdvarticulos.Name = "gdvarticulos";
            this.gdvarticulos.Size = new System.Drawing.Size(653, 291);
            this.gdvarticulos.TabIndex = 15;
            // 
            // datefinal
            // 
            this.datefinal.Location = new System.Drawing.Point(647, 63);
            this.datefinal.Name = "datefinal";
            this.datefinal.Size = new System.Drawing.Size(36, 27);
            this.datefinal.TabIndex = 14;
            this.datefinal.Value = new System.DateTime(2020, 8, 10, 0, 0, 0, 0);
            this.datefinal.ValueChanged += new System.EventHandler(this.datefinal_ValueChanged);
            // 
            // entfechafinal
            // 
            this.entfechafinal.Location = new System.Drawing.Point(541, 63);
            this.entfechafinal.Mask = "00/00/0000";
            this.entfechafinal.Name = "entfechafinal";
            this.entfechafinal.Size = new System.Drawing.Size(100, 27);
            this.entfechafinal.TabIndex = 13;
            this.entfechafinal.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Fecha final:";
            // 
            // dateinicial
            // 
            this.dateinicial.Location = new System.Drawing.Point(283, 63);
            this.dateinicial.Name = "dateinicial";
            this.dateinicial.Size = new System.Drawing.Size(36, 27);
            this.dateinicial.TabIndex = 11;
            this.dateinicial.Value = new System.DateTime(2020, 8, 10, 0, 0, 0, 0);
            this.dateinicial.ValueChanged += new System.EventHandler(this.dateinicial_ValueChanged);
            // 
            // entfechainicial
            // 
            this.entfechainicial.Location = new System.Drawing.Point(177, 63);
            this.entfechainicial.Mask = "00/00/0000";
            this.entfechainicial.Name = "entfechainicial";
            this.entfechainicial.Size = new System.Drawing.Size(100, 27);
            this.entfechainicial.TabIndex = 10;
            this.entfechainicial.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fecha inicial:";
            // 
            // ArticulosVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.gdvarticulos);
            this.Controls.Add(this.datefinal);
            this.Controls.Add(this.entfechafinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateinicial);
            this.Controls.Add(this.entfechainicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ArticulosVendidos";
            this.Size = new System.Drawing.Size(715, 444);
            ((System.ComponentModel.ISupportInitialize)(this.gdvarticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.DataGridView gdvarticulos;
        private System.Windows.Forms.DateTimePicker datefinal;
        private System.Windows.Forms.MaskedTextBox entfechafinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateinicial;
        private System.Windows.Forms.MaskedTextBox entfechainicial;
        private System.Windows.Forms.Label label2;
    }
}

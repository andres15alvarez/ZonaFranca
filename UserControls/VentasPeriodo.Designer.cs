namespace ZonaFranca
{
    partial class VentasPeriodo
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
            this.label2 = new System.Windows.Forms.Label();
            this.entfechainicial = new System.Windows.Forms.MaskedTextBox();
            this.dateinicial = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.entfechafinal = new System.Windows.Forms.MaskedTextBox();
            this.datefinal = new System.Windows.Forms.DateTimePicker();
            this.gdvventas = new System.Windows.Forms.DataGridView();
            this.btnbuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gdvventas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(234, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ventas de un periodo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha inicial:";
            // 
            // entfechainicial
            // 
            this.entfechainicial.Location = new System.Drawing.Point(169, 61);
            this.entfechainicial.Mask = "00/00/0000";
            this.entfechainicial.Name = "entfechainicial";
            this.entfechainicial.Size = new System.Drawing.Size(100, 27);
            this.entfechainicial.TabIndex = 2;
            this.entfechainicial.ValidatingType = typeof(System.DateTime);
            // 
            // dateinicial
            // 
            this.dateinicial.Location = new System.Drawing.Point(275, 61);
            this.dateinicial.Name = "dateinicial";
            this.dateinicial.Size = new System.Drawing.Size(34, 27);
            this.dateinicial.TabIndex = 3;
            this.dateinicial.Value = new System.DateTime(2020, 8, 10, 0, 0, 0, 0);
            this.dateinicial.ValueChanged += new System.EventHandler(this.dateinicial_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha final:";
            // 
            // entfechafinal
            // 
            this.entfechafinal.Location = new System.Drawing.Point(533, 61);
            this.entfechafinal.Mask = "00/00/0000";
            this.entfechafinal.Name = "entfechafinal";
            this.entfechafinal.Size = new System.Drawing.Size(100, 27);
            this.entfechafinal.TabIndex = 5;
            this.entfechafinal.ValidatingType = typeof(System.DateTime);
            // 
            // datefinal
            // 
            this.datefinal.Location = new System.Drawing.Point(639, 61);
            this.datefinal.Name = "datefinal";
            this.datefinal.Size = new System.Drawing.Size(36, 27);
            this.datefinal.TabIndex = 6;
            this.datefinal.Value = new System.DateTime(2020, 8, 10, 0, 0, 0, 0);
            this.datefinal.ValueChanged += new System.EventHandler(this.datefinal_ValueChanged);
            // 
            // gdvventas
            // 
            this.gdvventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gdvventas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gdvventas.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gdvventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvventas.Location = new System.Drawing.Point(22, 136);
            this.gdvventas.Name = "gdvventas";
            this.gdvventas.Size = new System.Drawing.Size(653, 291);
            this.gdvventas.TabIndex = 7;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.Gray;
            this.btnbuscar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnbuscar.Location = new System.Drawing.Point(598, 101);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(77, 29);
            this.btnbuscar.TabIndex = 8;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // VentasPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.gdvventas);
            this.Controls.Add(this.datefinal);
            this.Controls.Add(this.entfechafinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateinicial);
            this.Controls.Add(this.entfechainicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "VentasPeriodo";
            this.Size = new System.Drawing.Size(715, 444);
            ((System.ComponentModel.ISupportInitialize)(this.gdvventas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox entfechainicial;
        private System.Windows.Forms.DateTimePicker dateinicial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox entfechafinal;
        private System.Windows.Forms.DateTimePicker datefinal;
        private System.Windows.Forms.DataGridView gdvventas;
        private System.Windows.Forms.Button btnbuscar;
    }
}

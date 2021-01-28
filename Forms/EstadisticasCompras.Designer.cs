namespace ZonaFranca
{
    partial class EstadisticasCompras
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.entfechainicial = new System.Windows.Forms.MaskedTextBox();
            this.entfechafinal = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.gdvcompras = new System.Windows.Forms.DataGridView();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.enttotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.entpromedio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.entmax = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.entmin = new System.Windows.Forms.TextBox();
            this.btnvolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gdvcompras)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estadisticas de Compras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.label2.Location = new System.Drawing.Point(33, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(513, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Escoga el periodo de tiempo del cual quiere obtener las estadisticas.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha inicial:";
            // 
            // entfechainicial
            // 
            this.entfechainicial.Location = new System.Drawing.Point(169, 65);
            this.entfechainicial.Mask = "00/00/0000";
            this.entfechainicial.Name = "entfechainicial";
            this.entfechainicial.Size = new System.Drawing.Size(111, 27);
            this.entfechainicial.TabIndex = 3;
            this.entfechainicial.ValidatingType = typeof(System.DateTime);
            // 
            // entfechafinal
            // 
            this.entfechafinal.Location = new System.Drawing.Point(569, 65);
            this.entfechafinal.Mask = "00/00/0000";
            this.entfechafinal.Name = "entfechafinal";
            this.entfechafinal.Size = new System.Drawing.Size(111, 27);
            this.entfechafinal.TabIndex = 5;
            this.entfechafinal.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(447, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha inicial:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Verdana", 12F);
            this.dateTimePicker1.Location = new System.Drawing.Point(286, 65);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(21, 27);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(686, 65);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(23, 27);
            this.dateTimePicker2.TabIndex = 7;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // gdvcompras
            // 
            this.gdvcompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gdvcompras.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gdvcompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvcompras.Location = new System.Drawing.Point(19, 123);
            this.gdvcompras.Name = "gdvcompras";
            this.gdvcompras.ReadOnly = true;
            this.gdvcompras.Size = new System.Drawing.Size(729, 238);
            this.gdvcompras.TabIndex = 8;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.Gray;
            this.btnbuscar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnbuscar.Location = new System.Drawing.Point(353, 88);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(78, 29);
            this.btnbuscar.TabIndex = 9;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total compras:";
            // 
            // enttotal
            // 
            this.enttotal.Location = new System.Drawing.Point(151, 375);
            this.enttotal.Name = "enttotal";
            this.enttotal.ReadOnly = true;
            this.enttotal.Size = new System.Drawing.Size(156, 27);
            this.enttotal.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Promedio de compras:";
            // 
            // entpromedio
            // 
            this.entpromedio.Location = new System.Drawing.Point(582, 375);
            this.entpromedio.Name = "entpromedio";
            this.entpromedio.ReadOnly = true;
            this.entpromedio.Size = new System.Drawing.Size(156, 27);
            this.entpromedio.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 441);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Compra maxima:";
            // 
            // entmax
            // 
            this.entmax.Location = new System.Drawing.Point(169, 438);
            this.entmax.Name = "entmax";
            this.entmax.ReadOnly = true;
            this.entmax.Size = new System.Drawing.Size(156, 27);
            this.entmax.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(385, 441);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Compra minima:";
            // 
            // entmin
            // 
            this.entmin.Location = new System.Drawing.Point(534, 438);
            this.entmin.Name = "entmin";
            this.entmin.ReadOnly = true;
            this.entmin.Size = new System.Drawing.Size(156, 27);
            this.entmin.TabIndex = 17;
            // 
            // btnvolver
            // 
            this.btnvolver.BackColor = System.Drawing.Color.Gray;
            this.btnvolver.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolver.ForeColor = System.Drawing.Color.DarkRed;
            this.btnvolver.Location = new System.Drawing.Point(18, 501);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(78, 29);
            this.btnvolver.TabIndex = 18;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = false;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // EstadisticasCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(765, 542);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.entmin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.entmax);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.entpromedio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.enttotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.gdvcompras);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.entfechafinal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.entfechainicial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EstadisticasCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadisticas de Compras";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EstadisticasCompras_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.gdvcompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox entfechainicial;
        private System.Windows.Forms.MaskedTextBox entfechafinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridView gdvcompras;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox enttotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox entpromedio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox entmax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox entmin;
        private System.Windows.Forms.Button btnvolver;
    }
}
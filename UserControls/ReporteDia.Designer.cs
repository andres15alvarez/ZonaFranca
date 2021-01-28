namespace ZonaFranca
{
    partial class ReporteDia
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
            this.gdvreporte = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.enttotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.enttotalpunto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.enttotaltransferencia = new System.Windows.Forms.TextBox();
            this.enttotalefectivo = new System.Windows.Forms.TextBox();
            this.enttotaldolar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.entpromedio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.entmax = new System.Windows.Forms.TextBox();
            this.entmin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gdvreporte)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(262, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reporte del dia";
            // 
            // gdvreporte
            // 
            this.gdvreporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gdvreporte.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gdvreporte.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gdvreporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvreporte.Location = new System.Drawing.Point(3, 46);
            this.gdvreporte.Name = "gdvreporte";
            this.gdvreporte.ReadOnly = true;
            this.gdvreporte.Size = new System.Drawing.Size(708, 212);
            this.gdvreporte.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total ventas:";
            // 
            // enttotal
            // 
            this.enttotal.Location = new System.Drawing.Point(125, 267);
            this.enttotal.Name = "enttotal";
            this.enttotal.ReadOnly = true;
            this.enttotal.Size = new System.Drawing.Size(168, 27);
            this.enttotal.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total por punto de venta :";
            // 
            // enttotalpunto
            // 
            this.enttotalpunto.Location = new System.Drawing.Point(233, 302);
            this.enttotalpunto.Name = "enttotalpunto";
            this.enttotalpunto.ReadOnly = true;
            this.enttotalpunto.Size = new System.Drawing.Size(155, 27);
            this.enttotalpunto.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total por transferencia :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total por efectivo :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 410);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Total por dolares :";
            // 
            // enttotaltransferencia
            // 
            this.enttotaltransferencia.Location = new System.Drawing.Point(233, 337);
            this.enttotaltransferencia.Name = "enttotaltransferencia";
            this.enttotaltransferencia.ReadOnly = true;
            this.enttotaltransferencia.Size = new System.Drawing.Size(155, 27);
            this.enttotaltransferencia.TabIndex = 9;
            // 
            // enttotalefectivo
            // 
            this.enttotalefectivo.Location = new System.Drawing.Point(233, 372);
            this.enttotalefectivo.Name = "enttotalefectivo";
            this.enttotalefectivo.ReadOnly = true;
            this.enttotalefectivo.Size = new System.Drawing.Size(155, 27);
            this.enttotalefectivo.TabIndex = 10;
            // 
            // enttotaldolar
            // 
            this.enttotaldolar.Location = new System.Drawing.Point(233, 407);
            this.enttotaldolar.Name = "enttotaldolar";
            this.enttotaldolar.ReadOnly = true;
            this.enttotaldolar.Size = new System.Drawing.Size(155, 27);
            this.enttotaldolar.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(394, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Promedio de ventas:";
            // 
            // entpromedio
            // 
            this.entpromedio.Location = new System.Drawing.Point(578, 302);
            this.entpromedio.Name = "entpromedio";
            this.entpromedio.ReadOnly = true;
            this.entpromedio.Size = new System.Drawing.Size(134, 27);
            this.entpromedio.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(394, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Venta maxima:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(394, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "Venta minima:";
            // 
            // entmax
            // 
            this.entmax.Location = new System.Drawing.Point(577, 337);
            this.entmax.Name = "entmax";
            this.entmax.ReadOnly = true;
            this.entmax.Size = new System.Drawing.Size(134, 27);
            this.entmax.TabIndex = 16;
            // 
            // entmin
            // 
            this.entmin.Location = new System.Drawing.Point(577, 372);
            this.entmin.Name = "entmin";
            this.entmin.ReadOnly = true;
            this.entmin.Size = new System.Drawing.Size(134, 27);
            this.entmin.TabIndex = 17;
            // 
            // ReporteDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.entmin);
            this.Controls.Add(this.entmax);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.entpromedio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.enttotaldolar);
            this.Controls.Add(this.enttotalefectivo);
            this.Controls.Add(this.enttotaltransferencia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.enttotalpunto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.enttotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gdvreporte);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ReporteDia";
            this.Size = new System.Drawing.Size(715, 444);
            ((System.ComponentModel.ISupportInitialize)(this.gdvreporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gdvreporte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox enttotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox enttotalpunto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox enttotaltransferencia;
        private System.Windows.Forms.TextBox enttotalefectivo;
        private System.Windows.Forms.TextBox enttotaldolar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox entpromedio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox entmax;
        private System.Windows.Forms.TextBox entmin;
    }
}

namespace ZonaFranca
{
    partial class ActualizarArticulos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnactualizarprecio = new System.Windows.Forms.Button();
            this.entprecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.entcodigoprecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnvolver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Actualizacion de articulos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnactualizarprecio);
            this.groupBox1.Controls.Add(this.entprecio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.entcodigoprecio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 158);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actualizar precio";
            // 
            // btnactualizarprecio
            // 
            this.btnactualizarprecio.BackColor = System.Drawing.Color.Gray;
            this.btnactualizarprecio.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizarprecio.ForeColor = System.Drawing.Color.DarkRed;
            this.btnactualizarprecio.Location = new System.Drawing.Point(445, 94);
            this.btnactualizarprecio.Name = "btnactualizarprecio";
            this.btnactualizarprecio.Size = new System.Drawing.Size(100, 34);
            this.btnactualizarprecio.TabIndex = 4;
            this.btnactualizarprecio.Text = "Actualizar";
            this.btnactualizarprecio.UseVisualStyleBackColor = false;
            this.btnactualizarprecio.Click += new System.EventHandler(this.btnactualizarprecio_Click);
            // 
            // entprecio
            // 
            this.entprecio.Location = new System.Drawing.Point(395, 34);
            this.entprecio.Name = "entprecio";
            this.entprecio.Size = new System.Drawing.Size(150, 27);
            this.entprecio.TabIndex = 3;
            this.entprecio.TextChanged += new System.EventHandler(this.entprecio_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio nuevo:";
            // 
            // entcodigoprecio
            // 
            this.entcodigoprecio.Location = new System.Drawing.Point(83, 34);
            this.entcodigoprecio.Name = "entcodigoprecio";
            this.entcodigoprecio.Size = new System.Drawing.Size(150, 27);
            this.entcodigoprecio.TabIndex = 1;
            this.entcodigoprecio.TextChanged += new System.EventHandler(this.entcodigoprecio_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo:";
            // 
            // btnvolver
            // 
            this.btnvolver.BackColor = System.Drawing.Color.Gray;
            this.btnvolver.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolver.ForeColor = System.Drawing.Color.DarkRed;
            this.btnvolver.Location = new System.Drawing.Point(10, 222);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(84, 34);
            this.btnvolver.TabIndex = 5;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = false;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // ActualizarArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(644, 279);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "ActualizarArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Articulos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ActualizarArticulos_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnactualizarprecio;
        private System.Windows.Forms.TextBox entprecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox entcodigoprecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnvolver;
    }
}
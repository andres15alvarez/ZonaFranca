namespace ZonaFranca
{
    partial class Inicio
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.lbltitulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblingreso = new System.Windows.Forms.Label();
            this.btningresar = new System.Windows.Forms.Button();
            this.entpass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.entusuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltimer = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.DarkRed;
            this.lbltitulo.Location = new System.Drawing.Point(184, 9);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(156, 25);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Zona Franca";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblingreso);
            this.groupBox1.Controls.Add(this.btningresar);
            this.groupBox1.Controls.Add(this.entpass);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.entusuario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(12, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 217);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar usuario";
            // 
            // lblingreso
            // 
            this.lblingreso.AutoSize = true;
            this.lblingreso.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblingreso.ForeColor = System.Drawing.Color.Red;
            this.lblingreso.Location = new System.Drawing.Point(238, 186);
            this.lblingreso.Name = "lblingreso";
            this.lblingreso.Size = new System.Drawing.Size(0, 16);
            this.lblingreso.TabIndex = 5;
            // 
            // btningresar
            // 
            this.btningresar.BackColor = System.Drawing.Color.Gray;
            this.btningresar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.btningresar.ForeColor = System.Drawing.Color.DarkRed;
            this.btningresar.Location = new System.Drawing.Point(241, 140);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(94, 32);
            this.btningresar.TabIndex = 4;
            this.btningresar.Text = "Ingresar";
            this.btningresar.UseVisualStyleBackColor = false;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // entpass
            // 
            this.entpass.Font = new System.Drawing.Font("Verdana", 12F);
            this.entpass.Location = new System.Drawing.Point(241, 90);
            this.entpass.Name = "entpass";
            this.entpass.PasswordChar = '*';
            this.entpass.Size = new System.Drawing.Size(141, 27);
            this.entpass.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(127, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contrasena:";
            // 
            // entusuario
            // 
            this.entusuario.Font = new System.Drawing.Font("Verdana", 12F);
            this.entusuario.Location = new System.Drawing.Point(241, 39);
            this.entusuario.Name = "entusuario";
            this.entusuario.Size = new System.Drawing.Size(141, 27);
            this.entusuario.TabIndex = 1;
            this.entusuario.TextChanged += new System.EventHandler(this.entusuario_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(158, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(460, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "V2.0.64";
            // 
            // lbltimer
            // 
            this.lbltimer.AutoSize = true;
            this.lbltimer.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltimer.Location = new System.Drawing.Point(12, 319);
            this.lbltimer.Name = "lbltimer";
            this.lbltimer.Size = new System.Drawing.Size(0, 16);
            this.lbltimer.TabIndex = 3;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(531, 339);
            this.Controls.Add(this.lbltimer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbltitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zona Franca ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Inicio_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.TextBox entpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox entusuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltimer;
        private System.Windows.Forms.Label lblingreso;
    }
}


namespace ZonaFranca
{
    partial class ActualizarEmpleado
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
            this.entcedula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.entdireccion = new System.Windows.Forms.TextBox();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.enttelefono1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.enttelefono2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.entcorreo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.entsueldo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnvolver = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblvalidarcedula = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Actualizacion de datos del empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cedula:";
            // 
            // entcedula
            // 
            this.entcedula.Location = new System.Drawing.Point(91, 58);
            this.entcedula.Name = "entcedula";
            this.entcedula.Size = new System.Drawing.Size(140, 27);
            this.entcedula.TabIndex = 1;
            this.entcedula.TextChanged += new System.EventHandler(this.entcedula_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Direccion:";
            // 
            // entdireccion
            // 
            this.entdireccion.Location = new System.Drawing.Point(100, 111);
            this.entdireccion.Name = "entdireccion";
            this.entdireccion.Size = new System.Drawing.Size(532, 27);
            this.entdireccion.TabIndex = 3;
            this.entdireccion.TextChanged += new System.EventHandler(this.entdireccion_TextChanged);
            // 
            // btnactualizar
            // 
            this.btnactualizar.BackColor = System.Drawing.Color.Gray;
            this.btnactualizar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnactualizar.Location = new System.Drawing.Point(532, 401);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(100, 34);
            this.btnactualizar.TabIndex = 5;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = false;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // enttelefono1
            // 
            this.enttelefono1.Location = new System.Drawing.Point(137, 176);
            this.enttelefono1.Name = "enttelefono1";
            this.enttelefono1.Size = new System.Drawing.Size(265, 27);
            this.enttelefono1.TabIndex = 3;
            this.enttelefono1.TextChanged += new System.EventHandler(this.enttelefono1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Telefono fijo:";
            // 
            // enttelefono2
            // 
            this.enttelefono2.Location = new System.Drawing.Point(154, 237);
            this.enttelefono2.Name = "enttelefono2";
            this.enttelefono2.Size = new System.Drawing.Size(248, 27);
            this.enttelefono2.TabIndex = 3;
            this.enttelefono2.TextChanged += new System.EventHandler(this.enttelefono2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Telefono movil:";
            // 
            // entcorreo
            // 
            this.entcorreo.Location = new System.Drawing.Point(88, 297);
            this.entcorreo.Name = "entcorreo";
            this.entcorreo.Size = new System.Drawing.Size(293, 27);
            this.entcorreo.TabIndex = 3;
            this.entcorreo.TextChanged += new System.EventHandler(this.entcorreo_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "Correo:";
            // 
            // entsueldo
            // 
            this.entsueldo.Location = new System.Drawing.Point(88, 353);
            this.entsueldo.Name = "entsueldo";
            this.entsueldo.Size = new System.Drawing.Size(248, 27);
            this.entsueldo.TabIndex = 3;
            this.entsueldo.TextChanged += new System.EventHandler(this.entsueldo_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 356);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 18);
            this.label10.TabIndex = 2;
            this.label10.Text = "Sueldo:";
            // 
            // btnvolver
            // 
            this.btnvolver.BackColor = System.Drawing.Color.Gray;
            this.btnvolver.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolver.ForeColor = System.Drawing.Color.DarkRed;
            this.btnvolver.Location = new System.Drawing.Point(12, 401);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(84, 34);
            this.btnvolver.TabIndex = 11;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = false;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.Gray;
            this.btnlimpiar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnlimpiar.Location = new System.Drawing.Point(353, 401);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(100, 34);
            this.btnlimpiar.TabIndex = 12;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(97, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(313, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Coloque solo los datos que va a actualizar";
            // 
            // lblvalidarcedula
            // 
            this.lblvalidarcedula.AutoSize = true;
            this.lblvalidarcedula.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalidarcedula.Location = new System.Drawing.Point(247, 65);
            this.lblvalidarcedula.Name = "lblvalidarcedula";
            this.lblvalidarcedula.Size = new System.Drawing.Size(0, 16);
            this.lblvalidarcedula.TabIndex = 14;
            // 
            // ActualizarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(644, 444);
            this.Controls.Add(this.lblvalidarcedula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.entsueldo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.entcorreo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.enttelefono2);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.enttelefono1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.entdireccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.entcedula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ActualizarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar datos del empleado";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ActualizarEmpleado_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox entdireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox entcedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.TextBox enttelefono1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox enttelefono2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox entcorreo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox entsueldo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblvalidarcedula;
    }
}
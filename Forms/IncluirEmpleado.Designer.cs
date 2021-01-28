namespace ZonaFranca
{
    partial class IncluirEmpleado
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
            this.entnombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.entapellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.entcedula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.entdireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.enttelefono1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.enttelefono2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.entcorreo = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.entfecha_nacimiento = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.entfecha_ingreso = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.entsueldo = new System.Windows.Forms.TextBox();
            this.btnincluir = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnvolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inclusion de empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // entnombre
            // 
            this.entnombre.Location = new System.Drawing.Point(101, 92);
            this.entnombre.Name = "entnombre";
            this.entnombre.Size = new System.Drawing.Size(190, 27);
            this.entnombre.TabIndex = 2;
            this.entnombre.TextChanged += new System.EventHandler(this.entnombre_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido:";
            // 
            // entapellido
            // 
            this.entapellido.Location = new System.Drawing.Point(439, 92);
            this.entapellido.Name = "entapellido";
            this.entapellido.Size = new System.Drawing.Size(190, 27);
            this.entapellido.TabIndex = 4;
            this.entapellido.TextChanged += new System.EventHandler(this.entapellido_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cedula:";
            // 
            // entcedula
            // 
            this.entcedula.Location = new System.Drawing.Point(101, 51);
            this.entcedula.Name = "entcedula";
            this.entcedula.Size = new System.Drawing.Size(190, 27);
            this.entcedula.TabIndex = 6;
            this.entcedula.TextChanged += new System.EventHandler(this.entcedula_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Direccion:";
            // 
            // entdireccion
            // 
            this.entdireccion.Location = new System.Drawing.Point(115, 136);
            this.entdireccion.Name = "entdireccion";
            this.entdireccion.Size = new System.Drawing.Size(514, 27);
            this.entdireccion.TabIndex = 8;
            this.entdireccion.TextChanged += new System.EventHandler(this.entdireccion_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Telefono fijo:";
            // 
            // enttelefono1
            // 
            this.enttelefono1.Location = new System.Drawing.Point(140, 185);
            this.enttelefono1.Name = "enttelefono1";
            this.enttelefono1.Size = new System.Drawing.Size(166, 27);
            this.enttelefono1.TabIndex = 10;
            this.enttelefono1.TextChanged += new System.EventHandler(this.enttelefono1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(323, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Telefono movil:";
            // 
            // enttelefono2
            // 
            this.enttelefono2.Location = new System.Drawing.Point(463, 185);
            this.enttelefono2.Name = "enttelefono2";
            this.enttelefono2.Size = new System.Drawing.Size(166, 27);
            this.enttelefono2.TabIndex = 12;
            this.enttelefono2.TextChanged += new System.EventHandler(this.enttelefono2_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Correo electronico:";
            // 
            // entcorreo
            // 
            this.entcorreo.Location = new System.Drawing.Point(189, 232);
            this.entcorreo.Name = "entcorreo";
            this.entcorreo.Size = new System.Drawing.Size(284, 27);
            this.entcorreo.TabIndex = 14;
            this.entcorreo.TextChanged += new System.EventHandler(this.entcorreo_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(312, 283);
            this.dateTimePicker1.MaxDate = new System.DateTime(2020, 8, 4, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(317, 26);
            this.dateTimePicker1.TabIndex = 16;
            this.dateTimePicker1.Value = new System.DateTime(2020, 8, 4, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Fecha de nacimiento:";
            // 
            // entfecha_nacimiento
            // 
            this.entfecha_nacimiento.Location = new System.Drawing.Point(205, 283);
            this.entfecha_nacimiento.Mask = "00/00/0000";
            this.entfecha_nacimiento.Name = "entfecha_nacimiento";
            this.entfecha_nacimiento.Size = new System.Drawing.Size(101, 27);
            this.entfecha_nacimiento.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 326);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 18);
            this.label10.TabIndex = 20;
            this.label10.Text = "Fecha de ingreso:";
            // 
            // entfecha_ingreso
            // 
            this.entfecha_ingreso.Location = new System.Drawing.Point(205, 323);
            this.entfecha_ingreso.Mask = "00/00/0000";
            this.entfecha_ingreso.Name = "entfecha_ingreso";
            this.entfecha_ingreso.Size = new System.Drawing.Size(101, 27);
            this.entfecha_ingreso.TabIndex = 21;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(312, 323);
            this.dateTimePicker2.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(317, 26);
            this.dateTimePicker2.TabIndex = 22;
            this.dateTimePicker2.Value = new System.DateTime(2020, 8, 4, 0, 0, 0, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 369);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 18);
            this.label11.TabIndex = 23;
            this.label11.Text = "Sueldo:";
            // 
            // entsueldo
            // 
            this.entsueldo.Location = new System.Drawing.Point(93, 366);
            this.entsueldo.Name = "entsueldo";
            this.entsueldo.Size = new System.Drawing.Size(213, 27);
            this.entsueldo.TabIndex = 24;
            this.entsueldo.TextChanged += new System.EventHandler(this.entsueldo_TextChanged);
            // 
            // btnincluir
            // 
            this.btnincluir.BackColor = System.Drawing.Color.Gray;
            this.btnincluir.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnincluir.ForeColor = System.Drawing.Color.DarkRed;
            this.btnincluir.Location = new System.Drawing.Point(545, 415);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(87, 34);
            this.btnincluir.TabIndex = 25;
            this.btnincluir.Text = "Incluir";
            this.btnincluir.UseVisualStyleBackColor = false;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.Gray;
            this.btnlimpiar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnlimpiar.Location = new System.Drawing.Point(396, 415);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(87, 34);
            this.btnlimpiar.TabIndex = 26;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnvolver
            // 
            this.btnvolver.BackColor = System.Drawing.Color.Gray;
            this.btnvolver.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolver.ForeColor = System.Drawing.Color.DarkRed;
            this.btnvolver.Location = new System.Drawing.Point(8, 415);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(87, 34);
            this.btnvolver.TabIndex = 27;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = false;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // IncluirEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(644, 461);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnincluir);
            this.Controls.Add(this.entsueldo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.entfecha_ingreso);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.entfecha_nacimiento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.entcorreo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.enttelefono2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.enttelefono1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.entdireccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.entcedula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.entapellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.entnombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IncluirEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incluir Empleado";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IncluirEmpleado_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox entnombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox entapellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox entcedula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox entdireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox enttelefono1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox enttelefono2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox entcorreo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox entfecha_nacimiento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox entfecha_ingreso;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox entsueldo;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnvolver;
    }
}
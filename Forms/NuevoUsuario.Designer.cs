namespace ZonaFranca
{
    partial class NuevoUsuario
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
            this.entusername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.entcedula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbtipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.entclave = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.entconfirmarclave = new System.Windows.Forms.TextBox();
            this.btnincluir = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnvolver = new System.Windows.Forms.Button();
            this.lblvalidacionuser = new System.Windows.Forms.Label();
            this.lblvalidarclave = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Creacion de nuevo usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de usuario:";
            // 
            // entusername
            // 
            this.entusername.Location = new System.Drawing.Point(188, 67);
            this.entusername.Name = "entusername";
            this.entusername.Size = new System.Drawing.Size(209, 27);
            this.entusername.TabIndex = 2;
            this.entusername.TextChanged += new System.EventHandler(this.entusername_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cedula del empleado:";
            // 
            // entcedula
            // 
            this.entcedula.Location = new System.Drawing.Point(206, 122);
            this.entcedula.Name = "entcedula";
            this.entcedula.Size = new System.Drawing.Size(143, 27);
            this.entcedula.TabIndex = 4;
            this.entcedula.TextChanged += new System.EventHandler(this.entcedula_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tipo de usuario:";
            // 
            // cmbtipo
            // 
            this.cmbtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtipo.FormattingEnabled = true;
            this.cmbtipo.Items.AddRange(new object[] {
            "",
            "Administrador",
            "Usuario"});
            this.cmbtipo.Location = new System.Drawing.Point(503, 122);
            this.cmbtipo.Name = "cmbtipo";
            this.cmbtipo.Size = new System.Drawing.Size(129, 26);
            this.cmbtipo.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Clave:";
            // 
            // entclave
            // 
            this.entclave.Location = new System.Drawing.Point(164, 180);
            this.entclave.Name = "entclave";
            this.entclave.PasswordChar = '*';
            this.entclave.Size = new System.Drawing.Size(228, 27);
            this.entclave.TabIndex = 8;
            this.entclave.TextChanged += new System.EventHandler(this.entclave_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Confirmar clave:";
            // 
            // entconfirmarclave
            // 
            this.entconfirmarclave.Location = new System.Drawing.Point(164, 245);
            this.entconfirmarclave.Name = "entconfirmarclave";
            this.entconfirmarclave.PasswordChar = '*';
            this.entconfirmarclave.Size = new System.Drawing.Size(228, 27);
            this.entconfirmarclave.TabIndex = 10;
            this.entconfirmarclave.TextChanged += new System.EventHandler(this.entconfirmarclave_TextChanged);
            // 
            // btnincluir
            // 
            this.btnincluir.BackColor = System.Drawing.Color.Gray;
            this.btnincluir.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnincluir.ForeColor = System.Drawing.Color.DarkRed;
            this.btnincluir.Location = new System.Drawing.Point(545, 325);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(87, 34);
            this.btnincluir.TabIndex = 14;
            this.btnincluir.Text = "Crear";
            this.btnincluir.UseVisualStyleBackColor = false;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.Gray;
            this.btnlimpiar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnlimpiar.Location = new System.Drawing.Point(393, 325);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(87, 34);
            this.btnlimpiar.TabIndex = 16;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnvolver
            // 
            this.btnvolver.BackColor = System.Drawing.Color.Gray;
            this.btnvolver.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolver.ForeColor = System.Drawing.Color.DarkRed;
            this.btnvolver.Location = new System.Drawing.Point(12, 325);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(87, 34);
            this.btnvolver.TabIndex = 17;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = false;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // lblvalidacionuser
            // 
            this.lblvalidacionuser.AutoSize = true;
            this.lblvalidacionuser.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalidacionuser.Location = new System.Drawing.Point(185, 97);
            this.lblvalidacionuser.Name = "lblvalidacionuser";
            this.lblvalidacionuser.Size = new System.Drawing.Size(0, 14);
            this.lblvalidacionuser.TabIndex = 18;
            // 
            // lblvalidarclave
            // 
            this.lblvalidarclave.AutoSize = true;
            this.lblvalidarclave.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalidarclave.Location = new System.Drawing.Point(398, 252);
            this.lblvalidarclave.Name = "lblvalidarclave";
            this.lblvalidarclave.Size = new System.Drawing.Size(0, 14);
            this.lblvalidarclave.TabIndex = 19;
            // 
            // NuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(644, 371);
            this.Controls.Add(this.lblvalidarclave);
            this.Controls.Add(this.lblvalidacionuser);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnincluir);
            this.Controls.Add(this.entconfirmarclave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.entclave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbtipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.entcedula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.entusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NuevoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Nuevo Usuario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NuevoUsuario_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox entusername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox entcedula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbtipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox entclave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox entconfirmarclave;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Label lblvalidacionuser;
        private System.Windows.Forms.Label lblvalidarclave;
    }
}
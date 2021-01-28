namespace ZonaFranca
{
    partial class OtrasOpciones
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
            this.entdolar = new System.Windows.Forms.TextBox();
            this.btnactualizardolar = new System.Windows.Forms.Button();
            this.btnvolver = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblvalidarclave = new System.Windows.Forms.Label();
            this.btnactualizarclave = new System.Windows.Forms.Button();
            this.entconfirmarclave = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.entclavenueva = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.entclaveantigua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Otras opciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio del dolar:";
            // 
            // entdolar
            // 
            this.entdolar.Location = new System.Drawing.Point(154, 42);
            this.entdolar.Name = "entdolar";
            this.entdolar.Size = new System.Drawing.Size(222, 27);
            this.entdolar.TabIndex = 2;
            this.entdolar.TextChanged += new System.EventHandler(this.entdolar_TextChanged);
            // 
            // btnactualizardolar
            // 
            this.btnactualizardolar.BackColor = System.Drawing.Color.Gray;
            this.btnactualizardolar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizardolar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnactualizardolar.Location = new System.Drawing.Point(415, 42);
            this.btnactualizardolar.Name = "btnactualizardolar";
            this.btnactualizardolar.Size = new System.Drawing.Size(108, 32);
            this.btnactualizardolar.TabIndex = 3;
            this.btnactualizardolar.Text = "Actualizar";
            this.btnactualizardolar.UseVisualStyleBackColor = false;
            this.btnactualizardolar.Click += new System.EventHandler(this.btnactualizardolar_Click);
            // 
            // btnvolver
            // 
            this.btnvolver.BackColor = System.Drawing.Color.Gray;
            this.btnvolver.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolver.ForeColor = System.Drawing.Color.DarkRed;
            this.btnvolver.Location = new System.Drawing.Point(12, 418);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(87, 30);
            this.btnvolver.TabIndex = 4;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = false;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.entdolar);
            this.groupBox1.Controls.Add(this.btnactualizardolar);
            this.groupBox1.Location = new System.Drawing.Point(24, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 117);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actualizacion del precio del dolar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblvalidarclave);
            this.groupBox2.Controls.Add(this.btnactualizarclave);
            this.groupBox2.Controls.Add(this.entconfirmarclave);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.entclavenueva);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.entclaveantigua);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(25, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(605, 223);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actualizacion de clave de usuario";
            // 
            // lblvalidarclave
            // 
            this.lblvalidarclave.AutoSize = true;
            this.lblvalidarclave.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalidarclave.Location = new System.Drawing.Point(279, 183);
            this.lblvalidarclave.Name = "lblvalidarclave";
            this.lblvalidarclave.Size = new System.Drawing.Size(0, 16);
            this.lblvalidarclave.TabIndex = 26;
            // 
            // btnactualizarclave
            // 
            this.btnactualizarclave.BackColor = System.Drawing.Color.Gray;
            this.btnactualizarclave.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizarclave.ForeColor = System.Drawing.Color.DarkRed;
            this.btnactualizarclave.Location = new System.Drawing.Point(499, 183);
            this.btnactualizarclave.Name = "btnactualizarclave";
            this.btnactualizarclave.Size = new System.Drawing.Size(100, 34);
            this.btnactualizarclave.TabIndex = 25;
            this.btnactualizarclave.Text = "Actualizar";
            this.btnactualizarclave.UseVisualStyleBackColor = false;
            this.btnactualizarclave.Click += new System.EventHandler(this.btnactualizarclave_Click);
            // 
            // entconfirmarclave
            // 
            this.entconfirmarclave.Location = new System.Drawing.Point(282, 140);
            this.entconfirmarclave.Name = "entconfirmarclave";
            this.entconfirmarclave.PasswordChar = '*';
            this.entconfirmarclave.Size = new System.Drawing.Size(196, 27);
            this.entconfirmarclave.TabIndex = 24;
            this.entconfirmarclave.TextChanged += new System.EventHandler(this.entconfirmarclave_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Clave antigua:";
            // 
            // entclavenueva
            // 
            this.entclavenueva.Location = new System.Drawing.Point(282, 88);
            this.entclavenueva.Name = "entclavenueva";
            this.entclavenueva.PasswordChar = '*';
            this.entclavenueva.Size = new System.Drawing.Size(196, 27);
            this.entclavenueva.TabIndex = 23;
            this.entclavenueva.TextChanged += new System.EventHandler(this.entclavenueva_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Confirmar clave nueva:";
            // 
            // entclaveantigua
            // 
            this.entclaveantigua.Location = new System.Drawing.Point(282, 36);
            this.entclaveantigua.Name = "entclaveantigua";
            this.entclaveantigua.PasswordChar = '*';
            this.entclaveantigua.Size = new System.Drawing.Size(196, 27);
            this.entclaveantigua.TabIndex = 20;
            this.entclaveantigua.TextChanged += new System.EventHandler(this.entclaveantigua_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Clave nueva:";
            // 
            // OtrasOpciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(644, 452);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "OtrasOpciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otras Opciones";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OtrasOpciones_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox entdolar;
        private System.Windows.Forms.Button btnactualizardolar;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnactualizarclave;
        private System.Windows.Forms.TextBox entconfirmarclave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox entclavenueva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox entclaveantigua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblvalidarclave;
    }
}
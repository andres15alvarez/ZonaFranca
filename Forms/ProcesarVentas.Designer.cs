namespace ZonaFranca
{
    partial class ProcesarVentas
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
            this.entcodigo = new System.Windows.Forms.TextBox();
            this.btngenerarfactura = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btncarrito = new System.Windows.Forms.Button();
            this.btnvolver = new System.Windows.Forms.Button();
            this.lblcarrito = new System.Windows.Forms.Label();
            this.btnvercarrito = new System.Windows.Forms.Button();
            this.btnlimpiarcarrito = new System.Windows.Forms.Button();
            this.listcarrito = new System.Windows.Forms.ListBox();
            this.btnfacturar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.gdvarticulo = new System.Windows.Forms.DataGridView();
            this.entcantidad = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.entcorreo = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.enttelefono = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.entapellido = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.entnombre = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblvalidarcedula = new System.Windows.Forms.Label();
            this.entcedula = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.listfactura = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.entdolar = new System.Windows.Forms.TextBox();
            this.entefectivo = new System.Windows.Forms.TextBox();
            this.entdebito = new System.Windows.Forms.TextBox();
            this.enttransferencia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gdvarticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entcantidad)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Procesamiento de ventas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo del articulo:";
            // 
            // entcodigo
            // 
            this.entcodigo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entcodigo.Location = new System.Drawing.Point(194, 67);
            this.entcodigo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.entcodigo.Name = "entcodigo";
            this.entcodigo.Size = new System.Drawing.Size(144, 27);
            this.entcodigo.TabIndex = 2;
            // 
            // btngenerarfactura
            // 
            this.btngenerarfactura.BackColor = System.Drawing.Color.Gray;
            this.btngenerarfactura.Enabled = false;
            this.btngenerarfactura.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerarfactura.ForeColor = System.Drawing.Color.DarkRed;
            this.btngenerarfactura.Location = new System.Drawing.Point(1020, 322);
            this.btngenerarfactura.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btngenerarfactura.Name = "btngenerarfactura";
            this.btngenerarfactura.Size = new System.Drawing.Size(92, 45);
            this.btngenerarfactura.TabIndex = 4;
            this.btngenerarfactura.Text = "Generar factura";
            this.btngenerarfactura.UseVisualStyleBackColor = false;
            this.btngenerarfactura.Click += new System.EventHandler(this.btngenerarfactura_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(360, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cantidad:";
            // 
            // btncarrito
            // 
            this.btncarrito.BackColor = System.Drawing.Color.Gray;
            this.btncarrito.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncarrito.ForeColor = System.Drawing.Color.DarkRed;
            this.btncarrito.Location = new System.Drawing.Point(602, 59);
            this.btncarrito.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btncarrito.Name = "btncarrito";
            this.btncarrito.Size = new System.Drawing.Size(96, 41);
            this.btncarrito.TabIndex = 8;
            this.btncarrito.Text = "Anadir al carrito";
            this.btncarrito.UseVisualStyleBackColor = false;
            this.btncarrito.Click += new System.EventHandler(this.btncarrito_Click);
            // 
            // btnvolver
            // 
            this.btnvolver.BackColor = System.Drawing.Color.Gray;
            this.btnvolver.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolver.ForeColor = System.Drawing.Color.DarkRed;
            this.btnvolver.Location = new System.Drawing.Point(18, 683);
            this.btnvolver.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(94, 27);
            this.btnvolver.TabIndex = 9;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = false;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // lblcarrito
            // 
            this.lblcarrito.AutoSize = true;
            this.lblcarrito.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcarrito.Location = new System.Drawing.Point(708, 76);
            this.lblcarrito.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblcarrito.Name = "lblcarrito";
            this.lblcarrito.Size = new System.Drawing.Size(70, 18);
            this.lblcarrito.TabIndex = 11;
            this.lblcarrito.Text = "Carrito:";
            // 
            // btnvercarrito
            // 
            this.btnvercarrito.BackColor = System.Drawing.Color.Gray;
            this.btnvercarrito.Enabled = false;
            this.btnvercarrito.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvercarrito.ForeColor = System.Drawing.Color.DarkRed;
            this.btnvercarrito.Location = new System.Drawing.Point(1016, 72);
            this.btnvercarrito.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnvercarrito.Name = "btnvercarrito";
            this.btnvercarrito.Size = new System.Drawing.Size(96, 28);
            this.btnvercarrito.TabIndex = 12;
            this.btnvercarrito.Text = "Ver carrito";
            this.btnvercarrito.UseVisualStyleBackColor = false;
            this.btnvercarrito.Click += new System.EventHandler(this.btnvercarrito_Click);
            // 
            // btnlimpiarcarrito
            // 
            this.btnlimpiarcarrito.BackColor = System.Drawing.Color.Gray;
            this.btnlimpiarcarrito.Enabled = false;
            this.btnlimpiarcarrito.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiarcarrito.ForeColor = System.Drawing.Color.DarkRed;
            this.btnlimpiarcarrito.Location = new System.Drawing.Point(18, 317);
            this.btnlimpiarcarrito.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnlimpiarcarrito.Name = "btnlimpiarcarrito";
            this.btnlimpiarcarrito.Size = new System.Drawing.Size(94, 42);
            this.btnlimpiarcarrito.TabIndex = 14;
            this.btnlimpiarcarrito.Text = "Limpiar carrito";
            this.btnlimpiarcarrito.UseVisualStyleBackColor = false;
            this.btnlimpiarcarrito.Click += new System.EventHandler(this.btnlimpiarcarrito_Click);
            // 
            // listcarrito
            // 
            this.listcarrito.Font = new System.Drawing.Font("Verdana", 12F);
            this.listcarrito.FormattingEnabled = true;
            this.listcarrito.HorizontalScrollbar = true;
            this.listcarrito.ItemHeight = 18;
            this.listcarrito.Location = new System.Drawing.Point(711, 102);
            this.listcarrito.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.listcarrito.Name = "listcarrito";
            this.listcarrito.Size = new System.Drawing.Size(401, 202);
            this.listcarrito.TabIndex = 15;
            // 
            // btnfacturar
            // 
            this.btnfacturar.BackColor = System.Drawing.Color.Gray;
            this.btnfacturar.Enabled = false;
            this.btnfacturar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfacturar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnfacturar.Location = new System.Drawing.Point(996, 263);
            this.btnfacturar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnfacturar.Name = "btnfacturar";
            this.btnfacturar.Size = new System.Drawing.Size(90, 39);
            this.btnfacturar.TabIndex = 25;
            this.btnfacturar.Text = "Facturar";
            this.btnfacturar.UseVisualStyleBackColor = false;
            this.btnfacturar.Click += new System.EventHandler(this.btnfacturar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.Gray;
            this.btncancelar.Enabled = false;
            this.btncancelar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.DarkRed;
            this.btncancelar.Location = new System.Drawing.Point(811, 269);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(95, 33);
            this.btncancelar.TabIndex = 29;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // gdvarticulo
            // 
            this.gdvarticulo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gdvarticulo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gdvarticulo.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gdvarticulo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.gdvarticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvarticulo.Location = new System.Drawing.Point(18, 102);
            this.gdvarticulo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gdvarticulo.MultiSelect = false;
            this.gdvarticulo.Name = "gdvarticulo";
            this.gdvarticulo.ReadOnly = true;
            this.gdvarticulo.RowHeadersWidth = 40;
            this.gdvarticulo.Size = new System.Drawing.Size(680, 202);
            this.gdvarticulo.TabIndex = 30;
            this.gdvarticulo.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvarticulo_CellContentDoubleClick);
            // 
            // entcantidad
            // 
            this.entcantidad.Location = new System.Drawing.Point(456, 67);
            this.entcantidad.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.entcantidad.Name = "entcantidad";
            this.entcantidad.Size = new System.Drawing.Size(87, 27);
            this.entcantidad.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(758, 18);
            this.label10.TabIndex = 32;
            this.label10.Text = "Ingrese el codigo del articulo junto con la cantidad a vender. Puede ingresar var" +
    "ios articulos al carrito.\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.entcorreo);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.enttelefono);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.entapellido);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.entnombre);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.lblvalidarcedula);
            this.groupBox1.Controls.Add(this.entcedula);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.listfactura);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.entdolar);
            this.groupBox1.Controls.Add(this.btncancelar);
            this.groupBox1.Controls.Add(this.entefectivo);
            this.groupBox1.Controls.Add(this.btnfacturar);
            this.groupBox1.Controls.Add(this.entdebito);
            this.groupBox1.Controls.Add(this.enttransferencia);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(18, 367);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1094, 309);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Facturacion";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkRed;
            this.label13.Location = new System.Drawing.Point(494, 44);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 18);
            this.label13.TabIndex = 52;
            this.label13.Text = "Datos del cliente";
            // 
            // entcorreo
            // 
            this.entcorreo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entcorreo.Location = new System.Drawing.Point(532, 263);
            this.entcorreo.Name = "entcorreo";
            this.entcorreo.Size = new System.Drawing.Size(268, 27);
            this.entcorreo.TabIndex = 51;
            this.entcorreo.TextChanged += new System.EventHandler(this.entcorreo_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(435, 266);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 18);
            this.label17.TabIndex = 50;
            this.label17.Text = "Correo:";
            // 
            // enttelefono
            // 
            this.enttelefono.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enttelefono.Location = new System.Drawing.Point(532, 214);
            this.enttelefono.Name = "enttelefono";
            this.enttelefono.Size = new System.Drawing.Size(268, 27);
            this.enttelefono.TabIndex = 49;
            this.enttelefono.TextChanged += new System.EventHandler(this.enttelefono_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(435, 217);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 18);
            this.label16.TabIndex = 48;
            this.label16.Text = "Telefono:";
            // 
            // entapellido
            // 
            this.entapellido.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entapellido.Location = new System.Drawing.Point(532, 169);
            this.entapellido.Name = "entapellido";
            this.entapellido.Size = new System.Drawing.Size(268, 27);
            this.entapellido.TabIndex = 47;
            this.entapellido.TextChanged += new System.EventHandler(this.entapellido_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(435, 172);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 18);
            this.label15.TabIndex = 46;
            this.label15.Text = "Apellidos:";
            // 
            // entnombre
            // 
            this.entnombre.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entnombre.Location = new System.Drawing.Point(532, 124);
            this.entnombre.Name = "entnombre";
            this.entnombre.Size = new System.Drawing.Size(268, 27);
            this.entnombre.TabIndex = 45;
            this.entnombre.TextChanged += new System.EventHandler(this.entnombre_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(438, 127);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 18);
            this.label14.TabIndex = 44;
            this.label14.Text = "Nombres:";
            // 
            // lblvalidarcedula
            // 
            this.lblvalidarcedula.AutoSize = true;
            this.lblvalidarcedula.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalidarcedula.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblvalidarcedula.Location = new System.Drawing.Point(529, 93);
            this.lblvalidarcedula.Name = "lblvalidarcedula";
            this.lblvalidarcedula.Size = new System.Drawing.Size(0, 18);
            this.lblvalidarcedula.TabIndex = 43;
            // 
            // entcedula
            // 
            this.entcedula.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entcedula.Location = new System.Drawing.Point(532, 63);
            this.entcedula.Name = "entcedula";
            this.entcedula.Size = new System.Drawing.Size(138, 27);
            this.entcedula.TabIndex = 42;
            this.entcedula.TextChanged += new System.EventHandler(this.entcedula_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(448, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 18);
            this.label12.TabIndex = 41;
            this.label12.Text = "Cedula:";
            // 
            // listfactura
            // 
            this.listfactura.Font = new System.Drawing.Font("Verdana", 12F);
            this.listfactura.FormattingEnabled = true;
            this.listfactura.HorizontalScrollbar = true;
            this.listfactura.ItemHeight = 18;
            this.listfactura.Location = new System.Drawing.Point(8, 66);
            this.listfactura.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.listfactura.Name = "listfactura";
            this.listfactura.Size = new System.Drawing.Size(419, 220);
            this.listfactura.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(8, 44);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 18);
            this.label9.TabIndex = 39;
            this.label9.Text = "Factura";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(873, 27);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 18);
            this.label8.TabIndex = 38;
            this.label8.Text = "Forma de pago";
            // 
            // entdolar
            // 
            this.entdolar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entdolar.Location = new System.Drawing.Point(941, 227);
            this.entdolar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.entdolar.Name = "entdolar";
            this.entdolar.Size = new System.Drawing.Size(145, 27);
            this.entdolar.TabIndex = 37;
            this.entdolar.Text = "0";
            this.entdolar.TextChanged += new System.EventHandler(this.entdolar_TextChanged);
            // 
            // entefectivo
            // 
            this.entefectivo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entefectivo.Location = new System.Drawing.Point(941, 172);
            this.entefectivo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.entefectivo.Name = "entefectivo";
            this.entefectivo.Size = new System.Drawing.Size(145, 27);
            this.entefectivo.TabIndex = 36;
            this.entefectivo.Text = "0";
            this.entefectivo.TextChanged += new System.EventHandler(this.entefectivo_TextChanged);
            // 
            // entdebito
            // 
            this.entdebito.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entdebito.Location = new System.Drawing.Point(941, 54);
            this.entdebito.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.entdebito.Name = "entdebito";
            this.entdebito.Size = new System.Drawing.Size(145, 27);
            this.entdebito.TabIndex = 35;
            this.entdebito.Text = "0";
            this.entdebito.TextChanged += new System.EventHandler(this.entdebito_TextChanged);
            // 
            // enttransferencia
            // 
            this.enttransferencia.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enttransferencia.Location = new System.Drawing.Point(941, 113);
            this.enttransferencia.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.enttransferencia.Name = "enttransferencia";
            this.enttransferencia.Size = new System.Drawing.Size(145, 27);
            this.enttransferencia.TabIndex = 34;
            this.enttransferencia.Text = "0";
            this.enttransferencia.TextChanged += new System.EventHandler(this.enttransferencia_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(808, 57);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 18);
            this.label7.TabIndex = 33;
            this.label7.Text = "Debito:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(808, 116);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 18);
            this.label6.TabIndex = 32;
            this.label6.Text = "Transferencia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(808, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 31;
            this.label5.Text = "Efectivo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(808, 230);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 30;
            this.label4.Text = "Dolar:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 11F);
            this.label11.Location = new System.Drawing.Point(860, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(244, 36);
            this.label11.TabIndex = 34;
            this.label11.Text = "Para ver el contenido del carrito\r\npulse el boton \"Ver carrito\".";
            // 
            // ProcesarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1126, 711);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.entcantidad);
            this.Controls.Add(this.gdvarticulo);
            this.Controls.Add(this.listcarrito);
            this.Controls.Add(this.btnlimpiarcarrito);
            this.Controls.Add(this.btnvercarrito);
            this.Controls.Add(this.lblcarrito);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.btncarrito);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btngenerarfactura);
            this.Controls.Add(this.entcodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ProcesarVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procesar Ventas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProcesarVentas_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.gdvarticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entcantidad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox entcodigo;
        private System.Windows.Forms.Button btngenerarfactura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncarrito;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Label lblcarrito;
        private System.Windows.Forms.Button btnvercarrito;
        private System.Windows.Forms.Button btnlimpiarcarrito;
        private System.Windows.Forms.ListBox listcarrito;
        private System.Windows.Forms.Button btnfacturar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.DataGridView gdvarticulo;
        private System.Windows.Forms.NumericUpDown entcantidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox entcorreo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox enttelefono;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox entapellido;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox entnombre;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblvalidarcedula;
        private System.Windows.Forms.TextBox entcedula;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox listfactura;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox entdolar;
        private System.Windows.Forms.TextBox entefectivo;
        private System.Windows.Forms.TextBox entdebito;
        private System.Windows.Forms.TextBox enttransferencia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
    }
}
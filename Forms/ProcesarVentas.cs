using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace ZonaFranca
{
    public partial class ProcesarVentas : Validaciones
    {
        double dolar;
        List<Carrito> vcarrito = new List<Carrito>();
        string user, name, tipo;
        public ProcesarVentas(string nombre, string username, string tipouser)
        {
            InitializeComponent();
            CargarList();
            user = username;
            name = nombre;
            tipo = tipouser;
            dolar = Dolar();
        }

        private void ProcesarVentas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void entcedula_TextChanged(object sender, EventArgs e)
        {
            ValidarNro(entcedula);
            ValidarLimiteEntrada(entcedula, 10);
            ValidarCedula();
        }

        private void entnombre_TextChanged(object sender, EventArgs e)
        {
            ValidarAlfaEspacio(entnombre);
            ValidarLimiteEntrada(entnombre, 30);
        }

        private void entapellido_TextChanged(object sender, EventArgs e)
        {
            ValidarAlfaEspacio(entapellido);
            ValidarLimiteEntrada(entapellido, 30);
        }

        private void enttelefono_TextChanged(object sender, EventArgs e)
        {
            ValidarNro(enttelefono);
            ValidarLimiteEntrada(enttelefono, 12);
        }

        private void entcorreo_TextChanged(object sender, EventArgs e)
        {
            ValidarLimiteEntrada(entcorreo, 50);
        }

        private void entdebito_TextChanged(object sender, EventArgs e)
        {
            ValidarNroDecimal(entdebito);
            ValidarLimiteEntrada(entdebito, 17);
        }

        private void enttransferencia_TextChanged(object sender, EventArgs e)
        {
            ValidarNroDecimal(entdebito);
            ValidarLimiteEntrada(entdebito, 17);

        }

        private void entefectivo_TextChanged(object sender, EventArgs e)
        {
            ValidarNroDecimal(entefectivo);
            ValidarLimiteEntrada(entefectivo, 17);
        }

        private void entdolar_TextChanged(object sender, EventArgs e)
        {
            ValidarNroDecimal(entdolar);
            ValidarLimiteEntrada(entdolar, 17);
        }

        // METODOS CON LOS BOTONES

        private void btnvolver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(name, user, tipo);
            this.Hide();
            menu.Show();
        }

        private void btncarrito_Click(object sender, EventArgs e)
        {
            if(entcodigo.Text == "" || entcantidad.Value == 0)
            {
                string mensaje = "Debe llenar todos los campos";
                string caption = "Error al ingresar los datos";
                MessageBoxButtons boton = MessageBoxButtons.OK;
                MessageBoxIcon icono = MessageBoxIcon.Warning;
                DialogResult result;
                result = MessageBox.Show(mensaje, caption, boton, icono);
            }
            else
                Buscar();
        }

        private void gdvarticulo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            entcodigo.Text = gdvarticulo.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnvercarrito_Click(object sender, EventArgs e)
        {
            int len = vcarrito.Count();
            listcarrito.Items.Clear();
            for (int i=0; i < len; i++)
            {
                string item = vcarrito[i].GetCodigo() + " " + vcarrito[i].GetNombre() + " " + vcarrito[i].GetCantidad().ToString() + " X " +vcarrito[i].GetPrecio().ToString() + " = " + vcarrito[i].Subtotal().ToString();
                listcarrito.Items.Add(item);
            }
        }

        private void btngenerarfactura_Click(object sender, EventArgs e)
        {
            int len = vcarrito.Count();
            listfactura.Items.Clear();
            for(int i =0; i < len; i++)
            {
                string item = vcarrito[i].GetCodigo() + " " + vcarrito[i].GetNombre() + " " + vcarrito[i].GetCantidad().ToString() + " X " + vcarrito[i].GetPrecio().ToString()+" = "+vcarrito[i].Subtotal().ToString();
                listfactura.Items.Add(item);
            }
            listfactura.Items.Add("----------------------------------------------------");
            listfactura.Items.Add("Monto total: "+MontoFactura().ToString());
            entdebito.Text = MontoFactura().ToString();
            btnlimpiarcarrito.Enabled = false;
            btncancelar.Enabled = true;
        }

        private void btnlimpiarcarrito_Click(object sender, EventArgs e)
        {
            vcarrito.Clear();
            listcarrito.Items.Clear();
            btnlimpiarcarrito.Enabled = false;
            btnvercarrito.Enabled = false;
            btngenerarfactura.Enabled = false;
        }

        private void btnfacturar_Click(object sender, EventArgs e)
        {
            MySql.ConectorBD bd = new MySql.ConectorBD();
            if (ValidarPago())
            {
                if (!bd.VerificarExistencia("cliente", "cedula", entcedula.Text))
                {
                    if (entnombre.Text == "" || entapellido.Text == "" || enttelefono.Text == "" || entcorreo.Text == "")
                    {
                        string mensaje = "Debe llenar todos los campos del cliente.";
                        string caption = "Error al ingresar los datos.";
                        MessageBoxButtons boton = MessageBoxButtons.OK;
                        MessageBoxIcon icono = MessageBoxIcon.Information;
                        DialogResult result;
                        result = MessageBox.Show(mensaje, caption, boton, icono);
                    }
                    else
                        IncluirCliente();
                }
                    Facturar();
                    CargarList();
                    vcarrito.Clear();
                    listfactura.Items.Clear();
                    listcarrito.Items.Clear();
                    entcedula.Text = "";
                    entnombre.Text = "";
                    entapellido.Text = "";
                    enttelefono.Text = "";
                    entcorreo.Text = "";
                    entdebito.Text = "0";
                    enttransferencia.Text = "0";
                    entefectivo.Text = "0";
                    entdolar.Text = "0";
                    btnvercarrito.Enabled = false;
                    btngenerarfactura.Enabled = false;
                    btnlimpiarcarrito.Enabled = false;
                    btnfacturar.Enabled = false;
                    btncancelar.Enabled = false;
            }
            else
            {
                string mensaje = "El monto ingresado en la forma de pago no coincide con el monto de la factura. \nPor favor verifique.";
                string caption = "Error al ingresar el monto";
                MessageBoxButtons boton = MessageBoxButtons.OK;
                MessageBoxIcon icono = MessageBoxIcon.Warning;
                DialogResult result;
                result = MessageBox.Show(mensaje, caption, boton, icono);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            vcarrito.Clear();
            listfactura.Items.Clear();
            listcarrito.Items.Clear();
            entdebito.Text = "0";
            enttransferencia.Text = "0";
            entefectivo.Text = "0";
            entdolar.Text = "0";
            btnvercarrito.Enabled = false;
            btngenerarfactura.Enabled = false;
            btnlimpiarcarrito.Enabled = false;
            btnfacturar.Enabled = false;
            btncancelar.Enabled = false;
        }

        // METODOS PARA CONECTARSE CON LA BASE DE DATOS

        private void CargarList()
        {
            // CARGA LA LISTA DE ARTICULOS EN EL DATAGRIDVIEW
            ActualizarList();
            MySql.ConectorBD bd = new MySql.ConectorBD();
            bd.Conectar();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT codigo, nombre, descripcion, precio, stock as 'cantidad' FROM articulo WHERE estatus='A';", bd.con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "articulo");
            gdvarticulo.DataSource = ds.Tables["articulo"];
            bd.Desconectar();
        }

        private void ActualizarList()
        {
            MySql.ConectorBD bd = new MySql.ConectorBD();
            bd.Conectar();
            bd.cmd = new MySqlCommand("UPDATE articulo SET estatus='E' WHERE stock=0 AND estatus='A';", bd.con);
            bd.cmd.ExecuteNonQuery();
            bd.cmd = new MySqlCommand("UPDATE articulo SET estatus='A' WHERE stock>0 AND estatus='E';", bd.con);
            bd.cmd.ExecuteNonQuery();
            bd.Desconectar();
        }

        private void Buscar()
        {
            // BUSCA EL ARTICULO QUE VA A SER INLCUIDO AL CARRITO
            MySql.ConectorBD bd = new MySql.ConectorBD();
            bd.Conectar();
            bd.cmd = new MySqlCommand("SELECT nombre, precio, stock FROM articulo WHERE codigo=?codigo AND estatus='A';", bd.con);
            bd.cmd.Parameters.Add("?codigo", MySqlDbType.VarChar).Value = entcodigo.Text;
            bd.dr = bd.cmd.ExecuteReader();
            if (bd.dr.Read())
            {
                string nombre = bd.dr[0].ToString();
                double precio = Double.Parse(bd.dr[1].ToString());
                int stock = Convert.ToInt16(bd.dr[2].ToString());
                bd.dr.Close();
                bd.Desconectar();
                int cantidad = Convert.ToInt16(entcantidad.Value);
                // VERIFICA QUE LA CANTIDAD INGRESADA NO SEA MENOR QUE EL STOCK
                if (cantidad <= stock)
                {
                    // CREA EL OBJETO Y LO INLCUYE A LA LISTACARRITO
                    Carrito carrito = new Carrito();
                    carrito.SetCodigo(entcodigo.Text);
                    int indice = BuscarArticulo(entcodigo.Text);
                    entcodigo.Text = "";
                    entcantidad.Value = 0;
                    if (indice==-1)
                    {
                        carrito.SetNombre(nombre);
                        carrito.SetPrecio(precio);
                        carrito.SetCantidad(cantidad);
                        vcarrito.Add(carrito);
                        btnvercarrito.Enabled = true;
                        btngenerarfactura.Enabled = true;
                        btnlimpiarcarrito.Enabled = true;
                    }
                    else
                    {
                        int cantaumentada = cantidad + vcarrito[indice].GetCantidad();
                        vcarrito[indice].SetCantidad(cantaumentada);
                    }
                }
                else
                {
                    entcantidad.Value = 0;
                    string mensaje = "La cantidad ingresada es mayor que la existente";
                    string caption = "Error al ingresar la cantidad";
                    MessageBoxButtons boton = MessageBoxButtons.OK;
                    MessageBoxIcon icono = MessageBoxIcon.Warning;
                    DialogResult result;
                    result = MessageBox.Show(mensaje, caption, boton, icono);
                }
            }
            else
            {
                string mensaje = "No se entraron resultados. \nVerifique el codigo";
                string caption = "Error al buscar el articulo";
                MessageBoxButtons boton = MessageBoxButtons.OK;
                MessageBoxIcon icono = MessageBoxIcon.Error;
                DialogResult result;
                result = MessageBox.Show(mensaje, caption, boton, icono);
                bd.dr.Close();
                bd.Desconectar();
            }

        }

        private void Facturar()
        {
            MySql.ConectorBD bd = new MySql.ConectorBD();
            bd.Conectar();
            bd.cmd = new MySqlCommand("INSERT INTO factura(usuario, ced_cliente, fecha_venta, hora_venta, monto, pago_debito, pago_transferencia, pago_efectivo, pago_dolar, estatus) values(?usuario, ?cedula, current_date(), current_time(), ?monto, ?debito, ?transferencia, ?efectivo, ?dolar, 'A');", bd.con);
            bd.cmd.Parameters.Add("?usuario", MySqlDbType.VarChar).Value = user;
            bd.cmd.Parameters.Add("?cedula", MySqlDbType.VarChar).Value = entcedula.Text;
            bd.cmd.Parameters.Add("?monto", MySqlDbType.Double).Value = MontoFactura();
            bd.cmd.Parameters.Add("?debito", MySqlDbType.Double).Value = double.Parse(entdebito.Text);
            bd.cmd.Parameters.Add("?transferencia", MySqlDbType.Double).Value = double.Parse(enttransferencia.Text);
            bd.cmd.Parameters.Add("?efectivo", MySqlDbType.Double).Value = double.Parse(entefectivo.Text);
            bd.cmd.Parameters.Add("dolar", MySqlDbType.Double).Value = double.Parse(entdolar.Text);
            if (bd.cmd.ExecuteNonQuery() > 0)
            {
                int len = vcarrito.Count();
                for (int i = 0; i < len; i++)
                {
                    bd.cmd = new MySqlCommand("INSERT INTO artfactura values((SELECT last_insert_id() FROM factura LIMIT 1), ?codigo, ?cantidad, ?total);", bd.con);
                    bd.cmd.Parameters.Add("?codigo", MySqlDbType.VarChar).Value = vcarrito[i].GetCodigo();
                    bd.cmd.Parameters.Add("?cantidad", MySqlDbType.Int16).Value = vcarrito[i].GetCantidad();
                    bd.cmd.Parameters.Add("?total", MySqlDbType.Double).Value = vcarrito[i].Subtotal();
                    bd.cmd.ExecuteNonQuery();
                    bd.cmd = new MySqlCommand("UPDATE articulo SET stock = stock - ?cant WHERE codigo = ?codigo AND estatus = 'A';", bd.con);
                    bd.cmd.Parameters.Add("?cant", MySqlDbType.Int16).Value = vcarrito[i].GetCantidad();
                    bd.cmd.Parameters.Add("?codigo", MySqlDbType.VarChar).Value = vcarrito[i].GetCodigo();
                    bd.cmd.ExecuteNonQuery();
                }
                bd.Desconectar();
            }
            else
            {
                bd.Desconectar();
                string mensaje = "No se pudo guardar la factura debido a un error imprevisto.";
                string caption = "Error al facturar";
                MessageBoxButtons boton = MessageBoxButtons.OK;
                MessageBoxIcon icono = MessageBoxIcon.Error;
                DialogResult result;
                result = MessageBox.Show(mensaje, caption, boton, icono);
            }
        }

        private void IncluirCliente()
        {
            MySql.ConectorBD bd = new MySql.ConectorBD();
            if(!bd.VerificarExistencia("cliente", "cedula", entcedula.Text))
            {
                bd.Conectar();
                bd.cmd = new MySqlCommand("INSERT INTO cliente VALUES(?cedula, ?nombre, ?apellido, ?telefono, ?correo, 'A');", bd.con);
                bd.cmd.Parameters.Add("?cedula", MySqlDbType.VarChar).Value = entcedula.Text;
                bd.cmd.Parameters.Add("?nombre", MySqlDbType.VarChar).Value = entnombre.Text;
                bd.cmd.Parameters.Add("?apellido", MySqlDbType.VarChar).Value = entapellido.Text;
                bd.cmd.Parameters.Add("?telefono", MySqlDbType.VarChar).Value = enttelefono.Text;
                bd.cmd.Parameters.Add("?correo", MySqlDbType.VarChar).Value = entcorreo.Text;
                if (bd.cmd.ExecuteNonQuery() > 0)
                {
                    bd.Desconectar();
                    string mensaje = "El cliente fue incluido exitosamente.";
                    string caption = "Inclusion exitosa";
                    MessageBoxButtons boton = MessageBoxButtons.OK;
                    MessageBoxIcon icono = MessageBoxIcon.Information;
                    DialogResult result;
                    result = MessageBox.Show(mensaje, caption, boton, icono);
                }
                else
                {
                    bd.Desconectar();
                    string mensaje = "No se pudo incluir al cliente debido a un error.";
                    string caption = "Error al incluir al cliente";
                    MessageBoxButtons boton = MessageBoxButtons.OK;
                    MessageBoxIcon icono = MessageBoxIcon.Error;
                    DialogResult result;
                    result = MessageBox.Show(mensaje, caption, boton, icono);
                }
            }
        }

        private void ValidarCedula()
        {
            MySql.ConectorBD bd = new MySql.ConectorBD();
            if(bd.VerificarExistencia("cliente", "cedula", entcedula.Text))
            {
                lblvalidarcedula.Text = "El cliente se encuentra registrado.";
                btnfacturar.Enabled = true;
                entnombre.Enabled = false;
                entapellido.Enabled = false;
                enttelefono.Enabled = false;
                entcorreo.Enabled = false;
            }
            else
            {
                lblvalidarcedula.Text = "El cliente no se encuentra registrado.";
                btnfacturar.Enabled = true;
                entnombre.Enabled = true;
                entapellido.Enabled = true;
                enttelefono.Enabled = true;
                entcorreo.Enabled = true;
            }
        }

        // OTROS METODOS

        private int BuscarArticulo(string codigo)
        {
            int len = vcarrito.Count();
            for(int i = 0; i < len; i++)
            {
                if (vcarrito[i].GetCodigo() == codigo)
                {
                    return i;
                }
            }
            return -1;
        }

        private bool ValidarPago()
        {
            double debito, transf, efectivo, dollar;
            debito = double.Parse(entdebito.Text);
            transf = double.Parse(enttransferencia.Text);
            efectivo = double.Parse(entefectivo.Text);
            dollar = double.Parse(entdolar.Text)*dolar;
            double aux = debito + transf + efectivo + dollar;
            if (aux == MontoFactura())
                return true;
            else
                return false;
        }

        private double MontoFactura()
        {
            int len = vcarrito.Count();
            double aux = 0;
            for (int i = 0; i < len; i++)
            {
                aux += vcarrito[i].Subtotal();
            }
            return aux;
        }

        private double Dolar()
        {
            StreamReader sr = new StreamReader("Dolar.txt");
            string line = sr.ReadLine();
            double dolar = double.Parse(line);
            sr.Close();
            return dolar;
        }
    }
}

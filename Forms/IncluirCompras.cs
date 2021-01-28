using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ZonaFranca
{
    public partial class IncluirCompras : Validaciones
    {
        List<Compra> vcompra = new List<Compra>();
        List<Insumo> vinsumo = new List<Insumo>();
        string nombre, user;
        public IncluirCompras(string name, string username)
        {
            InitializeComponent();
            nombre = name;
            user = username;
            btnincluircompra.Enabled = false;
        }

        private void IncluirCompras_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void entcodigoart_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void entcostototal_TextChanged(object sender, EventArgs e)
        {
            ValidarNroDecimal(entcostototal);
            ValidarLimiteEntrada(entcostototal, 17);
        }

        private void entporcentaje_TextChanged(object sender, EventArgs e)
        {
            ValidarNro(entporcentaje);
            entprecio.Text = Precio().ToString();
        }

        private void entprecio_TextChanged(object sender, EventArgs e)
        {
            ValidarNroDecimal(entprecio);
            ValidarLimiteEntrada(entprecio, 17);
        }

        private void entnombreinsumo_TextChanged(object sender, EventArgs e)
        {
            ValidarAlfaNroEspacio(entnombreinsumo);
            ValidarLimiteEntrada(entnombreinsumo, 30);
        }

        private void entdescripcioninsumo_TextChanged(object sender, EventArgs e)
        {
            ValidarAlfaNroEspacio(entdescripcioninsumo);
            ValidarLimiteEntrada(entdescripcioninsumo, 50);
        }

        private void entcostoinsumo_TextChanged(object sender, EventArgs e)
        {
            ValidarNroDecimal(entcostoinsumo);
            ValidarLimiteEntrada(entcostoinsumo, 17);
        }

        private void entcantidadinsumo_TextChanged(object sender, EventArgs e)
        {
            ValidarNroDecimal(entcantidadinsumo);
            ValidarLimiteEntrada(entcantidadinsumo, 8);
        }

        private void entcodigo_TextChanged(object sender, EventArgs e)
        {
            ValidarAlfaNro(entcodigo);
            ValidarLimiteEntrada(entcodigo, 6);
            ValidarCodigo();
        }

        private void entnombre_TextChanged(object sender, EventArgs e)
        {
            ValidarAlfaNroEspacio(entnombre);
            ValidarLimiteEntrada(entnombre, 30);
        }

        private void entdescripcion_TextChanged(object sender, EventArgs e)
        {
            ValidarAlfaNroEspacio(entdescripcion);
            ValidarLimiteEntrada(entdescripcion, 50);
        }

        private void entrif_TextChanged(object sender, EventArgs e)
        {
            ValidarAlfaNro(entrif);
            ValidarLimiteEntrada(entrif, 15);
            ValidarRif();
        }

        private void entnombreproveedor_TextChanged(object sender, EventArgs e)
        {
            ValidarAlfaNroEspacio(entnombreproveedor);
            ValidarLimiteEntrada(entnombreproveedor, 40);
        }

        private void entdireccion_TextChanged(object sender, EventArgs e)
        {
            ValidarAlfaNroEspacio(entdireccion);
            ValidarLimiteEntrada(entdireccion, 60);
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

        private void btnagregarcarrito_Click(object sender, EventArgs e)
        {
            if(entcodigoart.Text == "" || entcantidad.Value == 0 || entcostototal.Text == "" || entprecio.Text == "")
            {
                string mensaje = "Debe llenar todos los campos. \nPor favor verifique.";
                string caption = "Error al ingresar los datos";
                MessageBoxButtons boton = MessageBoxButtons.OK;
                MessageBoxIcon icono = MessageBoxIcon.Warning;
                DialogResult result;
                result = MessageBox.Show(mensaje, caption, boton, icono);
            }
            else
            {
                MySql.ConectorBD bd = new MySql.ConectorBD();
                if(bd.VerificarExistencia("articulo", "codigo", entcodigoart.Text))
                {
                    int cantidad = Convert.ToInt16(entcantidad.Value);
                    double costototal = double.Parse(entcostototal.Text); 
                    double costo = costototal/cantidad;
                    double precio = double.Parse(entprecio.Text);
                    Compra compra = new Compra();
                    compra.SetCodigo(entcodigoart.Text);
                    compra.SetStock(cantidad);
                    compra.SetCosto(costo);
                    compra.SetPrecio(precio);
                    compra.SetUsuario(user);
                    vcompra.Add(compra);
                    btnincluircompra.Enabled = true;
                    entporcentaje.Text = "";
                    entcodigoart.Text = "";
                    entcantidad.Value = 0;
                    entcostototal.Text = "";
                    entprecio.Text = "";

                }
                else
                {
                    string mensaje = "No se encontro algun articulo con el codigo ingresado.";
                    string caption = "Error al agregar el articulo al carrito";
                    MessageBoxButtons boton = MessageBoxButtons.OK;
                    MessageBoxIcon icono = MessageBoxIcon.Warning;
                    DialogResult result;
                    result = MessageBox.Show(mensaje, caption, boton, icono);
                }
            }
        }

        private void btnagregarinsumo_Click(object sender, EventArgs e)
        {
            if(entnombreinsumo.Text == "" || entdescripcioninsumo.Text == "" || entcostoinsumo.Text == "" || entcantidadinsumo.Text == "" || cmbunidad.SelectedIndex == 0)
            {
                string mensaje = "Debe llenar todos los campos. \nPor favor verifique.";
                string caption = "Error al ingresar los datos";
                MessageBoxButtons boton = MessageBoxButtons.OK;
                MessageBoxIcon icono = MessageBoxIcon.Warning;
                DialogResult result;
                result = MessageBox.Show(mensaje, caption, boton, icono);
            }
            else
            {
                Insumo insumo = new Insumo();
                insumo.SetNombre(entnombreinsumo.Text);
                insumo.SetDescripcion(entdescripcion.Text);
                insumo.SetUnidadMedida(cmbunidad.SelectedItem.ToString());
                insumo.SetCosto(double.Parse(entcostoinsumo.Text));
                insumo.SetCantidad(double.Parse(entcantidadinsumo.Text));
                vinsumo.Add(insumo);
                btnincluirarticulo.Enabled = true;
                entnombreinsumo.Text = "";
                entdescripcioninsumo.Text = "";
                cmbunidad.SelectedIndex = 0;
                entcostoinsumo.Text = "";
                entcantidadinsumo.Text = "";
            }
        }

        private void btnincluirarticulo_Click(object sender, EventArgs e)
        {
            if(entcodigo.Text == "" || entnombre.Text == "" || entdescripcion.Text == "")
            {
                string mensaje = "Debe llenar todos los campos. \nPor favor verifique.";
                string caption = "Error al ingresar los datos";
                MessageBoxButtons boton = MessageBoxButtons.OK;
                MessageBoxIcon icono = MessageBoxIcon.Warning;
                DialogResult result;
                result = MessageBox.Show(mensaje, caption, boton, icono);
                
            }
            else
            {
                IncluirArticulo();
                entcodigo.Text = "";
                entnombre.Text = "";
                entdescripcion.Text = "";
            }
        }

        private void btnincluircompra_Click(object sender, EventArgs e)
        {
            IncluirProveedor();
            IncluirCompra();
            vcompra.Clear();
            vinsumo.Clear();
            entrif.Text = "";
            entnombreproveedor.Text = "";
            entdireccion.Text = "";
            enttelefono.Text = "";
            entcorreo.Text = "";
            entfecha.Text = "";
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu(nombre, user, "admin");
            menu.Show();
        }

        // METODOS RELACIONADOS CON LA BASE DE DATOS

        private void IncluirArticulo()
        {
            MySql.ConectorBD bd = new MySql.ConectorBD();
            bd.Conectar();
            bd.cmd = new MySqlCommand("INSERT INTO articulo(codigo, nombre, descripcion, costo, precio, stock, usuario, estatus) VALUES(?codigo, ?nombre, ?descripcion, 0, 0, 0, ?usuario, 'E');", bd.con);
            bd.cmd.Parameters.Add("?codigo", MySqlDbType.VarChar).Value = entcodigo.Text;
            bd.cmd.Parameters.Add("?nombre", MySqlDbType.VarChar).Value = entnombre.Text;
            bd.cmd.Parameters.Add("?descripcion", MySqlDbType.VarChar).Value = entdescripcion.Text;
            bd.cmd.Parameters.Add("?usuario", MySqlDbType.VarChar).Value = user;
            if (bd.cmd.ExecuteNonQuery() > 0)
            {
                bd.Desconectar();
                string mensaje = "El articulo fue incluido exitosamente.";
                string caption = "Inclusion exitosa";
                MessageBoxButtons boton = MessageBoxButtons.OK;
                MessageBoxIcon icono = MessageBoxIcon.Information;
                DialogResult result;
                result = MessageBox.Show(mensaje, caption, boton, icono);
            }
            else
            {
                bd.Desconectar();
                string mensaje = "No se pudo incluir el articulo debido a un error.";
                string caption = "Error al incluir el articulo";
                MessageBoxButtons boton = MessageBoxButtons.OK;
                MessageBoxIcon icono = MessageBoxIcon.Error;
                DialogResult result;
                result = MessageBox.Show(mensaje, caption, boton, icono);
            }
        }

        public void IncluirProveedor()
        {
            MySql.ConectorBD bd = new MySql.ConectorBD();
            if(!bd.VerificarExistencia("proveedor", "rif", entrif.Text))
            {
                bd.Conectar();
                bd.cmd = new MySqlCommand("INSERT INTO proveedor(rif, nombre, direccion, telefono, correo, estatus) values(?rif, ?nombre, ?direccion, ?telefono, ?correo, 'A');", bd.con);
                bd.cmd.Parameters.Add("?rif", MySqlDbType.VarChar).Value = entrif.Text;
                bd.cmd.Parameters.Add("?nombre", MySqlDbType.VarChar).Value = entnombreproveedor.Text;
                bd.cmd.Parameters.Add("?direccion", MySqlDbType.VarChar).Value = entdireccion.Text;
                bd.cmd.Parameters.Add("?telefono", MySqlDbType.VarChar).Value = enttelefono.Text;
                bd.cmd.Parameters.Add("?correo", MySqlDbType.VarChar).Value = entcorreo.Text;
                if (bd.cmd.ExecuteNonQuery() > 0)
                {
                    bd.Desconectar();
                    string mensaje = "El proveedor fue incluido exitosamente.";
                    string caption = "Inclusion exitosa";
                    MessageBoxButtons boton = MessageBoxButtons.OK;
                    MessageBoxIcon icono = MessageBoxIcon.Information;
                    DialogResult result;
                    result = MessageBox.Show(mensaje, caption, boton, icono);
                }
                else
                {
                    bd.Desconectar();
                    string mensaje = "No se pudo incluir al proveedor debido a un error.";
                    string caption = "Error al incluir al proveedor";
                    MessageBoxButtons boton = MessageBoxButtons.OK;
                    MessageBoxIcon icono = MessageBoxIcon.Error;
                    DialogResult result;
                    result = MessageBox.Show(mensaje, caption, boton, icono);
                }
            }
        }

        private void IncluirCompra()
        {
            MySql.ConectorBD bd = new MySql.ConectorBD();
            bd.Conectar();
            bd.cmd = new MySqlCommand("INSERT INTO compra(rif_proveedor, fecha_compra, monto, estatus) values(?rif, str_to_date(replace(?fecha, '/','.'), get_format(date, 'EUR')), ?monto, 'A');", bd.con);
            bd.cmd.Parameters.Add("?rif", MySqlDbType.VarChar).Value = entrif.Text;
            bd.cmd.Parameters.Add("?fecha", MySqlDbType.VarChar).Value = entfecha.Text;
            bd.cmd.Parameters.Add("?monto", MySqlDbType.Double).Value = Monto();
            if (bd.cmd.ExecuteNonQuery() > 0)
            {
                int len = vcompra.Count;
                for(int i = 0; i < len; i++)
                {
                    bd.cmd = new MySqlCommand("INSERT INTO artcompra values((SELECT last_insert_id() FROM compra LIMIT 1), ?codigo, ?cantidad, ?monto);", bd.con);
                    bd.cmd.Parameters.Add("?codigo", MySqlDbType.VarChar).Value = vcompra[i].GetCodigo();
                    bd.cmd.Parameters.Add("?cantidad", MySqlDbType.Int16).Value = vcompra[i].GetStock();
                    bd.cmd.Parameters.Add("?monto", MySqlDbType.Double).Value = vcompra[i].GetStock() * vcompra[i].GetCosto();
                    bd.cmd.ExecuteNonQuery();
                    bd.cmd = new MySqlCommand("UPDATE articulo SET stock = stock + ?cantidad, precio=?precio, costo=?costo WHERE codigo=?codigo;", bd.con);
                    bd.cmd.Parameters.Add("?cantidad", MySqlDbType.Int16).Value = vcompra[i].GetStock();
                    bd.cmd.Parameters.Add("?precio", MySqlDbType.Double).Value = vcompra[i].GetPrecio();
                    bd.cmd.Parameters.Add("?costo", MySqlDbType.Double).Value = vcompra[i].GetCosto();
                    bd.cmd.Parameters.Add("?codigo", MySqlDbType.VarChar).Value = vcompra[i].GetCodigo();
                    bd.cmd.ExecuteNonQuery();
                }
                int leng = vinsumo.Count;
                for(int i = 0; i < leng; i++)
                {
                    bd.cmd = new MySqlCommand("INSERT INTO insumo(compra, nombre, descripcion, costo, cantidad, unidad_medida, estatus) VALUES((SELECT last_insert_id() FROM factura LIMIT 1), ?nombre, ?descripcion, ?costo, ?cantidad, ?unidad, 'A');", bd.con);
                    bd.cmd.Parameters.Add("?nombre", MySqlDbType.VarChar).Value = vinsumo[i].GetNombre();
                    bd.cmd.Parameters.Add("?descripcion", MySqlDbType.VarChar).Value = vinsumo[i].GetDescripcion();
                    bd.cmd.Parameters.Add("?costo", MySqlDbType.Double).Value = vinsumo[i].GetCosto();
                    bd.cmd.Parameters.Add("?cantidad", MySqlDbType.Double).Value = vinsumo[i].GetCantidad();
                    bd.cmd.Parameters.Add("?unidad", MySqlDbType.VarChar).Value = vinsumo[i].GetUnidadMedida();
                }
                bd.Desconectar();
            }
            else
            {
                bd.Desconectar();
                string mensaje = "No se pudo guardar la compra debido a un error imprevisto.";
                string caption = "Error al guardar la compra";
                MessageBoxButtons boton = MessageBoxButtons.OK;
                MessageBoxIcon icono = MessageBoxIcon.Error;
                DialogResult result;
                result = MessageBox.Show(mensaje, caption, boton, icono);
            }

        }

        private void ValidarCodigo()
        {
            MySql.ConectorBD bd = new MySql.ConectorBD();
            if(bd.VerificarExistencia("articulo", "codigo", entcodigo.Text))
            {
                lblvalidarcodigo.Text = "El codigo ya se encuentra registrado";
                btnincluirarticulo.Enabled = false;
            }
            else
            {
                lblvalidarcodigo.Text = "El codigo esta disponible";
                btnincluirarticulo.Enabled = true;
            }

        }

        private void ValidarRif()
        {
            MySql.ConectorBD bd = new MySql.ConectorBD();
            if(bd.VerificarExistencia("proveedor", "rif", entrif.Text))
            {
                lblvalidarproveedor.Text = "El RIF ya se encuentra registrado a un proveedor";
                entnombreproveedor.Enabled = false;
                entdireccion.Enabled = false;
                enttelefono.Enabled = false;
                entcorreo.Enabled = false;
            }
            else
            {
                lblvalidarproveedor.Text = "El RIF no se encuentra registrado. Por favor registrelo.";
                entnombreproveedor.Enabled = true;
                entdireccion.Enabled = true;
                enttelefono.Enabled = true;
                entcorreo.Enabled = true;
            }
        }

        // OTROS METODOS

        private double Precio()
        {
            if (entporcentaje.Text != "")
            {
                int cant = Convert.ToInt16(entcantidad.Value);
                double costototal = double.Parse(entcostototal.Text);
                double costo = costototal / cant;
                double ganancia = costo * double.Parse(entporcentaje.Text) / 100;
                double precio = costo + ganancia;
                return precio;
            }
            return 0;
        }

        private double Monto()
        {
            int len = vcompra.Count;
            double aux = 0;
            for(int i = 0; i < len; i++)
            {
                aux += vcompra[i].GetCosto() * vcompra[i].GetStock();
            }
            int leng = vinsumo.Count;
            for(int i = 0; i < leng; i++)
            {
                aux += vinsumo[i].GetCosto();
            }
            return aux;
        }
    }
}

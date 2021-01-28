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
    public partial class ActualizarArticulos : Validaciones
    {
        string name, user;
        public ActualizarArticulos(string nombre, string username)
        {
            InitializeComponent();
            name = nombre;
            user = username;
        }

        private void ActualizarArticulos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void entcodigoprecio_TextChanged(object sender, EventArgs e)
        {
            ValidarAlfaNroEspacio(entcodigoprecio);
            ValidarLimiteEntrada(entcodigoprecio, 6);
        }

        private void entprecio_TextChanged(object sender, EventArgs e)
        {
            ValidarNroDecimal(entprecio);
            ValidarLimiteEntrada(entprecio, 15);
        }


        private void btnactualizarprecio_Click(object sender, EventArgs e)
        {
            if(entcodigoprecio.Text == "" || entprecio.Text == "")
            {
                string mensaje = "Debe llenar todos los campos";
                string caption = "Error al ingresar los datos";
                MessageBoxButtons boton = MessageBoxButtons.OK;
                MessageBoxIcon icono = MessageBoxIcon.Warning;
                DialogResult result;
                result = MessageBox.Show(mensaje, caption, boton, icono);
            }
            else
            {
                ActualizarPrecio();
                entcodigoprecio.Text = "";
                entprecio.Text = "";
            }  
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu(name, user, "admin");
            menu.Show();
        }

        // METODOS RELACIONADOS CON LA BASE DE DATOS

        private void ActualizarPrecio()
        {
            MySql.ConectorBD bd = new MySql.ConectorBD();
            if(bd.VerificarExistencia("articulo", "codigo", entcodigoprecio.Text))
            {
                bd.Conectar();
                bd.cmd = new MySqlCommand("UPDATE articulo SET precio=?precio, usuario=?usuario WHERE codigo=?codigo AND estatus='A';", bd.con);
                bd.cmd.Parameters.Add("?precio", MySqlDbType.Double).Value = double.Parse(entprecio.Text);
                bd.cmd.Parameters.Add("?usuario", MySqlDbType.VarChar).Value = user;
                bd.cmd.Parameters.Add("?codigo", MySqlDbType.VarChar).Value = entcodigoprecio.Text;
                bd.cmd.ExecuteNonQuery();
                bd.Desconectar();
            }
            else
            {
                string mensaje = "No se encontraron articulos con dicho codigo. \nVerifique el codigo y vuelva a ingresarlo";
                string caption = "Error al ingresar el codigo";
                MessageBoxButtons boton = MessageBoxButtons.OK;
                MessageBoxIcon icono = MessageBoxIcon.Warning;
                DialogResult result;
                result = MessageBox.Show(mensaje, caption, boton, icono);
            }
            
        }
    }
}

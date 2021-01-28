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
    public partial class NuevoUsuario : Validaciones
    {
        string nombre;
        string user;
        public NuevoUsuario(string name, string username)
        {
            InitializeComponent();
            nombre = name;
            user = username;
        }

        private void NuevoUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void entusername_TextChanged(object sender, EventArgs e)
        {
            ValidarAlfaNro(entusername);
            ValidarLimiteEntrada(entusername, 20);
            MySql.ConectorBD bd = new MySql.ConectorBD();
            if(!bd.VerificarExistencia("usuario", "username", entusername.Text))
            {
                //lblvalidacionuser.ForeColor = "Red";
                lblvalidacionuser.Text = "El nombre de usuario esta disponible";
                btnincluir.Enabled = true;
            }
            else
            {
                lblvalidacionuser.Text = "El nombre de usuario no esta disponible";
                btnincluir.Enabled = false;
            }
        }

        private void entcedula_TextChanged(object sender, EventArgs e)
        {
            ValidarNro(entcedula);
            ValidarLimiteEntrada(entcedula, 10);
        }

        private void entclave_TextChanged(object sender, EventArgs e)
        {
            ValidarLimiteEntrada(entclave, 20);
        }

        private void entconfirmarclave_TextChanged(object sender, EventArgs e)
        {
            ValidarLimiteEntrada(entconfirmarclave, 20);
            ValidarClave();
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu(nombre, user, "admin");
            menu.Show();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            entusername.Text = "";
            entcedula.Text = "";
            entclave.Text = "";
            entconfirmarclave.Text = "";
            cmbtipo.SelectedIndex = 0;
        }

        private void btnincluir_Click(object sender, EventArgs e)
        {
            if(entcedula.Text=="" || entusername.Text=="" || entcedula.Text=="" || entclave.Text=="" || entconfirmarclave.Text == "" || cmbtipo.SelectedIndex == 0)
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

                Incluir();
                entusername.Text = "";
                entcedula.Text = "";
                entclave.Text = "";
                entconfirmarclave.Text = "";
                cmbtipo.SelectedIndex = 0;
            }
        }

        // METODOS RELACIONADOS CON LA BASE DE DATOS

        private void Incluir()
        {
            MySql.ConectorBD bd = new MySql.ConectorBD();
            if (bd.VerificarExistencia("empleado", "cedula", entcedula.Text))
            { 
                bd.Conectar();
                bd.cmd = new MySqlCommand("INSERT INTO usuario(username, password, cedempleado, tipo, estatus) VALUES(?user, ?clave, ?cedula, ?tipo, 'A');", bd.con);
                bd.cmd.Parameters.Add("?user", MySqlDbType.VarChar).Value = entusername.Text;
                bd.cmd.Parameters.Add("?clave", MySqlDbType.VarChar).Value = entconfirmarclave.Text;
                bd.cmd.Parameters.Add("?cedula", MySqlDbType.VarChar).Value = entcedula.Text;
                bd.cmd.Parameters.Add("?tipo", MySqlDbType.Int16).Value = cmbtipo.SelectedIndex;
                if (bd.cmd.ExecuteNonQuery() > 0)
                {
                    bd.Desconectar();
                    string mensaje = "El usuario fue incluido exitosamente.";
                    string caption = "Inclusion exitosa";
                    MessageBoxButtons boton = MessageBoxButtons.OK;
                    MessageBoxIcon icono = MessageBoxIcon.Information;
                    DialogResult result;
                    result = MessageBox.Show(mensaje, caption, boton, icono);
                }
                else
                {
                    bd.Desconectar();
                    string mensaje = "No se pudo incluir al usuario debido a un error.";
                    string caption = "Error al incluir al usuario";
                    MessageBoxButtons boton = MessageBoxButtons.OK;
                    MessageBoxIcon icono = MessageBoxIcon.Error;
                    DialogResult result;
                    result = MessageBox.Show(mensaje, caption, boton, icono);
                }
            }
            else
            {
                string mensaje = "La cedula que ingreso no pertenece a un empleado \nPor favor verifique.";
                string caption = "Error al ingresar los datos";
                MessageBoxButtons boton = MessageBoxButtons.OK;
                MessageBoxIcon icono = MessageBoxIcon.Warning;
                DialogResult result;
                result = MessageBox.Show(mensaje, caption, boton, icono);
            }
            
        }

        // OTROS METODOS

        private void ValidarClave()
        {
            if (entclave.Text != entconfirmarclave.Text)
            {
                lblvalidarclave.Text = "Las claves no coinciden";
                btnincluir.Enabled = false;
            }
            else
            {
                lblvalidarclave.Text = "Las claves coinciden";
                btnincluir.Enabled = true;
            }
        }
    }
}

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
    public partial class OtrasOpciones : Validaciones
    {
        string nombre, user, tipo;
        public OtrasOpciones(string name, string username, string tipouser)
        {
            InitializeComponent();
            nombre = name;
            user = username;
            tipo = tipouser;
            if (tipo == "usuario")
                btnactualizardolar.Enabled = false;
        }

        private void OtrasOpciones_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void entdolar_TextChanged(object sender, EventArgs e)
        {
            ValidarNroDecimal(entdolar);
            if (entdolar.Text == "")
                btnactualizardolar.Enabled = false;
        }

        private void entclaveantigua_TextChanged(object sender, EventArgs e)
        {

        }

        private void entclavenueva_TextChanged(object sender, EventArgs e)
        {
            ValidarLimiteEntrada(entclavenueva, 20);
        }

        private void entconfirmarclave_TextChanged(object sender, EventArgs e)
        {
            ValidarLimiteEntrada(entconfirmarclave, 20);
            ValidarClave();
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu(nombre, user, tipo);
            menu.Show();
        }

        private void btnactualizarclave_Click(object sender, EventArgs e)
        {
            Actualizar();
            entclaveantigua.Text = "";
            entclavenueva.Text = "";
            entconfirmarclave.Text = "";
        }

        private void btnactualizardolar_Click(object sender, EventArgs e)
        {
            if(entdolar.Text != "")
            {
                //string doc = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                using (StreamWriter outputFile = new StreamWriter(Path.Combine("Dolar.txt"), false))
                {
                    outputFile.WriteLine(entdolar.Text);
                }
                string mensaje = "El precio del dolar fue actualizado exitosamente.";
                string caption = "Actualizacion exitosa";
                MessageBoxButtons boton = MessageBoxButtons.OK;
                MessageBoxIcon icono = MessageBoxIcon.Information;
                DialogResult result;
                result = MessageBox.Show(mensaje, caption, boton, icono);
                entdolar.Text = "";
            }
            else
            {

            }
        }

        // METODOS RELACIONADOS CON LA BASE DE DATOS

        private bool ConfirmarClaveAntigua()
        {
            MySql.ConectorBD bd = new MySql.ConectorBD();
            bd.Conectar();
            bd.cmd = new MySqlCommand("SELECT password FROM usuario WHERE username=?user AND estatus='A'", bd.con);
            bd.cmd.Parameters.Add("?user", MySqlDbType.VarChar).Value = user;
            bd.dr = bd.cmd.ExecuteReader();
            if (bd.dr.Read())
            {
                string password = bd.dr[0].ToString();
                if (password == entclaveantigua.Text)
                {
                    bd.dr.Close();
                    bd.Desconectar();
                    return true;
                }
                else
                {
                    bd.dr.Close();
                    bd.Desconectar();
                    return false;
                }
            }
            else
            {
                bd.dr.Close();
                bd.Desconectar();
                return false;
            }
        }

        private void Actualizar()
        {
            if (ConfirmarClaveAntigua())
            {
                MySql.ConectorBD bd = new MySql.ConectorBD();
                bd.Conectar();
                bd.cmd = new MySqlCommand("UPDATE usuario SET password=?clavenueva WHERE username=?user AND estatus='A';", bd.con);
                bd.cmd.Parameters.Add("?clavenueva", MySqlDbType.VarChar).Value = entconfirmarclave.Text;
                bd.cmd.Parameters.Add("?user", MySqlDbType.VarChar).Value = user;
                if (bd.cmd.ExecuteNonQuery() > 0)
                {
                    bd.Desconectar();
                    string mensaje = "La clave fue actualizada exitosamente.";
                    string caption = "Actualizacion exitosa";
                    MessageBoxButtons boton = MessageBoxButtons.OK;
                    MessageBoxIcon icono = MessageBoxIcon.Information;
                    DialogResult result;
                    result = MessageBox.Show(mensaje, caption, boton, icono);
                }
                else
                {
                    bd.Desconectar();
                    string mensaje = "No se pudo actualizar la clave debido a un error";
                    string caption = "Error al actualizar la clave";
                    MessageBoxButtons boton = MessageBoxButtons.OK;
                    MessageBoxIcon icono = MessageBoxIcon.Error;
                    DialogResult result;
                    result = MessageBox.Show(mensaje, caption, boton, icono);
                }
            }
            else
            {
                string mensaje = "La clave antigua que ingreso no es correcta. \nPor favor verifique.";
                string caption = "Error al ingresar la clave antigua";
                MessageBoxButtons boton = MessageBoxButtons.OK;
                MessageBoxIcon icono = MessageBoxIcon.Warning;
                DialogResult result;
                result = MessageBox.Show(mensaje, caption, boton, icono);
            }
        }

        // OTROS METODOS

        private void ValidarClave()
        {
            if (entclavenueva.Text != entconfirmarclave.Text)
            {
                lblvalidarclave.Text = "Las claves no coinciden";
                btnactualizarclave.Enabled = false;
            }
            else
            {
                lblvalidarclave.Text = "Las claves coinciden";
                btnactualizarclave.Enabled = true;
            }
        }
    }
}

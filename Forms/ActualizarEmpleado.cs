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
    public partial class ActualizarEmpleado : Validaciones
    {
        string nombre;
        string user;
        public ActualizarEmpleado(string name, string username)
        {
            InitializeComponent();
            nombre = name;
            user = username;
        }

        private void ActualizarEmpleado_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void entcedula_TextChanged(object sender, EventArgs e)
        {
            ValidarNro(entcedula);
            ValidarLimiteEntrada(entcedula, 10);
            MySql.ConectorBD bd = new MySql.ConectorBD();
            if(bd.VerificarExistencia("empleado", "cedula", entcedula.Text))
            {
                lblvalidarcedula.Text = "Se encontro un empleado con esa cedula";
                btnactualizar.Enabled = true;
            }
            else
            {
                lblvalidarcedula.Text = "No se encontro un empleado con esa cedula";
                btnactualizar.Enabled = false;
            }
        }

        private void entdireccion_TextChanged(object sender, EventArgs e)
        {
            ValidarLimiteEntrada(entdireccion, 60);
        }

        private void enttelefono1_TextChanged(object sender, EventArgs e)
        {
            ValidarNro(enttelefono1);
            ValidarLimiteEntrada(enttelefono1, 12);
        }

        private void enttelefono2_TextChanged(object sender, EventArgs e)
        {
            ValidarNro(enttelefono2);
            ValidarLimiteEntrada(enttelefono2, 12);
        }

        private void entcorreo_TextChanged(object sender, EventArgs e)
        {
            ValidarLimiteEntrada(entcorreo, 30);
        }

        private void entsueldo_TextChanged(object sender, EventArgs e)
        {
            ValidarNroDecimal(entsueldo);
            ValidarLimiteEntrada(entsueldo, 15);
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu(nombre, user, "admin");
            menu.Show();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            entcedula.Text = "";
            entdireccion.Text = "";
            enttelefono1.Text = "";
            enttelefono2.Text = "";
            entcorreo.Text = "";
            entsueldo.Text = "";
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (entdireccion.Text != "")
                Actualizar("direccion", entdireccion.Text);
            if (enttelefono1.Text != "")
                Actualizar("telefono1", enttelefono1.Text);
            if (enttelefono2.Text != "")
                Actualizar("telefono2", enttelefono2.Text);
            if (entcorreo.Text != "")
                Actualizar("correo", entcorreo.Text);
            if (entsueldo.Text != "")
                Actualizar("sueldo", double.Parse(entsueldo.Text));
            entcedula.Text = "";
            entdireccion.Text = "";
            enttelefono1.Text = "";
            enttelefono2.Text = "";
            entcorreo.Text = "";
            entsueldo.Text = "";

        }

        // METODOS RELACIONADOS CON LA BASE DE DATOS

        private void Actualizar(string columna, string dato)
        {
            MySql.ConectorBD bd = new MySql.ConectorBD();
            bd.Conectar();
            string query = string.Format("UPDATE empleado SET {0}={1} WHERE cedula=?cedula AND estatus='A'", columna, dato);
            bd.cmd = new MySqlCommand(query, bd.con);
            bd.cmd.Parameters.Add("?cedula", MySqlDbType.VarChar).Value = entcedula.Text;
            if (bd.cmd.ExecuteNonQuery() > 0)
            {
                bd.Desconectar();
                string mensaje = "Empleado actualizado exitosamente";
                String caption = "Actualizacion exitosa";
                MessageBoxButtons boton = MessageBoxButtons.OK;
                MessageBoxIcon icono = MessageBoxIcon.Information;
                DialogResult result;
                result = MessageBox.Show(mensaje, caption, boton, icono);
            }
            else
            {
                bd.Desconectar();
                string mensaje = "No se pudieron actualizar los datos del empleado";
                String caption = "Error al actualizar";
                MessageBoxButtons boton = MessageBoxButtons.OK;
                MessageBoxIcon icono = MessageBoxIcon.Error;
                DialogResult result;
                result = MessageBox.Show(mensaje, caption, boton, icono);
            }
        }

        private void Actualizar(string columna, double dato)
        {
            MySql.ConectorBD bd = new MySql.ConectorBD();
            bd.Conectar();
            string query = string.Format("UPDATE empleado SET {0}={1} WHERE cedula=?cedula AND estatus='A'", columna, dato);
            bd.cmd = new MySqlCommand(query, bd.con);
            bd.cmd.Parameters.Add("?cedula", MySqlDbType.VarChar).Value = entcedula.Text;
            if (bd.cmd.ExecuteNonQuery() > 0)
            {
                bd.Desconectar();
                string mensaje = "Empleado actualizado exitosamente";
                String caption = "Actualizacion exitosa";
                MessageBoxButtons boton = MessageBoxButtons.OK;
                MessageBoxIcon icono = MessageBoxIcon.Information;
                DialogResult result;
                result = MessageBox.Show(mensaje, caption, boton, icono);
            }
            else
            {
                bd.Desconectar();
                string mensaje = "No se pudieron actualizar los datos del empleado";
                String caption = "Error al actualizar";
                MessageBoxButtons boton = MessageBoxButtons.OK;
                MessageBoxIcon icono = MessageBoxIcon.Error;
                DialogResult result;
                result = MessageBox.Show(mensaje, caption, boton, icono);
            }
        }
    }
}

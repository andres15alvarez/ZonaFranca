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
    public partial class IncluirEmpleado : Validaciones
    {
        string nombre;
        string user;
        public IncluirEmpleado(string name, string username)
        {
            InitializeComponent();
            nombre = name;
            user = username;
            dateTimePicker1.MaxDate = DateTime.Today;
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.MaxDate = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
            entfecha_nacimiento.Text = "";
            entfecha_ingreso.Text = "";
        }

        private void IncluirEmpleado_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void entcedula_TextChanged(object sender, EventArgs e)
        {
            ValidarNro(entcedula);
            ValidarLimiteEntrada(entcedula, 10);
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

        private void entdireccion_TextChanged(object sender, EventArgs e)
        {
            ValidarAlfaNroEspacio(entdireccion);
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
            ValidarLimiteEntrada(entcorreo, 50);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            entfecha_nacimiento.Text = dateTimePicker1.Value.ToString();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            entfecha_ingreso.Text = dateTimePicker2.Value.ToString();
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
            entnombre.Text = "";
            entapellido.Text = "";
            entdireccion.Text = "";
            enttelefono1.Text = "";
            enttelefono2.Text = "";
            entcorreo.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
            entfecha_nacimiento.Text = "";
            entfecha_ingreso.Text = "";
            entsueldo.Text = "";
        }

        private void btnincluir_Click(object sender, EventArgs e)
        {
            if(entcedula.Text=="" || entnombre.Text=="" || entapellido.Text=="" || entdireccion.Text=="" || enttelefono1.Text =="" || enttelefono2.Text=="" || entcorreo.Text=="" || entfecha_nacimiento.Text=="" || entfecha_ingreso.Text=="" || entsueldo.Text == "")
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
                string mensaje = "Desea incluir este empleado: \n" + "Cedula: " + entcedula.Text +
                    "\nNombre: " + entnombre.Text +
                    "\nApellido: "+ entapellido.Text+
                    "\nFecha de nacimiento: "+entfecha_nacimiento.Text+
                    "\nFecha de ingreso: "+entfecha_ingreso.Text;
                string caption = "Inclusion de empleado";
                MessageBoxButtons boton = MessageBoxButtons.YesNo;
                MessageBoxIcon icono = MessageBoxIcon.Question;
                var result = MessageBox.Show(mensaje, caption, boton, icono);
                if (result == DialogResult.Yes)
                {
                    Incluir();
                    entcedula.Text = "";
                    entnombre.Text = "";
                    entapellido.Text = "";
                    entdireccion.Text = "";
                    enttelefono1.Text = "";
                    enttelefono2.Text = "";
                    entcorreo.Text = "";
                    dateTimePicker1.Value = DateTime.Today;
                    dateTimePicker2.Value = DateTime.Today;
                    entfecha_nacimiento.Text = "";
                    entfecha_ingreso.Text = "";
                    entsueldo.Text = "";
                }
                else
                {
                    entcedula.Text = "";
                    entnombre.Text = "";
                    entapellido.Text = "";
                    entdireccion.Text = "";
                    enttelefono1.Text = "";
                    enttelefono2.Text = "";
                    entcorreo.Text = "";
                    dateTimePicker1.Value = DateTime.Today;
                    dateTimePicker2.Value = DateTime.Today;
                    entfecha_nacimiento.Text = "";
                    entfecha_ingreso.Text = "";
                    entsueldo.Text = "";
                }
            }
        }

        // METODOS RELACIONADOS CON LA BASE DE DATOS

        private void Incluir()
        {
            MySql.ConectorBD bd = new MySql.ConectorBD();
            if (!bd.VerificarExistencia("empleado", "cedula", entcedula.Text))
            {
                bd.Conectar();
                bd.cmd = new MySqlCommand("INSERT INTO empleado(cedula, nombre, apellido, direccion, telefono1, telefono2, correo, fecha_nacimiento, fecha_ingreso, sueldo, estatus) " +
                    "VALUES(?cedula, ?nombre, ?apellido, ?direccion, ?telefono1, ?telefono2, ?correo, str_to_date(replace(?fecha_nac,'/','.'), get_format(date, 'EUR')), str_to_date(replace(?fecha_ing, '/','.'), get_format(date, 'EUR')), ?sueldo, 'A');", bd.con);
                bd.cmd.Parameters.Add("?cedula", MySqlDbType.VarChar).Value = entcedula.Text;
                bd.cmd.Parameters.Add("?nombre", MySqlDbType.VarChar).Value = entnombre.Text;
                bd.cmd.Parameters.Add("?apellido", MySqlDbType.VarChar).Value = entapellido.Text;
                bd.cmd.Parameters.Add("?direccion", MySqlDbType.VarChar).Value = entdireccion.Text;
                bd.cmd.Parameters.Add("?telefono1", MySqlDbType.VarChar).Value = enttelefono1.Text;
                bd.cmd.Parameters.Add("?telefono2", MySqlDbType.VarChar).Value = enttelefono2.Text;
                bd.cmd.Parameters.Add("?correo", MySqlDbType.VarChar).Value = entcorreo.Text;
                bd.cmd.Parameters.Add("?fecha_nac", MySqlDbType.VarChar).Value = entfecha_nacimiento.Text;
                bd.cmd.Parameters.Add("?fecha_ing", MySqlDbType.VarChar).Value = entfecha_ingreso.Text;
                bd.cmd.Parameters.Add("?sueldo", MySqlDbType.Double).Value = double.Parse(entsueldo.Text);
                if (bd.cmd.ExecuteNonQuery() > 0)
                {
                    bd.Desconectar();
                    string mensaje = "El empleado fue incluido exitosamente.";
                    string caption = "Inclusion exitosa";
                    MessageBoxButtons boton = MessageBoxButtons.OK;
                    MessageBoxIcon icono = MessageBoxIcon.Information;
                    DialogResult result;
                    result = MessageBox.Show(mensaje, caption, boton, icono);
                }
                else
                {
                    bd.Desconectar();
                    string mensaje = "No se pudo incluir al empleado debido a un error.";
                    string caption = "Error al incluir al empelado";
                    MessageBoxButtons boton = MessageBoxButtons.OK;
                    MessageBoxIcon icono = MessageBoxIcon.Error;
                    DialogResult result;
                    result = MessageBox.Show(mensaje, caption, boton, icono);
                }
            }
            else
            {
                string mensaje = "La cedula que ingreso ya pertenece a un empleado \nPor favor verifique.";
                string caption = "Error al ingresar los datos";
                MessageBoxButtons boton = MessageBoxButtons.OK;
                MessageBoxIcon icono = MessageBoxIcon.Warning;
                DialogResult result;
                result = MessageBox.Show(mensaje, caption, boton, icono);
            }
        }
    }
}

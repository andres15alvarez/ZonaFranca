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
    public partial class Inicio : Validaciones 
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            var resultado = Buscar();
            string tipo = resultado.tipo;
            string apellido = resultado.apellido;
            string nombre = resultado.nombre;
            string username = entusuario.Text;
            if (tipo == "admin" || tipo == "usuario")
            {
                Menu menu = new Menu(apellido + ", " + nombre, username, tipo);
                this.Hide();
                menu.Show();
            }
            else
            {
                lblingreso.Text = tipo;
            }
        }

        // METODOS PARA CONECTARSE CON LA BASE DE DATOS

        private (string tipo, string apellido, string nombre) Buscar()
        {
            // BUSCA Y RETORNA EL TIPO DE USUARIO PARA ABRIR EL TIPO DE MENU CORRESPONDIENTE
            //string resultado;
            string tipo, apellido, nombre;
            MySql.ConectorBD bd = new MySql.ConectorBD();
            bd.Conectar();
            bd.cmd = new MySqlCommand("SELECT tipo, apellido, nombre FROM usuario, empleado WHERE cedempleado=cedula AND username=?usuario AND password=?password AND usuario.estatus='A' AND empleado.estatus='A';", bd.con);
            bd.cmd.Parameters.Add("?usuario", MySqlDbType.VarChar).Value = entusuario.Text;
            bd.cmd.Parameters.Add("?password", MySqlDbType.VarChar).Value = entpass.Text;
            bd.dr = bd.cmd.ExecuteReader();
            if (bd.dr.Read())
            {
                tipo = bd.dr[0].ToString();
                apellido = bd.dr[1].ToString();
                nombre = bd.dr[2].ToString();
                bd.dr.Close();
                bd.Desconectar();
                return (tipo, apellido, nombre);
                //return resultado;
            }
            else 
            {
                // EN CASO DE NO REGRESAR NADA DE LA CONSULTA SQL, PROCEDERA A VERIFICAR QUE DATOS
                // INGRESO INCORRECTAMENTE
                bd.dr.Close();
                bd.Desconectar();
                bool usercorrecto = bd.VerificarExistencia("usuario", "username", entusuario.Text);
                bool passcorrecta = bd.VerificarExistencia("usuario", "password", entpass.Text);
                if (usercorrecto)
                {
                    if (!passcorrecta)
                    {
                        tipo = "Clave invalida";
                        apellido = "";
                        nombre = "";
                        return (tipo, apellido, nombre);
                    }
                }
                    tipo = "Usuario y clave invalidos";
                    apellido = "";
                    nombre = "";
                    return (tipo, apellido, nombre);
            }
        }

        private void entusuario_TextChanged(object sender, EventArgs e)
        {
            ValidarAlfaNro(entusuario);
        }

        private void Inicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

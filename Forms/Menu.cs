using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZonaFranca
{
    public partial class Menu : Form
    {
        string username;
        string name;
        string tipo;
        public Menu(string nombre, string user, string tipouser)
        {
            InitializeComponent();
            lblsaludo.Text = "Bienvenido(a) " + nombre;
            username = user;
            name = nombre;
            tipo = tipouser;
            if (tipo != "admin")
            {
                btnactualizararticulos.Enabled = false;
                btnincluircompras.Enabled = false;
                btnsignup.Enabled = false;
                btnnuevoempleado.Enabled = false;
                btnactualizarempleado.Enabled = false;
                btnnomina.Enabled = false;
            }
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btncerrarsesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio inicio = new Inicio();
            inicio.Show();
        }

        private void btnprocesarventas_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProcesarVentas pv = new ProcesarVentas(name, username, tipo);
            pv.Show();
        }

        private void btninventario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventario inv = new Inventario(name, username);
            inv.Show();
        }

        private void btnestadisticasventas_Click(object sender, EventArgs e)
        {
            this.Hide();
            EstadisticasVentas ev = new EstadisticasVentas(name, username, tipo);
            ev.Show();
        }

        private void btnincluircompras_Click(object sender, EventArgs e)
        {
            this.Hide();
            IncluirCompras ic = new IncluirCompras(name, username);
            ic.Show();
        }

        private void btnestadisticascompras_Click(object sender, EventArgs e)
        {
            this.Hide();
            EstadisticasCompras ec = new EstadisticasCompras(name, username);
            ec.Show();
        }

        private void btnactualizararticulos_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActualizarArticulos aa = new ActualizarArticulos(name, username);
            aa.Show();
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            NuevoUsuario nu = new NuevoUsuario(name, username);
            nu.Show();
        }

        private void btnnuevoempleado_Click(object sender, EventArgs e)
        {
            this.Hide();
            IncluirEmpleado ie = new IncluirEmpleado(name, username);
            ie.Show();
        }

        private void btnactualizarempleado_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActualizarEmpleado ae = new ActualizarEmpleado(name, username);
            ae.Show();
        }

        private void btnopciones_Click(object sender, EventArgs e)
        {
            this.Hide();
            OtrasOpciones oo = new OtrasOpciones(name, username, tipo);
            oo.Show();
        }
    }
}

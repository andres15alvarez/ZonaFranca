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
    public partial class Inventario : Form
    {
        string nombre, user;
        public Inventario(string name, string username)
        {
            InitializeComponent();
            CargarInventario();
            nombre = name;
            user = username;
        }

        private void Inventario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu(nombre, user, "admin");
            menu.Show();
        }

        private void CargarInventario()
        {
            MySql.ConectorBD bd = new MySql.ConectorBD();
            bd.Conectar();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT codigo, nombre, descripcion, costo, precio, stock as 'cantidad', usuario as 'usuario que modifico al articulo' FROM articulo;", bd.con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "articulo");
            gdvinventario.DataSource = ds.Tables["articulo"];
            bd.Desconectar();
        }
    }
}

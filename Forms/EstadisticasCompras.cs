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
    public partial class EstadisticasCompras : Form
    {
        string nombre, user;
        public EstadisticasCompras(string name, string username)
        {
            InitializeComponent();
            nombre = name;
            user = username;
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
            dateTimePicker1.MaxDate = DateTime.Today;
            dateTimePicker2.MaxDate = DateTime.Today;
            entfechainicial.Text = "";
            entfechafinal.Text = "";
        }

        private void EstadisticasCompras_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            entfechainicial.Text = dateTimePicker1.Value.ToString();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            entfechafinal.Text = dateTimePicker2.Value.ToString();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if(entfechainicial.Text == "" || entfechafinal.Text == "")
            {

            }
            else
            {
                CargarCompras();
                CargarDatos();
            }
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu(nombre, user, "admin");
            menu.Show();
        }

        // METODOS RELACIONADOS CON LA BASE DE DATOS

        private void CargarCompras()
        {
            MySql.ConectorBD bd = new MySql.ConectorBD();
            bd.Conectar();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT idcompra, fecha_compra as 'fecha', rif_proveedor as 'rif del proveedor', nombre as 'nombre del proveedor', monto FROM compra, proveedor WHERE rif_proveedor=rif AND fecha_compra BETWEEN str_to_date(replace(?fechainicial, '/', '.'), get_format(date, 'EUR')) AND str_to_date(replace(?fechafinal, '/', '.'), get_format(date, 'EUR')) AND compra.estatus='A' order by fecha_compra;", bd.con);
            adapter.SelectCommand.Parameters.Add("?fechainicial", MySqlDbType.VarChar).Value = entfechainicial.Text;
            adapter.SelectCommand.Parameters.Add("?fechafinal", MySqlDbType.VarChar).Value = entfechafinal.Text;
            DataSet ds = new DataSet();
            adapter.Fill(ds, "compra");
            adapter.Fill(ds, "proveedor");
            gdvcompras.DataSource = ds.Tables["compra"];
            gdvcompras.DataSource = ds.Tables["proveedor"];
            bd.Desconectar();
        }

        private void CargarDatos()
        {
            MySql.ConectorBD bd = new MySql.ConectorBD();
            bd.Conectar();
            bd.cmd = new MySqlCommand("SELECT SUM(monto), AVG(monto), MAX(monto), MIN(monto) FROM compra WHERE fecha_compra BETWEEN str_to_date(replace(?fechainicial, '/', '.'), get_format(date, 'EUR')) AND str_to_date(replace(?fechafinal, '/', '.'), get_format(date, 'EUR')) AND estatus='A';", bd.con);
            bd.cmd.Parameters.Add("?fechainicial", MySqlDbType.VarChar).Value = entfechainicial.Text;
            bd.cmd.Parameters.Add("?fechafinal", MySqlDbType.VarChar).Value = entfechafinal.Text;
            bd.dr = bd.cmd.ExecuteReader();
            if (bd.dr.Read())
            {
                enttotal.Text = bd.dr[0].ToString();
                entpromedio.Text = bd.dr[1].ToString();
                entmax.Text = bd.dr[2].ToString();
                entmin.Text = bd.dr[3].ToString();
                bd.dr.Close();
                bd.Desconectar();
            }
            else
            {
                bd.dr.Close();
                bd.Desconectar();
            }
        }
    }
}

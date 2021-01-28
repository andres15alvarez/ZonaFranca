using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ZonaFranca
{
    public partial class VentasPeriodo : UserControl
    {
        public VentasPeriodo()
        {
            InitializeComponent();
            dateinicial.Value = DateTime.Today;
            dateinicial.MaxDate = dateinicial.Value;
            datefinal.Value = DateTime.Today;
            datefinal.MaxDate = datefinal.Value;
            entfechainicial.Text = "";
            entfechafinal.Text = "";
        }

        public void dateinicial_ValueChanged(object sender, EventArgs e)
        {
            entfechainicial.Text = dateinicial.Value.ToString();
        }

        public void datefinal_ValueChanged(object sender, EventArgs e)
        {
            entfechafinal.Text = datefinal.Value.ToString();
        }

        public void btnbuscar_Click(object sender, EventArgs e)
        {
            if(entfechainicial.Text=="" || entfechafinal.Text == "")
            {
                string mensaje = "Debe llenar todos los campos.";
                string caption = "Error al ingresar los datos";
                MessageBoxButtons boton = MessageBoxButtons.OK;
                MessageBoxIcon icono = MessageBoxIcon.Warning;
                DialogResult result;
                result = MessageBox.Show(mensaje, caption, boton, icono);
            }
            else
            {
                CargarVentas();
            }
        }

        public void CargarVentas()
        {
            MySql.ConectorBD bd = new MySql.ConectorBD();
            bd.Conectar();
            //string query = String.Format("SELECT nro_factura, fecha_venta AS 'fecha', hora_venta AS 'hora', CONCAT(apellido, ', ', nombre) AS 'nombre del cliente', monto FROM factura, cliente WHERE ced_cliente=cedula and fecha_venta BETWEEN str_to_date(replace({0}, '/', '.'), get_format(date, 'EUR')) and str_to_date(replace({1}, '/', '.'), get_format(date, 'EUR')) AND factura.estatus='A' ORDER BY fecha_venta;", entfechainicial.Text, entfechafinal.Text);
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT nro_factura, fecha_venta AS 'fecha', hora_venta AS 'hora', CONCAT(apellido, ', ', nombre) AS 'nombre del cliente', monto FROM factura, cliente WHERE ced_cliente=cedula and fecha_venta BETWEEN str_to_date(replace(?fechainicial, '/', '.'), get_format(date, 'EUR')) and str_to_date(replace(?fechafinal, '/', '.'), get_format(date, 'EUR')) AND factura.estatus='A' ORDER BY fecha_venta, hora_venta;", bd.con);
            adapter.SelectCommand.Parameters.Add("?fechainicial", MySqlDbType.VarChar).Value = entfechainicial.Text;
            adapter.SelectCommand.Parameters.Add("?fechafinal", MySqlDbType.VarChar).Value = entfechafinal.Text;
            DataSet ds = new DataSet();
            adapter.Fill(ds, "factura");
            adapter.Fill(ds, "cliente");
            gdvventas.DataSource = ds.Tables["factura"];
            gdvventas.DataSource = ds.Tables["cliente"];
            bd.Desconectar();
        }
    }
}

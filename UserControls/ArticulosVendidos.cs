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
    public partial class ArticulosVendidos : UserControl
    {
        public ArticulosVendidos()
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
                CargarArticulos();
            }
        }

        // METODOS RELACIONADOS CON LA BASE DE DATOS

        public void CargarArticulos()
        {
            MySql.ConectorBD bd = new MySql.ConectorBD();
            bd.Conectar();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT codigo, nombre, descripcion, SUM(cantidad) as 'cantidad vendida', SUM(total) as 'total vendido' FROM articulo, artfactura, factura WHERE codigo=cod_articulo AND factura=nro_factura AND fecha_venta BETWEEN str_to_date(replace(?fechainicial, '/', '.'), get_format(date, 'EUR')) and str_to_date(replace(?fechafinal, '/', '.'), get_format(date, 'EUR')) AND factura.estatus='A' group by codigo order by SUM(cantidad) desc", bd.con);
            adapter.SelectCommand.Parameters.Add("?fechainicial", MySqlDbType.VarChar).Value = entfechainicial.Text;
            adapter.SelectCommand.Parameters.Add("?fechafinal", MySqlDbType.VarChar).Value = entfechafinal.Text;
            DataSet ds = new DataSet();
            adapter.Fill(ds, "articulo");
            adapter.Fill(ds, "artfactura");
            gdvarticulos.DataSource = ds.Tables["articulo"];
            gdvarticulos.DataSource = ds.Tables["artfactura"];
            bd.Desconectar();
        }
    }
}

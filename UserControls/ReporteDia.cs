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
    public partial class ReporteDia : UserControl
    {
        public ReporteDia()
        {
            InitializeComponent();
            CargarLista();
            CargarDatos();
        }

        public void CargarLista()
        {
            MySql.ConectorBD bd = new MySql.ConectorBD();
            bd.Conectar();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT codigo, nombre, descripcion, SUM(cantidad) as 'cantidad', SUM(cantidad*precio) as 'total' FROM articulo, artfactura, factura WHERE codigo=cod_articulo AND nro_factura=factura AND fecha_venta=CURRENT_DATE() " +
                "AND factura.estatus='A' GROUP BY codigo;", bd.con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "articulo");
            adapter.Fill(ds, "artfactura");
            gdvreporte.DataSource = ds.Tables["articulo"];
            gdvreporte.DataSource = ds.Tables["artfactura"];
            bd.Desconectar();
        }

        public void CargarDatos()
        {
            MySql.ConectorBD bd = new MySql.ConectorBD();
            bd.Conectar();
            bd.cmd = new MySqlCommand("SELECT SUM(monto), SUM(pago_debito), SUM(pago_transferencia), SUM(pago_efectivo), SUM(pago_dolar), AVG(monto), MAX(monto), MIN(monto) FROM factura WHERE fecha_venta=CURRENT_DATE() AND estatus = 'A';", bd.con);
            bd.dr = bd.cmd.ExecuteReader();
            if (bd.dr.Read())
            {
                enttotal.Text = bd.dr[0].ToString();
                enttotalpunto.Text = bd.dr[1].ToString();
                enttotaltransferencia.Text = bd.dr[2].ToString();
                enttotalefectivo.Text = bd.dr[3].ToString();
                enttotaldolar.Text = bd.dr[4].ToString();
                entpromedio.Text = bd.dr[5].ToString();
                entmax.Text = bd.dr[6].ToString();
                entmin.Text = bd.dr[7].ToString();
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

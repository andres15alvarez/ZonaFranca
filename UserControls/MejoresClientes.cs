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
    public partial class MejoresClientes : UserControl
    {
        public MejoresClientes()
        {
            InitializeComponent();
            CargarClientes();
        }

        public void CargarClientes()
        {
            MySql.ConectorBD bd = new MySql.ConectorBD();
            bd.Conectar();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT cedula, concat(apellido, ', ', nombre) as 'nombre', telefono, correo, sum(monto) AS 'bolivares en compras' FROM cliente, factura WHERE cedula=ced_cliente AND factura.estatus='A' group by ced_cliente order by sum(monto) desc;", bd.con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "cliente");
            adapter.Fill(ds, "factura");
            gdvclientes.DataSource = ds.Tables["cliente"];
            gdvclientes.DataSource = ds.Tables["factura"];
            bd.Desconectar();
        }
    }
}

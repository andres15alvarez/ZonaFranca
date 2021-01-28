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
    public partial class EstadisticasVentas : Form
    {
        string nombre, user, tipo;
        public EstadisticasVentas(string name, string username, string tipouser)
        {
            InitializeComponent();
            nombre = name;
            user = username;
            tipo = tipouser;
        }

        private void EstadisticasVentas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnreportedia_Click(object sender, EventArgs e)
        {
            ReporteDia reporte = new ReporteDia();
            paneloptions.Controls.Clear();
            paneloptions.Controls.Add(reporte);
            reporte.Show();
        }

        private void btnarticulos_Click(object sender, EventArgs e)
        {
            ArticulosVendidos articulos = new ArticulosVendidos();
            paneloptions.Controls.Clear();
            paneloptions.Controls.Add(articulos);
            articulos.Show();
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            MejoresClientes clientes = new MejoresClientes();
            paneloptions.Controls.Clear();
            paneloptions.Controls.Add(clientes);
            clientes.Show();

        }

        private void btnventasperiodo_Click(object sender, EventArgs e)
        {
            VentasPeriodo ventas = new VentasPeriodo();
            paneloptions.Controls.Clear();
            paneloptions.Controls.Add(ventas);
            ventas.Show();
        }



        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu(nombre, user, tipo);
            menu.Show();
        }
    }
}

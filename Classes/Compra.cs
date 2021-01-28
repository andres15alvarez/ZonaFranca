using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZonaFranca
{
    public class Compra
    {
        private int stock;
        private double costo, precio;
        private string codigo, usuario;

        public Compra() { }

        public void SetStock(int sto)
        {
            stock = sto;
        }

        public void SetCosto(double cos)
        {
            costo = cos;
        }

        public void SetPrecio(double pre)
        {
            precio = pre;
        }

        public void SetCodigo(string cod)
        {
            codigo = cod;
        }

        public void SetUsuario(string user)
        {
            usuario = user;
        }

        public int GetStock()
        {
            return stock;
        }

        public double GetCosto()
        {
            return costo;
        }

        public double GetPrecio()
        {
            return precio;
        }

        public string GetCodigo()
        {
            return codigo;
        }

        public string GetUsuario()
        {
            return usuario;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZonaFranca
{
    public class Carrito
    {
        private string codigo, nombre;
        private int cantidad;
        private double precio;

        public Carrito()
        {

        }

        public void SetCodigo(string cod)
        {
            codigo = cod;
        }

        public void SetNombre(string nom)
        {
            nombre = nom;
        }

        public void SetCantidad(int cant)
        {
            cantidad = cant;
        }

        public void SetPrecio(double pre)
        {
            precio = pre;
        }

        public string GetCodigo()
        {
            return codigo;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public int GetCantidad()
        {
            return cantidad;
        }

        public double GetPrecio()
        {
            return precio;
        }

        public double Subtotal()
        {
            return precio * cantidad;
        }
    }
}

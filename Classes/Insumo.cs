using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZonaFranca
{
    public class Insumo
    {
        private string nombre, descripcion, unidad_medida;
        private double costo, cantidad;
        public Insumo() { }

        public void SetNombre(string nom)
        {
            nombre = nom;
        }

        public void SetDescripcion(string des)
        {
            descripcion = des;
        }

        public void SetUnidadMedida(string um)
        {
            unidad_medida = um;
        }

        public void SetCosto(double cos)
        {
            costo = cos;
        }

        public void SetCantidad(double cant)
        {
            cantidad = cant;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public string GetDescripcion()
        {
            return descripcion;
        }

        public string GetUnidadMedida()
        {
            return unidad_medida;
        }

        public double GetCosto()
        {
            return costo;
        }

        public double GetCantidad()
        {
            return cantidad;
        }
    }
}

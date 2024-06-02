using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigoDeBarra, float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
        }

        #region Getters
        public string GetMarca()
        {
            return marca;
        }
        public float GetPrecio()
        {
            return precio;
        }
        #endregion

        public static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("---------------------");
            sb.AppendLine($"Código de barra: {p.codigoDeBarra}");
            sb.AppendLine($"Marca: {p.marca}");
            sb.AppendLine($"Precio: ${p.precio.ToString("N2")}");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }
        public static bool operator ==(Producto p1, Producto p2)
        {
            if(p1.codigoDeBarra == p2.codigoDeBarra && p1.marca == p2.marca)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
        public static bool operator ==(Producto p, string marca)
        {
            if(p.marca == marca)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Producto p, string marca)
        {
            return !(p == marca);
        }
    }
}

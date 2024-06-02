using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Rectangulo
    {
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;
        private float area;
        private float perimetro;

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;

            vertice2 = new Punto(vertice3.GetX(), vertice1.GetY());
            vertice4 = new Punto(vertice1.GetX(), vertice3.GetY());
        }

        public float Area()
        {
            float _base;
            float altura;

            if (area == default)
            {
                _base = Math.Abs(vertice3.GetX() - vertice4.GetX());
                altura = Math.Abs(vertice1.GetY() - vertice4.GetY());
                area = _base * altura;
            }

            return area;
        }
        public float Perimetro()
        {
            float _base;
            float altura;

            if (perimetro == default)
            {
                _base = Math.Abs(vertice3.GetX() - vertice4.GetX());
                altura = Math.Abs(vertice1.GetY() - vertice4.GetY());
                perimetro = (_base + altura) / 2;
            }

            return perimetro;
        }
    }
}

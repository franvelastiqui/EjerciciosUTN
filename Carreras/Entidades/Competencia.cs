using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum TipoCompetencia
    {
        F1,
        MotoCross
    }
    public class Competencia<T> where T : VehiculoDeCarrera
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<T> competidores;
        private TipoCompetencia tipo;

        private Competencia()
        {
            competidores = new List<T>();
        }

        public Competencia(short cantidadCompetidores, short cantidadVueltas, TipoCompetencia tipo) : this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
            this.tipo = tipo;
        }

        public short CantidadCompetidores { get => cantidadCompetidores; set => cantidadCompetidores = value; }
        public short CantidadVueltas { get => cantidadVueltas; set => cantidadVueltas = value; }
        public TipoCompetencia Tipo { get => tipo; set => tipo = value; }
        public List<T> Competidores { get => competidores; }
        public T this[int i]
        {
            get
            {
                return competidores[i];
            }
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("------------------------CARRERA------------------------");
            sb.AppendLine($"Vueltas: {cantidadVueltas}");
            sb.AppendLine($"Son {cantidadCompetidores} competidores");
            sb.AppendLine("\nCompetidores:");

            foreach(T competidor in competidores)
            {
                sb.AppendLine(competidor.MostrarDatos());
            }

            return sb.ToString();
        }

        public static bool operator +(Competencia<T> c, T a)
        {
            if(c.competidores.Count < c.cantidadCompetidores)
            {
                try
                {
                    if (c != a)
                    {
                        Random random = new Random();
                        c.competidores.Add(a);
                        a.EnCompetencia = true;
                        a.VueltasRestantes = c.cantidadVueltas;
                        a.CantidadCombustible = (short)random.Next(15, 101);
                        return true;
                    }
                    else
                    {
                        throw new CompetenciaNoDisponibleException("El vehículo no corresponde a la competencia", "Competencia", "Operador ==");
                    }
                }
                catch (CompetenciaNoDisponibleException e)
                {
                    throw new CompetenciaNoDisponibleException("Competencia incorrecta", "Competencia", "Operador +", e);
                }
            }

            return false;
        }

        public static bool operator -(Competencia<T> c, T a)
        {
            if (c == a)
            {
                a.EnCompetencia = false;
                a.VueltasRestantes = 0;
                a.CantidadCombustible = 0;
                c.competidores.Remove(a);
                return true;
            }

            return false;
        }

        public static bool operator ==(Competencia<T> c, T a)
        {
            if((c.tipo == TipoCompetencia.F1 && a.GetType() == typeof(AutoF1)) || (c.tipo == TipoCompetencia.MotoCross && a.GetType() == typeof(MotoCross)))
            {
                foreach (T b in c.competidores)
                {
                    if (a == b)
                    {
                        //throw new CompetenciaNoDisponibleException("El vehículo no corresponde a la competencia", "Competencia", "Operador ==");
                        return true;
                    }
                }
            }
            else
            {
                throw new CompetenciaNoDisponibleException("El vehículo no corresponde a la competencia", "Competencia", "Operador ==");
            }

            //throw new CompetenciaNoDisponibleException("El vehículo no corresponde a la competencia", "Competencia", "Operador ==");
            return false;
        }

        public static bool operator !=(Competencia<T> c, T a)
        {
            return !(c == a);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Personal : Persona
    {
        private DateTime horaEntrada;
        private DateTime horaSalida;

        #region Propiedades

        public DateTime HoraEntrada
        {
            get
            {
                return this.horaEntrada;
            }
            set
            {
                this.horaEntrada = value;
            }
        }

        public DateTime HoraSalida
        {
            get
            {
                return this.horaSalida;
            }
            set
            {
                this.horaSalida = value;
            }
        }

        public Double Salario
        {
            get
            {
                return this.CalcularSalario();
            }
        }

        #endregion

        protected Personal(string nombre, string apellido, int dni, bool femenino, DateTime horaEntrada, DateTime horaSalida)
            : base (nombre, apellido, dni, femenino)
        {
            this.horaEntrada = horaEntrada;
            this.horaSalida = horaSalida;
        }

        protected abstract double CalcularSalario();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString() + " - " + "Hora entrada: " + this.horaEntrada.Hour + " hs" + " - " + "Hora salida: " + this.horaSalida.Hour + " hs");

            return sb.ToString();
        }
    }
}

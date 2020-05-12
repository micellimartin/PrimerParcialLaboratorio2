using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Docente : Personal
    {
        private double valorHora;

        #region Propiedades

        public int HorasMensuales
        {
            get
            {
                //Obtengo la cantidad de horas trabajadas por dia
                int horasTrabajadasDia = this.HoraSalida.Hour - this.HoraEntrada.Hour;

                //Lo multiplico por el total de dias trabajados en 1 mes
                //Asumo que es 20 porque no trabajas los fines de semana.
                return horasTrabajadasDia * 20;
            }
        }

        public double ValorHora
        {
            get
            {
                return this.valorHora;
            }
            set
            {
                this.valorHora = value;
            }
        }

        #endregion

        protected override double CalcularSalario()
        {
            //Primero obtengo las horas trabajadas en 1 dia
            int horasTrabajadasDia = this.HoraSalida.Hour - this.HoraEntrada.Hour;

            //Despues multiplico el valorHora por la cantidad de horas diarias por 20 días hábiles
            return (this.valorHora * horasTrabajadasDia * 20);
        }

        public Docente(string nombre, string apellido, int dni, bool femenino, DateTime horaEntrada, DateTime horaSalida, double valorHora)
            : base(nombre, apellido, dni, femenino, horaEntrada, horaSalida)
        {
            this.valorHora = valorHora;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString() + " - " + "Valor hora: $" + this.valorHora);

            return sb.ToString();
        }
    }
}

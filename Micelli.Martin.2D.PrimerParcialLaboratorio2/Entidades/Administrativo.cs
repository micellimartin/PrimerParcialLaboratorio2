using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum ECargo
    {
        Porteria = 100,
        Cocina = 110,
        Secretaria = 140,
        Tesoreria = 240,
        Direccion = 180
    }

    public class Administrativo : Personal
    {
        private ECargo cargo;
        private static double SalarioBase;

        public ECargo Cargo
        {
            get
            {
                return this.cargo;
            }
            set
            {
                this.cargo = value;
            }
        }

        static Administrativo()
        {
            SalarioBase = 30000;
        }

        public Administrativo(string nombre, string apellido, int dni, bool femenino, DateTime horaEntrada, DateTime horaSalida, ECargo cargo)
            : base(nombre, apellido, dni, femenino, horaEntrada, horaSalida)
        {
            this.cargo = cargo;
        }

        protected override double CalcularSalario()
        {
            return (Administrativo.SalarioBase * (int)this.cargo) / 100;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString() + " - " + this.cargo + " - " + this.Salario);

            return sb.ToString();
        }
    }
}

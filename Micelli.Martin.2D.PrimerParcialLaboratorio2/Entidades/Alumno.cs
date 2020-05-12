using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        private EColores colorSala;
        private int legajo;
        private float precioCuota;
        private Responsable responsable;

        #region Propiedades

        public EColores ColorSala
        {
            get
            {
                return this.colorSala;
            }
            set
            {
                this.colorSala = value;
            }
        }

        public int Legajo
        {
            get
            {
                return this.legajo;
            }
            set
            {
                this.legajo = value;
            }
        }

        public float PrecioCuota
        {
            get
            {
                return this.precioCuota;
            }
            set
            {
                this.precioCuota = value;
            }
        }

        public Responsable Responsable
        {
            get
            {
                return this.responsable;
            }
            set
            {
                this.responsable = value;
            }
        }

        #endregion

        public Alumno (string nombre, string apellido, int dni, bool femenino, float precioCuota, EColores colorSala, int legajo, Responsable responsable)
            : base(nombre, apellido, dni, femenino)
        {
            this.colorSala = colorSala;
            this.legajo = legajo;      
            this.precioCuota = precioCuota;
            this.responsable = responsable;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString() + " - " + "Sala: " + this.colorSala + " - " + "Legajo: " + this.legajo + " - " + "Precio cuota: $" + this.precioCuota + " - " + "Responsable: " + this.responsable.Nombre + " " + this.responsable.Apellido);

            return sb.ToString();
        }

        public static bool operator == (Alumno a1, Alumno a2)
        {
            return a1.legajo == a2.legajo;
        }

        public static bool operator !=(Alumno a1, Alumno a2)
        {
            return (!(a1 == a2));
        }

        public static implicit operator Responsable(Alumno a)
        {
            return a.responsable;
        }

    }
}

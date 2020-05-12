using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum EColores { Naranja, Rojo, Amarillo, Verde }
    public enum Eturno { mañana, tarde }

    public class Aula
    {
        private List<Alumno> alumnos;
        private EColores colorSala;
        private Docente docente;
        private Eturno turno;

        #region Propiedades

        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }

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

        public Docente Docente
        {
            get
            {
                return this.docente;
            }
            set
            {
                this.docente = value;
            }
        }

        public Eturno Turno
        {
            get
            {
                return this.turno;
            }
            set
            {
                this.turno = value;
            }
        }

        #endregion

        public Aula(EColores colorSala, Eturno turno, Docente docente)
        {
            this.colorSala = colorSala;
            this.turno = turno;
            this.docente = docente;
        }

        public static bool operator + (Aula aula, Alumno alumno)
        {
            bool retorno = false;
            bool Existe = false;

            //Verifico que el alumno NO pertenezca al aula
            foreach(Alumno a in aula.alumnos)
            {
                if(a == alumno)
                {
                    Existe = true;
                    break;
                }
            }

            if(Existe == false && aula.alumnos.Count < 30)
            {
                aula.alumnos.Add(alumno);
                retorno = true;
            }

            return retorno;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Color: " + this.colorSala + " - " + "Turno: " + this.turno + " - " + " Docente: " + this.docente.Nombre + " " + this.docente.Apellido);

            return sb.ToString();
        }

    }
}

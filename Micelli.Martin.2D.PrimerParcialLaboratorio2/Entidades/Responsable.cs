using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum eParentesco { Madre, Padre, Tia, Tio, Abuela, Abuelo, Otro }

    public class Responsable : Persona
    {
        private eParentesco parentesco;
        private string telefono;

        #region Propiedades

        public eParentesco Parentesco
        {
            get
            {
                return this.parentesco;
            }
            set
            {
                this.parentesco = value;
            }
        }

        public string Telefono
        {
            get
            {
                return this.telefono;
            }
            set
            {
                this.telefono = value;
            }
        }

        #endregion

        public Responsable (string nombre, string apellido, int dni, bool femenino, eParentesco parentesco, string telefono)
            : base (nombre, apellido, dni, femenino)
        {
            this.parentesco = parentesco;
            this.telefono = telefono;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString() + " - " + this.parentesco + " - " + this.telefono);

            return sb.ToString();
        }
    }
}

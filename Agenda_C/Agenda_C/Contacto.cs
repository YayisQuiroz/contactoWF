using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_C
{
    internal class Contacto : Persona
    {
		private string numero;

		public string Numero
		{
			get { return numero; }
			set { numero = value; }
		}
        private string correo;

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public Contacto() : base()
        {
            numero = string.Empty;
            correo= string.Empty;
        }
        public Contacto(String nombre, DateTime? fecha, string telefono, string correo) : base(nombre, fecha)
        {
            this.numero = telefono;
            this.correo = correo;
        }
        public override string ToString()
        {
            return base.ToString() + " " + numero + " " + correo;
        }
    }
}

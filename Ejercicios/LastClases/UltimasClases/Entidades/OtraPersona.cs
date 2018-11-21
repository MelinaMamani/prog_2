using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa;

namespace Entidades
{
    public class OtraPersona : PersonaExterna
    {
        public string Nombre { get { return base._nombre; } }
        public string Apellido { get { return base._apellido; } }
        public int Edad { get { return base._edad; } }
        public Externa.ESexo Sexo { get { return base._sexo; } }

        public OtraPersona(string nombre, string apellido, int edad, Externa.ESexo sexo)
            : base(nombre, apellido, edad, sexo)
        {

        }

        public string ObtenerDatos()
        {
            return this.Nombre + " " + this.Apellido + " " + this.Edad + " " + this.Sexo;
        }
    }
}

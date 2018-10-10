using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesM
{
    public class Gato : Mascota
    {
        #region Constructores
        public Gato(string nombre, string raza) : base(nombre, raza)
        {

        }
        #endregion

        #region Operadores
        public static bool operator !=(Gato g1, Gato g2)
        {
            return !(g1 == g2);
        }

        public static bool operator ==(Gato g1, Gato g2)
        {
            return g1.Nombre == g2.Nombre && g1.Raza == g2.Raza;
        }
        #endregion
        #region Metodos
        protected override string Ficha()
        {
            return "Gato:\n" + base.DatosCompletos() + "\n";
        }

        public override bool Equals(object obj)
        {
            return (obj is Gato) ? (Gato)obj == this : false;
        }

        public override string ToString()
        {
            return this.Ficha();
        }
        #endregion
    }
}

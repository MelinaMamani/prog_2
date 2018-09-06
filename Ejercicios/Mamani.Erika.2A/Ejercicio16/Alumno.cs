using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Alumno
    {
        #region Atributos privados
        private byte _nota1;
        private byte _nota2;
        private float _notaFinal;
        #endregion

        #region Atributos publicos
        public string apellido;
        public int legajo;
        public string nombre;
        #endregion

        #region Constructor publico
        public Alumno(string ape, string nom, int leg)
        {
            this.apellido = ape;
            this.legajo = leg;
            this.nombre = nom;
        }
        #endregion

        #region Métodos
        public void CalcularFinal()
        {
            if (this._nota1 >= 4 && this._nota2 >= 4)
            {
                Random rdm = new Random();
                this._notaFinal = rdm.Next(6, 10);
            }
            else
                this._notaFinal = -1;
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this._nota1 = notaUno;
            this._nota2 = notaDos;
        }

        public void Mostrar()
        {
            Console.WriteLine("Alumno y legajo: {0} {1}, {2}", this.apellido, this.nombre, this.legajo);
            Console.WriteLine("Nota A y B: {0}, {1}", this._nota1, this._nota2);

            if (this._notaFinal != -1)
            {
                Console.WriteLine("Nota final: {0}", this._notaFinal);
            }
            else
                Console.WriteLine("Alumno desaprobado");
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace EntidadesCocina
{
    public class DepositoDeCocinas
    {
        private int _capacidadMaxima;
        private List<Cocina> _lista;

        public DepositoDeCocinas(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Cocina>();
        }

        public static bool operator +(DepositoDeCocinas d, Cocina a)
        {
            bool var = false;

            if (d._lista.Count < d._capacidadMaxima)
            {
                d._lista.Add(a);
            }

            return var;
        }

        private int GetIndice(Cocina a)
        {
            int indice = -1;

            for (int i = 0; i < this._lista.Count; i++)
            {
                if (a == this._lista[i])
                {
                    indice = i;
                    break;
                }
            }

            return indice;
        }

        public static bool operator -(DepositoDeCocinas d, Cocina a)
        {
            bool var = false;

            if (d.GetIndice(a) > -1)
            {
                d._lista.Remove(a);
                var = true;
            }

            return var;
        }

        public bool Agregar(Cocina a)
        {
            return this + a;
        }

        public bool Remover(Cocina a)
        {
            return this - a;
        }

        public override string ToString()
        {
            string cadena = "Capacidad: " + this._capacidadMaxima;

            for (int i = 0; i < this._lista.Count; i++)
            {
                cadena += this._lista[i].ToString();
            }

            return cadena;
        }

        public bool Guardar(string cad)
        {
            bool var;

            try
            {
                using (StreamWriter sw = new StreamWriter("C:/Users/alumno/Desktop/cocinas.txt"))
                {
                    sw.WriteLine(cad);
                }

                var = true;
            }
            catch (Exception)
            {

                Console.WriteLine("No se pudo escribir.");
                var = false;
            }

            return var;
        }

        public bool Recuperar(string cad)
        {
            bool var;
            
            try
            {
                using (StreamReader sr = new StreamReader(cad))
                {
                    Console.WriteLine("Documento: ");
                    Console.WriteLine(sr.ReadToEnd());
                }

                var = true;
            }
            catch (Exception)
            {

                Console.WriteLine("No se pudo escribir.");
                var = false;
            }

            return var;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Entidades.RPP
{
  public class ClaseConstructores
  {
        static ClaseConstructores()
        {
            MessageBox.Show("Estoy en el cons. estatico");
            ClaseConstructores c1 = new ClaseConstructores("a", 2);
        }
        private ClaseConstructores(string nombre, int edad)
        {
            MessageBox.Show("Estoy en el cons. priv. de parametros");

        }
        public ClaseConstructores()
        {

            MessageBox.Show("Estoy en el cons. por defecto.");
            this.Escritura = 2;


        }

        public int Escritura
        {
            set
            {
                MessageBox.Show("Estoy en prop. escritura");
                string ahre = this.Lectura;
            }
        }
        public string Lectura
        {
            get
            {
                MessageBox.Show("Estoy en prop. lectura");
                return this.MetodoInstancia().ToString();
            }
        }

        private int MetodoInstancia()
        {
            MessageBox.Show("Estoy en metodo instancia");
            return ClaseConstructores.MetodoEstatico();
        }

        private static int MetodoEstatico()
        {
            MessageBox.Show("Estoy en metodo estatico");
            return 2;
        }
    }
}

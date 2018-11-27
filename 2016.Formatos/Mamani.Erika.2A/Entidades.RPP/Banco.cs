using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades.RPP
{
  public abstract class Banco
  {
    private string nombre;
    public string Nombre { get { return this.nombre; } }

    public Banco(string nom)
    {
      this.nombre = nom;
    }

    //public abstract string Mostrar()
    //{
    //  return "Nombre: " + this.nombre;
    //}

    //public abstract string Mostrar(Banco bn)
    //{
    //  return "Nombre: " +bn.nombre;
    //}
  }
}

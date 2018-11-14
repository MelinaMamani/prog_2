using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace Entidades
{
  public delegate void CajonDelegado(object objeto, EventArgs evento);

  public class Cajon<T> : ISerializar
  {
    protected int _capacidad;
    protected List<T> _elementos;
    protected double _precioUnitario;

    public List<T> Elementos
    {
      get
      {
        return this._elementos;
      }
    }
    public event CajonDelegado EventoPrecio;

    public static void Manejador(object objeto, EventArgs evento)
    {
      StreamWriter escritor = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)+ "Archivo.txt");
      escritor.WriteLine("Precio total: " + ((Cajon<T>)objeto)._capacidad * ((Cajon<T>)objeto)._precioUnitario);
      escritor.WriteLine("Horario" + DateTime.Now);
      escritor.Close();
    }

    public double PrecioTotal
    {
      get
      {
        if (this._precioUnitario * this.Elementos.Count > 55)
        {
          this.EventoPrecio += new CajonDelegado(Manejador);
          this.EventoPrecio(this, new EventArgs());
        }
        return this._precioUnitario * this.Elementos.Count;
      }
    }

    public Cajon()
    {
      this._elementos = new List<T>();
    }

    public Cajon(int cap) : this()
    {
      this._capacidad = cap;
    }

    public Cajon(double precioU, int cap) : this (cap)
    {
      this._precioUnitario = precioU;
    }

    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine("Cajon:");
      sb.AppendLine("Capacidad Maxima: " + this._capacidad);
      sb.AppendLine("Precio por unidad: " + this._precioUnitario + "\n");
      foreach (T f in this.Elementos)
      {
        sb.AppendLine(f.ToString());
      }
      sb.AppendLine("Precio Total: " + this.PrecioTotal + "\n");
      return sb.ToString();
    }

    public static Cajon<T> operator +(Cajon<T> cajon, T f)
    {
      if (f is Fruta && (cajon.Elementos.Count < cajon._capacidad))
      {
        cajon.Elementos.Add(f);
      }
      else if (cajon.Elementos.Count >= cajon._capacidad)
        {
          throw new CajonLlenoException("El cajon esta lleno");
        }
      
      return cajon;
    }

    public bool Xml(string archivo)
    {
      XmlTextWriter writer = new XmlTextWriter(archivo, Encoding.UTF8);
      XmlSerializer serializer = new XmlSerializer(typeof(Cajon<T>));
      serializer.Serialize(writer, this);
      writer.Close();
      return true;
    }
  }
}

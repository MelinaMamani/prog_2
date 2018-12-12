using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.RPP;

//DESARROLLAR DENTRO DEL NAMESPACE RAIZ ENTIDADES.RPP EN UN PROYECTO DE TIPO CLASS LIBRARY

namespace rec.primer.parcial
{
    public partial class Form1 : Form
    {
        private BancoNacional _bn;
        private BancoProvincial _bp;
        private BancoMunicipal _bm;

        public Form1()
        {
            InitializeComponent();
        }

        //Crear dos objetos de tipo Deposito, cada uno de estos objetos contiene una lista de la clase Producto.
        //Un constructor por default (inicializa en 3 productos) y una sobrecarga que reciba la cantidad de productos 
        //del depósito (REUTILIZAR CODIGO). 
        //La clase Producto tiene dos atributos: nombre y stock y un único constructor.
        //Se debe poder sumar las listas de los dos depósitos (con la sobrecarga de un operador en la clase Deposito) 
        //y guardar el valor que retorna en una lista de Productos, recordar que si un producto está en las dos listas, 
        //se debe sumar el stock y no agregar dos veces al mismo producto.
        //Mostrar el contenido del array resultante (nombre y stock)
        private void button1_Click(object sender, EventArgs e)
        {
            Producto p1 = new Producto("tomate", 10);
            Producto p2 = new Producto("azucar", 25);
            Producto p3 = new Producto("yerba", 30);
            Producto p4 = new Producto("cafe", 5);

            Deposito d1 = new Deposito(5);
            Deposito d2 = new Deposito();

            d1.productos.Add(p1);
            d1.productos.Add(p2);
            d1.productos.Add(p3);
            d1.productos.Add(p4);

            d2.productos.Add(p1);
            d2.productos.Add(p1);
            d2.productos.Add(p2);

            List<Producto> aux = d1 + d2;

            String s = "";
            foreach (Producto item in aux)
            {
                if(item != null)
                s += (item.nombre + " - " + item.stock + "\n");
            }
            //tomate-->30
            //azucar-->50
            //yerba-->30
            //cafe-->5
            MessageBox.Show(s);

        }

        //Crear una clase (ClaseConstructores) que al instanciarse:
        //    1)pase por un constructor estático
        //    2)pase por un constructor que reciba 2 parámetros (privado)
        //    3)pase por un constructor publico (default)
        //    4)pase por una propiedad de sólo escritura
        //    5)pase por una propiedad de sólo lectura
        //    6)pase por un método de instancia
        //    7)pase por un método de clase
        //NOTA: el orden no se puede alterar.
        //NOTA: por cada lugar que pase, mostrar con un MessageBox.Show dicho lugar
        //NOTA: agregar la referencia a System.Windows.Form; para poder acceder a la clase MessageBox.
        //NOTA: NO MAS DE 2 LINEAS DE CODIGO POR METODO/PROPIEDAD/CONSTRUCTOR
        private void button2_Click(object sender, EventArgs e)
        {
            ClaseConstructores o = new ClaseConstructores();
        }

        //Crear jerarquía que contenga los siguientes constructores (1 por clase):
        //Banco(nombre)
        //BancoNacional(nombre, pais)
        //BancoProvincial(bancoNacional, provincia)
        //BancoMunicipal(bancoProvincial, municipio)
        //Crear una instancia de cada clase e inicializar los atributos del form: 
        //_bancoNacional, _bancoProvincial y _bancoMunicipal. 
        private void button3_Click(object sender, EventArgs e)
        {
            BancoNacional bn = new BancoNacional("Banco de la Alegría", "Argentina");
            BancoProvincial bp = new BancoProvincial(bn, "Buenos Aires");
            BancoMunicipal bm = new BancoMunicipal(bp, "Avellaneda");

            this._bn = bn;
            this._bp = bp;
            this._bm = bm;

        }

        //Agregar en Banco el método Mostrar():string y Mostrar(Banco):string, ambos abstractos.
        //El método que no recibe parámetros, retornará el nombre, mientras que el otro
        //retornará todas las características de la instancia que recibe como parametro. REUTILIZAR CODIGO.
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this._bn.Mostrar() + ":\n" + this._bn.Mostrar(this._bn));
            MessageBox.Show(this._bp.Mostrar() + ":\n" + this._bn.Mostrar(this._bp));
            MessageBox.Show(this._bm.Mostrar() + ":\n" + this._bn.Mostrar(this._bm));

        }

        //Agregar en la clase BancoMunicipal una sobrecarga en el implicit para que retorne todas
        //las características de la instancia en formato string. Aplicar polimorfismo sobre el método ToString
        //que deberá reutilizar código.
        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this._bm);
        }

        //A partir de la clase depósito, crear la clase DepositoIndexado, modificando
        //el modificador de visibilidad del atributo productos (a privado)
        //Generar un indexador sobre DepositoIndexado. Por defecto, de 3 elementos.
        //Aplicar las validaciones necesarias.
        private void button6_Click(object sender, EventArgs e)
        {
            DepositoIndexado d = new DepositoIndexado(3);

            Producto p1 = new Producto("tomate", 10);
            Producto p2 = new Producto("azucar", 25);
            Producto p3 = new Producto("yerba", 30);

            d[-1] = p1;
            d[0] = p1;
            d[1] = p2;
            d[2] = p3;
            d[3] = p3;

            String s = "";
            for (int i = 0; i < 3; i++)
            {
                s += (d[i].nombre + " - " + d[i].stock + "\n");
            }

            MessageBox.Show(s);

        }

        //Crear en Deposito el metodo necesario para poder ordenar la lista de productos segun el criterio elegido
        private void button7_Click(object sender, EventArgs e)
        {
            Producto p1 = new Producto("tomate", 10);
            Producto p2 = new Producto("azucar", 25);
            Producto p3 = new Producto("yerba", 30);
            Producto p4 = new Producto("cafe", 5);

            Deposito d1 = new Deposito(4);

            d1.productos.Add(p1);
            d1.productos.Add(p2);
            d1.productos.Add(p3);
            d1.productos.Add(p4);

            String s = "";
      //ordenado por stock ascendente
      d1.productos = d1.OrdenadoPorStock(d1.productos.Count);
            for (int i = 0; i < 4; i++)
            {
                s += (d1.productos[i].nombre + " - " + d1.productos[i].stock + "\n");
            }

            MessageBox.Show(s);

        }

        //Crear en Deposito el metodo necesario para poder ordenar la lista de productos segun el criterio elegido
        private void button8_Click(object sender, EventArgs e)
        {
            Producto p1 = new Producto("tomate", 10);
            Producto p2 = new Producto("azucar", 25);
            Producto p3 = new Producto("yerba", 30);
            Producto p4 = new Producto("cafe", 5);

            Deposito d1 = new Deposito(4);

            d1.productos.Add(p1);
            d1.productos.Add(p2);
            d1.productos.Add(p3);
            d1.productos.Add(p4);

            String s = "";
      //ordenado por nombre alfabeticamente
      d1.productos = d1.OrdenadoPorNombre(d1.productos.Count);
            for (int i = 0; i < 4; i++)
            {
                s += (d1.productos[i].nombre + " - " + d1.productos[i].stock + "\n");
            }

            MessageBox.Show(s);

        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAFIP;

namespace ConsolaVehiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            Deportivo dep = new Deportivo(2313, "YUD 234", 490);
            Familiar fam = new Familiar(3222, "DSD 343", 9);
            Carreta car = new Carreta(1000);

            Comercial com = new Comercial(24233, 1200, 500);
            Privado pri = new Privado(3232, 1000, 5);

            dep.MostrarPrecio();
            dep.MostrarPatente();

            com.MostrarPrecio();

            Console.WriteLine("");

            Console.WriteLine("Impuestos nacionales");
            Console.WriteLine("Deportivo: "+Gestion.MostrarImpuestoNacional(dep));
            Console.WriteLine("Avion privado: "+Gestion.MostrarImpuestoNacional(pri));
            Console.WriteLine("Avion comercial: "+Gestion.MostrarImpuestoNacional(com));

            Console.WriteLine("");

            Console.WriteLine("Impuestos provinciales");
            Console.WriteLine("Carreta: "+Gestion.MostrarImpuestoProvincial(car));
            Console.WriteLine("Deportivo: "+Gestion.MostrarImpuestoProvincial(dep));
            Console.WriteLine("Privado: "+Gestion.MostrarImpuestoProvincial(pri));
            Console.WriteLine("Comercial: "+Gestion.MostrarImpuestoProvincial(com));

            Console.ReadKey();
            
        }
    }
}

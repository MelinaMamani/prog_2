using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesP;

namespace VehiculoProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();

            Lavadero lavadero = new Lavadero("---");
            Auto a1 = new Auto("3410", EMarcas.Scania, 4);
            Moto m1 = new Moto(EMarcas.Honda, 200, "B101", 4);
            Auto a3 = new Auto("O705", EMarcas.Zanella, 4);
            Camion c4 = new Camion(new Vehiculo("Z103", 6, EMarcas.Ford), 40);

            lavadero += a1;
            vehiculos.Add(a1);
            lavadero += m1;
            vehiculos.Add(m1);
            lavadero += a3;
            vehiculos.Add(a3);
            lavadero += c4;
            vehiculos.Add(c4);
            vehiculos.Sort(lavadero.OrdenarVehiculosPorMarca);

            foreach (Vehiculo vehiculo in vehiculos)
            {
                Console.WriteLine(vehiculo.ToString());
            }

            Console.ReadLine();
        }
    }
}

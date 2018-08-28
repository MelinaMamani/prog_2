using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Por teclado se ingresa el valor hora, el nombre, la antigüedad (en años) y la cantidad de horas trabajadas
 * en el mes de n empleados de una fábrica. Se pide calcular el importe a cobrar teniendo en cuenta que el
 * total (que resulta de multiplicar el valor hora por la cantidad de horas trabajadas), hay que sumarle la
 * cantidad de años trabajados multiplicados por $ 150, y al total de todas esas operaciones restarle el 13%
 * en concepto de descuentos. Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora,
 * el total a cobrar en bruto, el total de descuentos y el valor neto a cobrar de todos los empleados ingresados.*/

namespace Ejercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            char rta ='s';
            int hora;
            string nombre;
            int anios;
            int cant;
            int total;
            int totalAnios;
            float descuento;
            float bruto;
            float neto;
            float todos = 0;

            while (rta.Equals('s'))
            {
                Console.Write("Ingrese el valor de la hora: ");
                hora = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el nombre: ");
                nombre = Console.ReadLine();

                Console.Write("Ingrese antigüedad: ");
                anios = int.Parse(Console.ReadLine());

                Console.Write("Ingrese cant. de horas: ");
                cant = int.Parse(Console.ReadLine());

                total = hora * cant;
                totalAnios = anios * 150;
                descuento = (float)(((total+totalAnios)*13)/100);
                bruto = total + totalAnios;
                neto = (total + totalAnios) - descuento;

                Console.WriteLine("Nombre: {0}, hora cobrada: {1}, años trabajados: {2}, cant. horas: {3}, " +
                    "salario bruto: {4:.00}, salario neto: {5:.00}", nombre, hora, anios, cant, bruto, neto);

                todos = todos + neto;

                Console.Write("Desea continuar? s/n ");
                rta = (char)(Console.Read());
                Console.ReadLine();
            }
            Console.WriteLine("Salario neto de todos: {0:.00}", todos);

        }
    }
}

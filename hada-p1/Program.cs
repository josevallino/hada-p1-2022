using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    class Program
    {
        static void Main(string[] args)
        {
            char continuar;
            double conversion;
            do
            {
                // solicita la unidad a partir de la cual hacer la conversion
                Console.WriteLine("Unidad (Horas [h] / minutos [m] / segundos [s]): ");
                char unidad = char.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad: ");
                double cantidad = double.Parse(Console.ReadLine());
                
                // Dependiendo de la unidad introducida y la catidad se realiza la conversion deseada
                if (unidad == 'm')
                {
                    conversion = HadaP1.Minutes2Seconds(cantidad);
                    Console.WriteLine(cantidad + " minutos son " + conversion + " segundos");
                }
                else
                {
                    conversion = HadaP1.Seconds2Minutes(cantidad);
                    Console.WriteLine(cantidad + " segundos son " + conversion + " minutos");
                }
              
                Console.WriteLine("¿Realizar más conversiones? (s/n): ");
                continuar = char.Parse(Console.ReadLine());
            } while (continuar != 'n');
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //fiebre = resfriado
            //fiebre, dolor de cabeza = infeccion
            //fiebre dolor de cabeza, hpoglusemia = covid
            Console.WriteLine("¿Tienes fiebre? [si/no]");
            string respuesta = Console.ReadLine();
            if (respuesta == "si")
            {
                Console.WriteLine("¿Tienes dolor de cabeza? [si/no] ");
                string respuesta2 = Console.ReadLine();
                if (respuesta2 == "si")
                {
                    Console.WriteLine("¿Tienes hipoglusemia? [si/no] ");
                    string respuesta3 = Console.ReadLine();
                    if(respuesta3 == "si")
                    {
                        Console.WriteLine("usted es candidato a COVID");
                    }
                    else
                    {
                        Console.WriteLine("usted tiene INFECCION");
                    }
                }
                else
                {
                    Console.WriteLine("usted tiebe UN RESFRIADO");
                }
            }
            else
            {
                Console.WriteLine("Usted no es candidato a COVID");
            }
            Console.ReadKey();
        }
    }
}

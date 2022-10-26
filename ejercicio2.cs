using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            int num1, num2;
            int resultado = 0;

            Console.WriteLine("Calculadora aritmetica");
            Console.WriteLine("Suma = 1");
            Console.WriteLine("Multiplicación = 2");
            Console.WriteLine("Resta = 3");
            Console.WriteLine("División = 4");
            Console.Write("Ingresa la operación deseada: ");
            opcion = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la primera cantidad: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la segunda cantidad: ");
            num2 = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    
                    resultado = num1 + num2;
                    break;
                case 2:
                   
                    resultado = num1 * num2;
                    break;
                case 3:
              
                    resultado = num1 - num2;
                    break;

                case 4:
               
                    resultado = num1 / num2;
                    break;
            }

            Console.Write("El resultado es: " + resultado);
            Console.ReadKey();

        }
    }
}

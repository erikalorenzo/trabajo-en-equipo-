using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            double r = 0;
            Console.WriteLine("ingresa el primer numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingresar el segundo numero");
            num2 = int.Parse(Console.ReadLine());


            r = (num1 + num2) * (num1 - num2);

            Console.WriteLine("el resultado es:" + r);
            Console.ReadKey();

        }
    }
}

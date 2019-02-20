using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura
{
    class Program
    {
        static void Main()
        {

            Figura figura1 = new Figura();
            figura1.b = 4;
            figura1.h = 4;
            figura1.t = 0;

            figura1.Area();
            Console.WriteLine("El area es: " + figura1.a);

            Figura figura2 = new Figura();
            figura2.b = 6;
            figura2.h = 4;
            figura2.t = 2;

            figura2.Area();
            Console.WriteLine("El area es: " + figura2.a);

            Figura figura3 = new Figura();
            figura3.b = 4;
            figura3.h = 4;
            figura3.t = 1;

            figura3.Area();
            Console.WriteLine("El area es: " + figura3.a);

            if (figura1.a > figura2.a && figura1.a > figura3.a) Console.WriteLine("La primer figura tiene la mayor area");
            else if (figura2.a > figura1.a && figura2.a > figura3.a) Console.WriteLine("La segunda figura tiene la mayor area");
            else Console.WriteLine("La tercera figura tiene la mayor area");
        }
    }
}

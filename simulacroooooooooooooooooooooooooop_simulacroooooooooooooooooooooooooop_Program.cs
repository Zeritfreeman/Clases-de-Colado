using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulacroooooooooooooooooooooooooop
{
    class Program
    {
        static void Main()
        {
            Punto1 p1 = new Punto1();
            Punto1 p2 = new Punto1(3,5);
            Punto1 p3 = new Punto1("xd");

            p1.x = 3;
            Punto1.y = 5;

            Punto2 P = new Punto2(1.2,2.3,3.4,4.5);
            Console.Write(P.Calculopromedio());
            
            Punto2 punto3 = new Punto3(7, 6, 5, 4);
            Console.Write("  p3 " + punto3.Calculopromedio());
            Punto4 punto4 = new Punto4();

            Random aleatorio = new Random();
            Console.WriteLine(aleatorio.Next(0, 6));
        }
    }
}

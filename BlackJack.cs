using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    class Program
    {
        static void Main()
        {
            Carta carta1 = new Carta();

            for(int i = 0; i < 10; i++)
            {
                carta1.Generar();
                Console.WriteLine(carta1.carta);
            }
        }
    }
}

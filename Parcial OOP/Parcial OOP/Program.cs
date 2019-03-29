using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_OOP
{
    class Program
    {
        static void Main()
        {
            double[] datos1_ = { 0, 2, 4, 6, 8, 10 };
            double[] datos2_ = { 1, 3, 5, 7, 9, 11 };

            Generador generador1 = new Generador(10);
            Generador generador2 = new Generador(10, 1, 6);
            Generador generador3 = new Generador(datos1_);
            Generador generador4 = new Generador(datos2_);

            Estadistica estadistica1 = new Estadistica(generador3);
            Estadistica estadistica2 = new Estadistica(generador4);
            Estadistica[] estadisticas = { estadistica1, estadistica2 };

            Estadistica pseudoEstadistica1 = new PseudoEstadistica(generador4);

            for (int i = 0; i < generador1.datos.Length; i++)
            {
                Console.WriteLine(generador1.datos[i]);
            }

            for (int i = 0; i < generador2.datos.Length; i++)
            {
                Console.WriteLine(generador2.datos[i]);
            }

            for (int i = 0; i < generador3.datos.Length; i++)
            {
                Console.WriteLine(generador3.datos[i]);
            }

            Console.WriteLine(estadisticas[0].Calcular());

            for (int i = 0; i < estadisticas[0].datosG.Length; i++)
            {
                Console.WriteLine(estadisticas[0].datosG[i]);
            }

            Console.WriteLine(pseudoEstadistica1.Calcular());
        }
    }
}

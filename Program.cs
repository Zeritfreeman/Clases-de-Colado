using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseTriangulo
{
    class Program
    {
        static void Main()
        {

            Punto[] puntos = new Punto[4];

            for (int i = 0; i < puntos.Length; i++)
            {
                puntos[i] = new Punto();

                Console.WriteLine("Ingrese la componente x");
                puntos[i].x = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la componente y");
                puntos[i].y = double.Parse(Console.ReadLine());
            }

            Triangulo triangulo = new Triangulo();
            triangulo.coordenadas = puntos;
            triangulo.Clasificar();
        }
    }
}


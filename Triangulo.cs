using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseTriangulo
{
    class Triangulo
    {
        public Punto[] coordenadas;
        bool validado = false;

        public void Validar()
        {
            if (coordenadas.Length == 4) 
            {
                Console.WriteLine("Cumplió cantidad de puntos");
                double pendiente1 = ((coordenadas[0].y - coordenadas[1].y) / (coordenadas[0].x - coordenadas[1].x));
                double pendiente2 = ((coordenadas[1].y - coordenadas[2].y) / (coordenadas[1].x - coordenadas[2].x));
                double pendiente3 = ((coordenadas[2].y - coordenadas[3].y) / (coordenadas[2].x - coordenadas[3].x));

                if (pendiente1 != pendiente2 && pendiente2 != pendiente3) {
                    Console.WriteLine("Cumplió NO colinealidad");
                    if (coordenadas[0].x == coordenadas[3].x && coordenadas[0].y == coordenadas[3].y) {
                        Console.WriteLine("Cumplió figura cerrada");
                        validado = true;

                    }
                }
            }
        }

        public void Clasificar()
        {
            Validar();
            if (validado)
            {
                double distancia1 = Math.Sqrt(Math.Pow((coordenadas[0].x - coordenadas[1].x), 2) + Math.Pow((coordenadas[0].y - coordenadas[1].y), 2));
                double distancia2 = Math.Sqrt(Math.Pow((coordenadas[1].x - coordenadas[2].x), 2) + Math.Pow((coordenadas[1].y - coordenadas[2].y), 2));
                double distancia3 = Math.Sqrt(Math.Pow((coordenadas[2].x - coordenadas[3].x), 2) + Math.Pow((coordenadas[2].y - coordenadas[3].y), 2));

                if (distancia1 == distancia2 && distancia2 == distancia3) Console.WriteLine("El triangulo es equilatero");
                else if (distancia1 == distancia2 || distancia2 == distancia3 || distancia3 == distancia1) Console.WriteLine("El triangulo es isoseles");
                else Console.WriteLine("El triangulo es escaleno");
            }
        }
    }
}

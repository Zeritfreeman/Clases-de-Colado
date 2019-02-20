using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseTriangulo
{
    class Punto
    {
        Random aleatorio = new Random();

        public double x = 0, y = 0;

        public void Aleatorizar()
        {
            x = aleatorio.Next(-100, 100);
            y = aleatorio.Next(-100, 100);
        } 
    }
}

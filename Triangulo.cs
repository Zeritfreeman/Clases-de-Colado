using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura2
{
    class Triangulo
    {
        public double[] lados;
        public string tipo;

        public void Validar()
        {
            if (lados.Length != 3 || lados[0] > (lados[1] + lados[2]) || lados[1] > (lados[0] + lados[2]) || lados[2] > (lados[0] + lados[1])) Console.WriteLine("Eso no es un triangulo");
        }

        public void Calcular()
        {
            if (lados[0] == lados[1] && lados[0] == lados[2]) tipo = "Escaleno";
            if else (lados[0] == lados[1] || lados[0] == lados[2]) = ""
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Generador
{
    public double[] datos;
    Random aleatorio = new Random();
    public Generador(int n)
    {
        Estadistica.calcularEnUso += Estadistica_calcularEnUso;
        datos = new double[n];
        for (int i = 0; i < datos.Length; i++)
        {
            datos[i] = aleatorio.Next(1, 11);
        }
    }

    public Generador(int n, int a, int b)
    {
        Estadistica.calcularEnUso += Estadistica_calcularEnUso;
        datos = new double[n];
        for (int i = 0; i < datos.Length; i++)
        {
            datos[i] = aleatorio.Next(a, b + 1);
        }
    }

    public Generador(double[] datos_)
    {
        Estadistica.calcularEnUso += Estadistica_calcularEnUso;
        datos = datos_;
    }

    private void Estadistica_calcularEnUso(double[] _datos, double _resultado)
    {
        for (int i = 0; i < _datos.Length; i++)
        {
            Console.WriteLine(_datos[i]);
        }

        Console.WriteLine(_resultado);
    }
}

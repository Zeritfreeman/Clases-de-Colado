using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Estadistica
{
    double[] datos_;
    public delegate void Enconstruccion(double[] _datos, double _resultado);
    public static event Enconstruccion calcularEnUso;

    public Estadistica(Generador generador)
    {
        datos_ = generador.datos;
    }

    public double[] datosG { get { return datos_; } }

    public virtual double Calcular()
    {
        double sumatoria = 0;
        for (int i = 0; i < datos_.Length; i++)
        {
            sumatoria += datos_[i];
        }

        double promedio = sumatoria / datos_.Length;

        if(calcularEnUso != null) calcularEnUso(datos_, promedio);

        return promedio;
    }
}


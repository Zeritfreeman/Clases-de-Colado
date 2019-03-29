using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PseudoEstadistica : Estadistica
{
    double[] datosD;

    public PseudoEstadistica(Generador generador) : base(generador)
    {
        datosD = generador.datos;
    }

    public override double Calcular()
    {

        double promedio = base.Calcular();
        double diferencia = 0;

        for (int i = 0; i < datosD.Length; i++)
        {
            diferencia += (datosD[i] - promedio) * (datosD[i] - promedio);
        }

        return Math.Sqrt(diferencia / datosD.Length);
    }
}


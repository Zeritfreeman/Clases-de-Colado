using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Punto3 : Punto2
{
    public Punto3(double v1_, double v2_, double v3_, double v4_) : base(v1_, v2_, v3_, v4_)
    {
    }
    public override double Calculopromedio()
    {
        double promedio = (v3 + v4)/ 2;
        return promedio;
    }

}

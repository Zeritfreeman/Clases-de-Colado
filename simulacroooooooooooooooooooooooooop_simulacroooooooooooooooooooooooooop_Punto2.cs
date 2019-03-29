using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Punto2
{
    private double v1;

    public double V1{get { return v1;}}

    private double v2;

    public double V2 { set { if (v2 < 10) v2 = value; } }
    protected double v3;
    protected double v4;

    public Punto2(double v1_, double v2_, double v3_, double v4_)
    {
        v1 = v1_;
        v2 = v2_;
        v3 = v3_;
        v4 = v4_;
    }

    public virtual double Calculopromedio()
    {
        double promedio = (v1 + v2) / 2;
        return promedio;
    }
}


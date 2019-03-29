using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Punto4
{

    public delegate void Enconstruccion();
    public static event Enconstruccion enco;
    public Punto4()
    {
        enco();
    }

}


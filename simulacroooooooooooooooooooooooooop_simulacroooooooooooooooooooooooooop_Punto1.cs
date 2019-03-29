using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class Punto1
    {
    public int x;
    public static int y;
    public Punto1()
    {
        Punto4.enco += Punto4_enco;
    }

    public Punto1(int a_, int b_)
    {
        Punto4.enco += Punto4_enco;
    }
    public Punto1(string txt)
    {
        Punto4.enco += Punto4_enco;
    }
    private void Punto4_enco()
    {
        Console.WriteLine("\n4 ha sido creado");
    }
}


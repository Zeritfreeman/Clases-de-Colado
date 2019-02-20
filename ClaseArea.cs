using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura
{
    class Figura
    {
        public double b;
        public double h;
        public int t;
        public double a;

        public void Area()
        {
            if (t == 0) a = (b * b);
            else if (t == 2) a = (b * h);
            else a = ((b * h) / 2);
        }


    }
}

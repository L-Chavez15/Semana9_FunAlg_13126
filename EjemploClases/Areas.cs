using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploClases
{
    public class Areas
    {
        //muchosmetodos- funcionalidades
        //recomendable ponerlo publico
        //No olvidar el Public, es importante
        public double AreaCuadrado(double l)
        {
            double a;
            a = Math.Pow(l, 2);
            return a;
        }
        public double AreaTriangulo (double b, double h)
        {
            return (b * h) / 2;
        }
        public double AreaCirculo(double r)
        {
            //pi es una constante númerica
            double a;
            a = Math.PI * Math.Pow(r, 2);
            return a;
        }
        public double AreaRectangulo(double b, double h)
        {
            double a=b*h;
            return a;
        }
    }
}

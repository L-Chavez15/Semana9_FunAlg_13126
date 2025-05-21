using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploClases
{
    public class Perimetros
    {
        //public double PerimetroCirculo(double r)
        //{
        //    double p=2*Math.PI*r;
        //    return p;
        //}
        //public double PerimetroRectangulo(double h, double b)
        //{
        //    double p = (2 * h) + (2 * b);
        //    return p;
        //
        public void PerimetroCirculo(double r, ref double p)//ref= referencia, p-->espacio de memoria
        {
            p = 2 * Math.PI * r;//p direccion de memoria, ya no hay retorno 
        }
        public void PerimetroRectangulo (double b, double h, ref double p)
        {
            p = 2 * (b + h);
            Console.Write("BIBLIOTECAS");
        }
    }
}

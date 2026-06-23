using System;
using System.Collections.Generic;
using System.Text;

namespace BasicTypes
{
    internal class CalTriangulo
    {
        public double Altura;
        public double Largura;

        public double AreaTriangulo()
        {
            return Altura * Largura;
        }

        public double PerimetroTriangulo()
        {
            return 2 * (Altura + Largura);
        }

        public double DiagonalTriangulo()
        {
            return Math.Sqrt(Math.Pow(Altura,2) + Math.Pow(Largura,2));
        }
    }
}

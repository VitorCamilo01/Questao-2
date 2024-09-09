using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQuestão2
{
    internal class NumComplexo
    {
        private double Re;
        private double Im;
        public double Re1 { get => Re; set => Re = value; }
        public double Im1 { get => Im; set => Im = value; }

        public NumComplexo()
        {
            Re = 0.0;
            Im = 0.0;
        }

        public NumComplexo(double _Re, double _Im)
        {
            Re = _Re;
            Im = _Im;
        }

        public NumComplexo soma(NumComplexo temp)
        {
            return new NumComplexo(Re + temp.Re, Im + temp.Im);
        }

        public NumComplexo vezes(NumComplexo temp)
        {
            return new NumComplexo(Re * temp.Re - Im * temp.Im,
                                  Re * temp.Im + Im * temp.Re);
        }

        public double Modulo()
        {
            return Math.Sqrt(Re * Re + Im * Im);
        }

        public double Argumeto()
        {
            return Math.Atan2(Im, Re);
        }

        public void imprimeFormaPolar()
        {
            double tam = Modulo();
            double teta = Argumeto();
            Console.WriteLine(tam + " * (cos(" + teta + ") + i * sin(" + teta + "))");
        }
    }
}

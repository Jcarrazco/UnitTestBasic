using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Unit_Tested
{
    public class MathOp//Importante poner public en clases a testear para referenciarlos
    {
        public double Add(double V1, double V2)
        {
            return V1 + V2;
        }

        public double Substract(double V1, double V2)
        {
            return V1 - V2;
        }

        public double Multiply(double V1, double V2)
        {
            return V1 * V2;
        }

        public double Divide(double V1, double V2)
        {
            return V1 / V2;
        }
    }
}

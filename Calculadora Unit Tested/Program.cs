using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Unit_Tested
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            Double v1, v2;
            MathOp Mo = new MathOp();
            Console.WriteLine("Valor 1 es:");
            v1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Valor 2 es:");
            v2 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Tecle la operacion que desee realizar");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.WriteLine(Mo.Add(v1,v2));
                    break;
                case 2:
                    Console.WriteLine(Mo.Substract(v1, v2));
                    break;
                case 3:
                    Console.WriteLine(Mo.Multiply(v1, v2));
                    break;
                case 4:
                    Console.WriteLine(Mo.Divide(v1, v2));
                    break;
            }
            Console.ReadKey();

        }
    }
}

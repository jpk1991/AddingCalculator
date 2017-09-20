/// Taschenrechner für ganzzahlige Operationen.
/// Führt die Rechenoperationen ausschließlich durch Additionenn durch.
/// Unterstützte Operationen: +, -, *, /, ^
/// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AddingCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculations calc = new Calculations();
            calc.Plus(1, 2);
            calc.Minus(1, 2);
            calc.Multiply(1, 2);
            calc.Multiply(3, 4);
            calc.Multiply(4, 3);
            calc.Division(1, 2);
            calc.Exponential(1, 2);
            calc.Exponential(2, 3);
            Console.ReadKey();
        }
    }
}

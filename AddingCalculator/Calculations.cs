using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingCalculator
{
    class Calculations
    {
        /// <summary>
        /// Addiere zwei Zahlen
        /// </summary>
        /// <param name="Number1">Ganze Zahl zum addieren</param>
        /// <param name="Number2">Ganze Zahl zum addieren</param>
        /// <returns>Summe der beiden Zahlen</returns>
        public int Plus(int Number1, int Number2)
        {
           // Console.WriteLine($"Plus {Number1} + {Number2}");
            return Number1 + Number2;
        }

        /// <summary>
        /// Subtraktion von 2 ganzen Zahlen durch Addition des inversen der Zahl 2 mit Zahl 1
        /// </summary>
        /// <param name="Number1"></param>
        /// <param name="Number2"></param>
        /// <returns>Differenz der beiden Zahlen</returns>
        public int Minus(int Number1, int Number2)
        {
            return -Number2 + Number1;
        }

        /// <summary>
        /// Multiplikation von 2 ganzen Zahlen
        /// </summary>
        /// <param name="Number1"> Erster Faktor ganzzahlig</param>
        /// <param name="Number2">Zweiter Faktor ganzzahlig</param>
        /// <returns>Produkt der beiden Zahlen</returns>
        public int Multiply(int Number1, int Number2)
        {
            Console.Out.WriteLine($"Multiply {Number1} * {Number2}");
            int Sum = 0;
            for (int i = 0; i < Number1; i++)
            {
                Sum = Plus(Sum, Number2);
            }
            return Sum;
        }

        /// <summary>
        /// Ganzzahlige Division von zwei ganzen Zahlen
        /// </summary>
        /// <param name="Number1">Divisor ganzzahlig</param>
        /// <param name="Number2">Dividend</param>
        /// <returns>Ergebnis</returns>
        public int Division(int Number1, int Number2)
        {
            if (Number2 == 0)
            {
                throw new DivideByZeroException();
            }
            return 0;
        }

        /// <summary>
        /// Berechnung von Potenzen
        /// </summary>
        /// <param name="Basis"></param>
        /// <param name="Exponent"></param>
        /// <returns>Ergebnis</returns>
        public int Exponential(int Basis, int Exponent)
        {
            int Sum = 0;
            if (Basis == 0)
            {
                return 0;
            }
            else if (Exponent == 0)
            {
                return 1;
            }
            else if (Exponent > 0)
            {
                for (int i = 1; i < Exponent; i++)
                {
                    Sum += Multiply(Basis, Basis);
                }
            }
            return Sum;
        }
    }
}


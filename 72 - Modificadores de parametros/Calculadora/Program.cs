using System;

namespace Calculadora {
    class Program {
        static void Main(string[] args) {
            int s1 = Calculator.Sum( 2, 3 );
            int s2 = Calculator.Sum( 2, 3, 4, 5, 6, 9, 15 );

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}

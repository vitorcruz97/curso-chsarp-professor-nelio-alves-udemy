using System;
using System.Data.SqlTypes;
using System.Globalization;

namespace Vetores {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++) {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = name, Price = price };


            }

            double sum = 0;
            for (int i = 0; i < n; i ++) {
                sum += vect[i].Price;
            }

            double avg = sum / n;

            Console.WriteLine("Average Price = " + avg.ToString("F2", CultureInfo.InvariantCulture));

        }
            
    }
}

// Vetores -> Dados do mesmo tipo; ordenada por posições; alocada de uma vez;


// Tipo Struct

/*
 * int n = int.Parse(Console.ReadLine());

double[] vect = new double[n];

for (int i = 0; i < n; i++) {
    vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
}

double sum = 0;
for (int i = 0; i < n; i++) {
    sum += vect[i];
}

double avg = sum / n;

Console.WriteLine("Average Height = " + avg);
*/

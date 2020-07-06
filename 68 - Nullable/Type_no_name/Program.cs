using System;

namespace Type_no_name {
    class Program {
        static void Main(string[] args) {


            /*
            Nullable <double> x = null; // 1. Forma de declarar Nullable
            double? y = null;           // 2. Forma de declarar Nullable
            */

            double? x = null;
            double? y = 10.00;


            //1. Obtem o valor Default de variáveis nullable.
            Console.WriteLine(x.GetValueOrDefault()); 
            Console.WriteLine(y.GetValueOrDefault());
            
            //2. Informa que a variável possui valor.
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);


            if (x.HasValue)
                Console.WriteLine(x.Value);
            else 
                Console.WriteLine("X is null");

            if (y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("Y is null");

            //3. Coalecencia Nula (Se Nulo, retorna o valor à direita de '??')
            double? a = null;
            double? b = 10.00;

            double c = x ?? 5.00;
            double d = b ?? 5.00;

            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}

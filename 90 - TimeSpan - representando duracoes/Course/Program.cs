using System;

namespace Course {
    class Program {
        static void Main(string[] args) {

            TimeSpan t1;

            t1 = TimeSpan.FromDays(1.5);
            Console.WriteLine(t1);

            t1 = TimeSpan.FromHours(1.5);
            Console.WriteLine(t1);

            t1 = TimeSpan.FromMinutes(1.5);
            Console.WriteLine(t1);

            t1 = TimeSpan.FromMinutes(1.5);
            Console.WriteLine(t1);

            t1 = TimeSpan.FromSeconds(1.5);
            Console.WriteLine(t1);
            
            t1 = TimeSpan.FromMilliseconds(1.5);
            Console.WriteLine(t1);
            
            t1 = TimeSpan.FromTicks(900000000L);
            Console.WriteLine(t1);



        }
    }
}

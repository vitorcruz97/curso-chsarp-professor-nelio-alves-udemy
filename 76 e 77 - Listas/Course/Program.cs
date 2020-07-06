using System;
using System.Collections.Generic;

namespace Course {
    class Program {
        static void Main(string[] args) {
            List<string> list = new List<string>();

            //1. Adiciona itens ao final da lista
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");

            //2. Adiciona itens conforme índice no primeiro parâmetro
            list.Insert(2, "Marco");

            foreach(string obj in list) {
                Console.WriteLine(obj);
            }

            //3. Informa o tamanho da lista
            Console.WriteLine("List count: " + list.Count);

            //4. Retorna um predicado passado como parametro. 
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);
            
            //5. Retorna um predicado passado como parametro, porém a última ocorrência.
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            //
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);

            Console.WriteLine("---------------------------");
            List<string> list2 = list.FindAll(x => x.Length == 5);
            foreach(string obj in list2) {
                Console.WriteLine(obj);
            }


            Console.WriteLine("---------------------------");            
            list.RemoveRange(2, 2);
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("---------------------------");
            list.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
        }
    }
}

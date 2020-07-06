using System;
using System.Collections.Generic;
using System.Globalization;

namespace Ex_Ficacao_Listas {
    class Program {
        static void Main(string[] args) {
           
            Console.Write("Quantos empregados deseja cadastrar: ");
            int registros = int.Parse(Console.ReadLine());


            List<Funcionario> funcionarios = new List<Funcionario>();

            for (int i = 1; i <= registros; i++) {
                Console.WriteLine("Funcionario: " + i);

                 Console.Write("ID: ");
                 int id = int.Parse(Console.ReadLine());

                 Console.Write("Nome: ");
                 string nome = Console.ReadLine();

                 Console.Write("Salario:  ");
                 double salario = double.Parse(Console.ReadLine());


                 Funcionario novoFuncionario = new Funcionario(nome, id, salario);

                 funcionarios.Add(novoFuncionario);
                 Console.WriteLine();
            }

            Console.WriteLine("Funcionarios Cadastrados: " + funcionarios.Count);
            Console.WriteLine();

            Console.Write("Qual o Id de quem deseja aumenar o salario: ");
            int id_procurado = int.Parse(Console.ReadLine());

            Funcionario empregado = funcionarios.Find(x => x.Id == id_procurado);

            if (id_procurado != null) {
                Console.Write("Entre com a porcentagem para o aumento: ");
                double porcentagem = double.Parse(Console.ReadLine());
                empregado.AumentoDeSalario(porcentagem);

            } else {
                Console.WriteLine("Este empregado não existe.");
            }

            Console.WriteLine();

            foreach(Funcionario obj in funcionarios) {
                Console.WriteLine(obj);
            }

        }
    }
}

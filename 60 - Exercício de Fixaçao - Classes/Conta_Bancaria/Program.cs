using System;
using System.Globalization;

namespace Conta_Bancaria {
    class Program {
        static void Main(string[] args) {

            Console.Write("Entre com o titular da conta: ");
            string nomeDoTitular = Console.ReadLine();

            Console.Write("Entre o número da conta: ");
            int contaBancaria = int.Parse(Console.ReadLine());

            Console.Write("Haverá depósito inicial (s/n) ?: ");
            string decisao = Console.ReadLine();

            Console.WriteLine("");

            if (decisao == "s" || decisao == "S")
            {
                Console.Write("Quantia: R$ " );
                double saldo = double.Parse(Console.ReadLine());

                DadosBancarios novaContaBancaria = new DadosBancarios(nomeDoTitular, contaBancaria, saldo);

                Console.WriteLine("Dados Atualizados: " + novaContaBancaria);
                Console.WriteLine();

                Console.Write("Entre com algum valor para deposito: ");
                saldo = double.Parse(Console.ReadLine());
                novaContaBancaria.InserirValor(saldo);

                Console.WriteLine();
                Console.WriteLine("Dados Atualizados: " + novaContaBancaria);

                Console.WriteLine();
                Console.Write("Entre com algum valor para saque: ");
                saldo = double.Parse(Console.ReadLine());
                novaContaBancaria.SacarValor(saldo);

                Console.WriteLine();
                Console.WriteLine("Dados Atualizados: " + novaContaBancaria);

            } else
            {
                DadosBancarios novaContaBancaria = new DadosBancarios(nomeDoTitular, contaBancaria);
                Console.WriteLine();
                Console.WriteLine("Dados Atualizados: " + novaContaBancaria);

                Console.WriteLine();
                Console.Write("Entre com algum valor para deposito: ");
                double saldo = double.Parse(Console.ReadLine());
                novaContaBancaria.InserirValor(saldo);

                Console.WriteLine();
                Console.WriteLine("Dados Atualizados: " + novaContaBancaria);

                Console.WriteLine();
                Console.Write("Entre com algum valor para saque: ");
                saldo = double.Parse(Console.ReadLine());
                novaContaBancaria.SacarValor(saldo);

                Console.WriteLine("Dados Atualizados: " + novaContaBancaria);

            }


        }
    }
}

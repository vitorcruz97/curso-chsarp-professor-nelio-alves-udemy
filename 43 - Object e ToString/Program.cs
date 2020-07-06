using System;
using System.Globalization;

namespace Problema_Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();


            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Dados do Produto: " + p);
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarAoEstoque(qte);


            Console.WriteLine();
            Console.Write("Dados Atualizados do Produto: " + p);
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverDoEstoque(qte);

            Console.WriteLine();
            Console.Write("Dados Atualizados do Produto: " + p);
            Console.WriteLine();


        }
    }
}

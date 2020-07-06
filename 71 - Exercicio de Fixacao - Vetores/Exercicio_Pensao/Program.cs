using System;
using System.Net.Http.Headers;

namespace Exercicio_Pensao {
    class Program {
        static void Main(string[] args) {

            

            Console.Write("Quantos quartos serão alugados? R: ");
            int quartos_reservados = int.Parse(Console.ReadLine());

            Pensao[] quartos = new Pensao[quartos_reservados];


            for (int i = 0; i < quartos_reservados; i++) {
                Console.WriteLine();
                Console.Write("Qual quarto deseja ficar: ");
                int quarto_selecionado = int.Parse(Console.ReadLine());
                
                Console.Write("Qual seu nome: ");
                string nome = Console.ReadLine();

                Console.Write("Qual seu email: ");
                string email = Console.ReadLine();
                

                quartos[i] = new Pensao {  nome = nome,
                                           email = email, 
                                           quarto_escolhido = quarto_selecionado
                };

            }

            Console.WriteLine();

            for (int index = 0; index < quartos_reservados; index++) {
                int quartos_da_pensao = quartos[index].quarto_escolhido;
                Console.Write(
                    "Quarto: "
                    + quartos_da_pensao
                    + ", Nome: "
                    + quartos[index].nome
                    + ", Email: "
                    + quartos[index].email
                    );
                    
            }

            /*Console.WriteLine("Quartos: " + quartos_da_pensao.ToString());*/
        }
    }
}

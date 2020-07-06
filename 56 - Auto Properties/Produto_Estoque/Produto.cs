using System;

using System.Globalization;

namespace Produto_Estoque {
    class Produto {
        // 1. Atributos Privados
        private string _Nome;

        // 2. Auto Properties
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }
        

        // 3. Construtores
        public Produto() {
        }

        
        public Produto(string nome, double preco, int quantidade) : this() {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        // 4. Propriedades Customizadas
        public string Nome {
            get { 
                return _Nome; 
            }
            set { 
                if (value != null && value.Length > 1) {
                    _Nome = value;
                }
            }
        }


        // 5. Métodos de Classe
        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }

        public override string ToString() {
            return _Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

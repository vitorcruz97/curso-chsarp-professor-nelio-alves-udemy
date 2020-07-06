using System;

using System.Globalization;

namespace Produto_Estoque {
    class Produto {
        private string _Nome;
        private double _Preco;
        private int _Quantidade;


        public Produto() {
            _Quantidade = 10;
        }

        public Produto(string nome, double preco, int quantidade) : this() {
            _Nome = nome;
            _Preco = preco;
            _Quantidade = quantidade;
        }

        public string GetNome() {
            return _Nome;
        }

        public void SetNome(string nome) {
            if (nome != null && nome.Length > 1) { 
                _Nome = nome;
            }
        }

        public double GetPreco() {
            return _Preco;
        }

        public int GetQuantidade() {
            return _Quantidade;
        }

        public double ValorTotalEmEstoque() {
            return _Preco * _Quantidade;
        }
        public void AdicionarProdutos(int quantidade) {
            _Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            _Quantidade -= quantidade;
        }
        public override string ToString() {
            return _Nome
            + ", $ "
            + _Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

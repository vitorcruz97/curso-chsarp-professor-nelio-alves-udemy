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


        public double Preco {
            get { return _Preco; }
        }

        public int Quantidade {
            get { return _Quantidade; }
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

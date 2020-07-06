using System;
using System.Globalization;

namespace Conta_Bancaria {
    class DadosBancarios {
        public string Titular { get; set; }

        public int Conta_Bancaria { get; private set; }

        public double Saldo { get; private set; }


        // Para aqueles que desejam começar com uma conta sem saldo. 
        public DadosBancarios(string titular, int conta_Bancaria) {
            Titular = titular;
            Conta_Bancaria = conta_Bancaria;
            Saldo = 0;

        }

        // Para aqueles que desejam inserir uma quantia inicial.
        public DadosBancarios(string titular, int conta_Bancaria, double saldo) : this(titular, conta_Bancaria) {
            Saldo = saldo;
        }

        public double SacarValor(double valor) {
            if (valor > 0) { 
                return Saldo -=  (valor + 3);
            }
            else {
                return Saldo;
            }
        }

        public double InserirValor(double saldo) {
            return Saldo += saldo;
        }

        public override string ToString() {
            return 
                "Conta: "
                + Conta_Bancaria
                + ", Titular: "
                + Titular
                + ", Saldo: R$ "
                + Saldo;
        }

    }
}

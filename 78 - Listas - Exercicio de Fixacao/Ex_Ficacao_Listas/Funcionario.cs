using System;
using System.Collections.Generic;
using System.Globalization;

namespace Ex_Ficacao_Listas {
    class Funcionario {

        public string Nome;
        public int Id;
        public double Salario;

        public Funcionario(string nome, int id, double salario) {
            Nome = nome;
            Id = id;
            Salario = salario;
        }

 
        public void AumentoDeSalario ( double porcentagem) {
            Salario += Salario * (porcentagem / 100.00);
            
        }

        

        public override string ToString() {
            return "ID: "
                + Id
                +", Nome: "
                + Nome
                + ", Salario: R$ "
                + Salario.ToString("F2", CultureInfo.InvariantCulture) ; 
        }
    }
}

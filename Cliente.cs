using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeContaBancária
{
    internal class Cliente
    {
        public string nome;
        public string email;
        private int senha;
        public ContaBancaria contaBancaria;

        public Cliente(string nome, string email, int senha, double saldo, bool credito, bool debito)
        {
            this.nome = nome;
            this.email = email;
            this.senha = senha;
            this.contaBancaria = new ContaBancaria(saldo, credito, debito);
           
        }

        public void Mostra()
        {

            Console.WriteLine($" Nome: {nome}, Email:{email}, Senha: {senha}");
            
        }








    }
}

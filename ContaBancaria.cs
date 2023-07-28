using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeContaBancária
{
    internal class ContaBancaria
    {

        private double saldo = 0;
        public bool credito = false;
        public bool debito = false;
        

        public ContaBancaria(double saldo, bool credito, bool debito)
        {

            this.saldo = saldo;
            this.credito = credito;
            this.debito = debito;
           
        }

        public void Mostra()
        {
       
                Console.WriteLine($"Saldo: {saldo} R$, Crédito: {credito}, Débito: {debito}");
          
        }

    }
}

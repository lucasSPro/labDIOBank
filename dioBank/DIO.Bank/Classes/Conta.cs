using System;

namespace DIO.Bank
{
    public class Conta
    {
        private TipoDeConta TipoConta{get; set;}
        private double  Saldo {get; set;}
        private double Credito {get; set;}
        private string Nome {get; set;}

        public Conta(TipoDeConta tipoConta, double saldo, double credito, string nome)
        {
            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.Credito = credito;
            this.Nome = nome;
        }
        public bool Sacar (double valorSaque)
        {
            //validação de saldo suficiente
            if(this.Saldo - valorSaque < (this.Credito *-1)){
                Console.WriteLine("saldo insuficiente!");
                return false;
            }
            this.Saldo -= valorSaque;
            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome ,this.Saldo);
            return true;
        }
        public void Depositar(double valorDeposito)
        {
            this.Saldo += valorDeposito;
            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome ,this.Saldo);
        }
        public void Transferir(double valorTransferencia, Conta contaDestino)
        {
            if(this.Sacar(valorTransferencia)){
                contaDestino.Depositar(valorTransferencia);
            }
        }
    }
    
}

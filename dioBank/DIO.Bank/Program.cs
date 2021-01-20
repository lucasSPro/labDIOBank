using System;

namespace DIO.Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta minhaConta = new Conta(TipoDeConta.PessoaFisica, 0, 0, "Lucas Santos");
            Console.WriteLine(minhaConta.ToString());
        }
    }
}

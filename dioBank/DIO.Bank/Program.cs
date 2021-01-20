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
        private static string ObterOpcaoUsiario()
        {
            Console.WriteLine();
            Console.WriteLine(" DIO Bank a seu dispor ");
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1 - Listar contas");
            Console.WriteLine("2 - Inserir nova conta");
            Console.WriteLine("3 - Transferr");
            Console.WriteLine("4 - Sacar");
            Console.WriteLine("5 - Depositar");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X - Sair");

            string opcaoUsuario =  Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}

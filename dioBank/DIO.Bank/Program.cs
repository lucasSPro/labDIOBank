using System;
using System.Collections.Generic;

namespace DIO.Bank
{
    class Program
    {
        static List<Conta> listContas = new List<Conta>();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsiario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarContas();
                        break;
                    case "2":
                        InserirConta();
                        break;
                    case "3":
                        //Transferir();
                        break;
                    case "4":
                        SacarDaConta();
                        break;
                    case "5":
                        //Depositar();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                   default:
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        private static void SacarDaConta()
        {
            Console.WriteLine(" Digite o número da conta: ");
            int indiceConta =  int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor e ser sacado: ");
            double valorSaque = double.Parse(Console.ReadLine());

            listContas[indiceConta].Sacar(valorSaque); 
        }

        private static void ListarContas()
        {
            Console.WriteLine("Lista de contas abertas:");

            if(listContas.Count == 0){
                Console.WriteLine("--- Nenhuma conta aberta. ---");
                return;
            }

            for (int i = 0; i < listContas.Count; i++)
            {
                Conta conta = listContas[i];
                Console.Write("#{0} - ", i);
                Console.WriteLine(conta);
            }
        }

        private static void InserirConta()
        {
            Console.WriteLine("Inserir nova conta.");
            Console.WriteLine("Digite 1 para Conta Fisica ou 2 para Juridica:");
            int entradaTipoConta =  int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do cliente:");
            string entradaNome = Console.ReadLine();

            Console.WriteLine("digite o saldo inicial:");
            double entradaSaldo =  double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o credito inicial:");
            double  entradaCredito = int.Parse(Console.ReadLine());

            Conta novaConta = new Conta(
                tipoConta: (TipoDeConta)entradaTipoConta,
                saldo: entradaSaldo,
                credito: entradaCredito,
                nome: entradaNome
                );
        }

        private static string ObterOpcaoUsiario()
        {
            Console.WriteLine();
            Console.WriteLine(" DIO Bank a seu dispor ");
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1 - Listar contas");
            Console.WriteLine("2 - Inserir nova conta");
            Console.WriteLine("3 - Transferir");
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

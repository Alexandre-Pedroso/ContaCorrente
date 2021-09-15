using System;

namespace AppConta
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente C1 = new ContaCorrente();

            C1.Correntista1 = "Wendell";
            C1.Conta1 = 055812;
            C1.Saldo1 = 000;
            double valor;
            int op = 1;
          

            Console.WriteLine("Olá, " + C1.Correntista1 + "\n");

            do
            {
                Console.Clear();
                Console.WriteLine("Escolha a operação:\n1 - Depositar\n2 - Sacar\n3 - Saldo\n0 - Sair");
                op = Convert.ToInt16(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("Digite o valor do depósito R$: ");
                            valor = Convert.ToDouble(Console.ReadLine());
                            C1.Depositar(valor);

                            Console.WriteLine("Deposito realizado com sucesso!\n ");
                            Console.WriteLine("Seu Saldo é: " + C1.getSaldo(C1.Saldo1) + "\n");

                            Console.WriteLine("Digite qualquer tecla para voltar ao menu anterior! ");
                            Console.ReadKey();

                        }
                        break;
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Digite o Valor do Saque R$: ");
                            valor = Convert.ToDouble(Console.ReadLine());

                            if (C1.Saque(valor))
                            {
                                Console.WriteLine("Saque efetuado com sucesso!\n ");
                            }
                            else
                            {
                                Console.WriteLine("Operação não efetuada, Saldo insulficiente!\n ");
                            }
                            Console.WriteLine("Digite qualquer tecla para voltar ao menu anterior! ");
                            Console.ReadKey();
                        }
                        break;
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("Correntista .............. " + C1.Correntista1 + "\n");
                            Console.WriteLine("Conta       .............. " + C1.Conta1 + "\n");
                            Console.WriteLine("Saldo       .............. " + C1.Saldo1 + "\n");

                            Console.WriteLine("Digite qualquer tecla para voltar ao menu anterior! ");
                            Console.ReadKey();

                        }
                        break;
                    case 0:
                        {
                            Console.Clear();

                            Console.WriteLine("Obrigado por usar o Banco!\n ");

                            Console.WriteLine("Digite qualquer tecla para sair");
                            Console.ReadKey();
                        }
                        break;

                    default:
                        Console.WriteLine("Escolha uma opção válida de 0 a 3!");
                        Console.WriteLine("Digite qualquer tecla para sair");
                        Console.ReadKey();
                        break;
                }
            } while (op != 0);
            
        }
    }
}

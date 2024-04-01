using System;
using Teste;

namespace Teste
{
   class Teste
    {
        static void Main(string[] args)
        {
            char loop;

            Conta c1 = new Conta();
            c1.NomeTitular = "Lucas";
            c1.Saldo = 100;

            Console.WriteLine("Dono da conta: " + c1.NomeTitular + "\n");
            
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Deseja\n" + "1.Sacar\n" + "2.Depositar\n" + "3.Checar saldo\n");

                int x = int.Parse(Console.ReadLine());

                switch (x)
                {
                    case 1:
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Quanto deseja sacar?");
                        Console.Write("R$");
                        float valor = float.Parse(Console.ReadLine());
                        c1.Sacar(valor);
                        break;

                    case 2:
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Quanto deseja depositar?");                       
                        Console.Write("R$");                       
                        c1.qtd = float.Parse(Console.ReadLine());
                        c1.Depositar();
                        break;

                    case 3:
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Seu saldo: R$" + c1.Saldo);
                        break;
                }

                Console.WriteLine("");


            } while (true);
        }
    }

    public class Conta
    {
        public string NomeTitular;
        public  float Saldo, qtd;
        
       

        public float Sacar(float valor)
        {
            if (Saldo < valor)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("");
                Console.WriteLine("Saldo insuficiente");
            }
            else
            {
                Saldo -= valor;
            }
            return (Saldo);
        }

        public void Depositar()
        {
            Saldo += qtd;
        }
    }

}


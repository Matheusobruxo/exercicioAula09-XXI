using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula09_correcao_XXI
{
    internal class Program
    {
        public static int total = 0;
        static void Main(string[] args)
        {


            while (total < 21)
            {
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("------------- Bem vindo ao jogo do 21 -------------");
                Console.WriteLine("----Seu objetivo é chegar próximo de 21 pontos! ---");
                Console.WriteLine("---------------------------------------------------\n");

                Console.WriteLine($"Você tem {total} pontos");
                Console.WriteLine("Deseja puxar uma nova carta? \n(1- Sim/ 2- Parar)");
                int opcao = int.Parse(Console.ReadLine());

                if (opcao != 1 && opcao != 2)
                {
                    Console.WriteLine("Digite uma opção válida");
                    Console.ReadKey();
                    Console.Clear();
                }

                int sorteador = new Random().Next(1, 11);

                if (opcao == 1)
                {
                    total = total + sorteador;
                    Console.WriteLine($"A carta sorteada foi {sorteador}");
                }
                if (opcao == 2)
                {
                    Console.WriteLine($"Você parou com {total} pontos !");
                    Console.ReadKey();
                    break;
                }
                Console.ReadKey();
                Console.Clear();

            }
            if (total > 21)
            {
                Console.WriteLine($"Você já passsou dos 21 pontos, perdeu com o total de = {total} pontos !");
                Console.ReadLine();

            }

            if (total == 21)
            {
                Console.WriteLine($"Parabens você venceu, lançando logo {total} pontos !!");
                Console.ReadKey();

            }


















        }
    }
}
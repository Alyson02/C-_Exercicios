using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA09GeraNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            char opcao;

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.Title = "Gera-Números";
            do
            {
                opcao = menu();
                gerencia(opcao);

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 'f');

        }
        static char menu()
        {
            char a;
            Console.Clear();
            Console.WriteLine("      *=======Gera-Números=======*\n");
            Console.WriteLine("Gerador de números pares, ímpares e multiplos\n");
            Console.WriteLine("Menu do Gerador de Números:");
            Console.WriteLine(" i - Gera números ímpares\n p - Gera números pares\n m - Gera números multiplos\n a - Gera números aleatórios\n f - Finaliza o programa");
            Console.Write("\nSelecione uma destas opições: ");
            while (!char.TryParse(Console.ReadLine().ToLower(), out a) || (a != 'i' && a != 'm' && a != 'p' && a != 'f' && a != 'a'))
                Console.Write("Erro! Digite apenas oque foi especificado no menu: ");
            return a;
        }
        static void gerencia(char qqcoisa)
        {
            long num;
            switch (qqcoisa)
            {
                
                case 'i':
                    Console.WriteLine("Você escolheu números ímpares!\nAqui vai alguns números dessa categoria:\n");
                    GeraImpares();
                    break;
                case 'p':
                    Console.WriteLine("Você escolheu números pares!\nAqui vai alguns números dessa categoria:\n");
                    GeraPares();
                    break;
                case 'm':
                    Console.Write("Digite um número inteiro positivo maior que 0: ");
                    while (!long.TryParse(Console.ReadLine(), out num) || (num <= 0))
                        Console.Write("Ops! número incorreto, digite um número POSITIVO INTEIRO MAIOR que 0: ");
                    Console.WriteLine("\n");
                    GeraMultiplos(num);
                    break;
                case 'f':
                    Console.WriteLine("Obrigado por usar o Gera-Números!");
                    break;
                case 'a':
                    Console.WriteLine("Você escolheu números aleatórios! Aqui vai alguns números dessa categoria:\n");
                    GeraAleatorios();
                    break;
            }
        }
        static void GeraImpares()
        {
            int i = 1;
            do
            {
                Console.Write("\t{0}\t", i * 2 - 1);
                if (i % 5 == 0) Console.WriteLine();
                i++;

            } while (i <= 100);

        }
        static void GeraPares()
        {
            int p = 1;
            while (p <= 100)
            {
                Console.Write("\t{0}\t", p * 2);
                if (p % 5/*pode ser qualquer numero e serve para organização*/ == 0) Console.WriteLine();
                p++;
            }
        }

        static void GeraMultiplos(long mult)
        {
            int i;
            for (i = 1; i <= 100; i++)
            {
                Console.Write("\t{0} \t", i * mult);
                if (i % 5 == 0) Console.WriteLine();
            }
        }

        static void GeraAleatorios()
        {
            int num;
            Random aleat = new Random();// Instancei o objeto aleat baseado na classe Random
            for(int i = 1; i <= 100; i++)
            {
                num = aleat.Next(1, 101);
                Console.Write("\t {0} \t", num);
                if (i % 5 == 0) Console.WriteLine();
            }

        }
    }
}

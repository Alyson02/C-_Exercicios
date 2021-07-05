using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA08_Swich
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

        }//Fim do bloco Main
        static char menu()//metodo do tipo funçao que retorna valor 
        {
            char a;
            Console.Clear();
            Console.WriteLine("      *=======Gera-Números=======*\n");
            Console.WriteLine("Gerador de números pares, ímpares e multiplos\n");
            Console.WriteLine("Menu do Gerador de Números:");
            Console.WriteLine(" i - Gera números ímpares\n p - Gera números pares\n m - Gera números multiplos\n f - Finaliza o programa");
            Console.Write("\nSelecione uma destas opições: ");
            while (!char.TryParse(Console.ReadLine().ToLower(), out a) || (a != 'i' && a != 'm' && a != 'p' && a != 'f'))
                Console.Write("Erro! Digite apenas oque foi especificado no menu: ");
            return a;
        }
        static void gerencia(char qqcoisa)// metodo do tipo procedimento com recibento de parametros
        {
            switch (qqcoisa)
            {

                case 'i':
                    Console.WriteLine("Você escolheu números ímpares!\nAqui vai alguns números dessa categoria:\n");
                    GeraImpares();//chamada de metodo do tipo procedimento 
                    break;
                case 'p':
                    Console.WriteLine("Você escolheu números pares!\nAqui vai alguns números dessa categoria:\n");
                    GeraPares();
                    break;
                case 'm':
                    Console.WriteLine("Você escolheu números multiplos!\nAqui vai alguns números dessa categoria:\n");
                    break;
                case 'f':
                    Console.WriteLine("Obrigado por usar o Gera-Números!");
                    break;
                    /*default:
                        Console.WriteLine("Opição {0} inválida!", qqcoisa);
                        break;8*/
            }
        }
        static void GeraImpares()
        {
            int i = 1;
            do
            {
                Console.Write("{0} ", i * 2 - 1);
                if (i % 10 == 0) Console.WriteLine();
                i++;

            } while (i <= 100);

        }
        static void GeraPares()
        {
            int p = 1;
            while (p <= 100)
            {
                Console.Write("{0} ", p * 2);
                if (p % 10 == 0) Console.WriteLine();
                p++;
            }
        }
    }
}

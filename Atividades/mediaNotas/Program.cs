using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediaNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, media;
            string nome, rm;

            Console.BackgroundColor = ConsoleColor.Cyan;
                Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Title = "Calculo de Médias";

            Console.WriteLine("Este programa tem como objetivo o cálculo da média de notas dos alunos\n");
            Console.Write("Qual o nome do aluno a avaliar: ");
            nome = Console.ReadLine();
            Console.Write("Número do RM: ");
            rm = Console.ReadLine();
            Console.WriteLine("\n\nBlz! Agora vamos ver qual é média do aluno em questão.");
            Console.Write("\n\n");

            Console.Write("Por favor, digite a primeira nota do aluno: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.Write("Agora a segunda: ");
            nota2 = double.Parse(Console.ReadLine());
            media = (nota1 + nota2) / 2;
            Console.WriteLine("A média do " + nome + " é: " + media);
            Console.WriteLine("\n");
            
            Console.WriteLine(media >= 7 ? "O aluno " + nome + " passou." : media < 5? "O aluno " + nome + " ficou retido." : "O aluno " + nome + " Tem uma segunda chance com exame.");

            Console.WriteLine("A vida é {0}", "boa");

            Console.WriteLine("\n\nBom, agora que já tem a média do aluno, pressione qualquer tecla para encerrar o programa.");
            Console.ReadKey();



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediaNotaLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4, media;
            string nome;
            const string autor = "Alyson" ;

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Calculo de Médias";

            Console.WriteLine("Este programa tem como objetivo o cálculo da média de notas dos alunos\n");
            Console.Write("Qual o nome do aluno a avaliar: ");
            nome = Console.ReadLine();
            do
            {
                Console.Write("Por favor, digite a primeira nota do aluno: ");
                nota1 = double.Parse(Console.ReadLine());
                Console.Write("Agora a segunda: ");
                nota2 = double.Parse(Console.ReadLine());
                Console.Write("Agora a terceira: ");
                nota3 = double.Parse(Console.ReadLine());
                Console.Write("Agora a quarta: ");
                nota4 = double.Parse(Console.ReadLine());
                media = (nota1 + nota2 + nota3 + nota4) / 4;
                Console.WriteLine("A média do aluno {0:N2} é {1}", nome, media);

                if (media >= 7)
                    Console.WriteLine("O aluno " + nome + " passou.");
                else if (media < 5)
                    Console.WriteLine("O aluno " + nome + " ficou retido.");
                else
                    Console.WriteLine("O aluno " + nome + " Tem uma segunda chance com exame.");
                
                Console.Write("\nPressione // para encerrar ou continue com o nome de um novo aluno:");
                nome = Console.ReadLine();
            } while (nome != "//");
                 
            Console.WriteLine("\n\nBom, agora que já tem a média do(s) aluno(s), pressione qualquer tecla para encerrar o programa (Autor: {0}).", autor );
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA07_Media4Notas_Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            double media;
            double[] nota = new double[4];//vetor ou matrix de 1 dimensao
            string nome;
            int cont;
            const string autor = "Alyson";
            
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "Calculo de Médias";
            Console.WriteLine("SP, " + DateTime.Now);
            Console.WriteLine("Este programa tem como objetivo o cálculo da média de notas dos alunos\n");
            Console.Write("Qual o nome do aluno a avaliar: ");
            nome = Console.ReadLine();
            do
            {
                for (cont = 0; cont < 4; cont++)
                {
                    Console.Write("\nPor favor, digite a {0}ª nota do {1}: ", cont + 1, nome);

                    while ((!double.TryParse(Console.ReadLine(), out nota[cont]) || nota[cont] < 0 || nota[cont] > 10)) 
                        
                        Console.Write("A nota deve estar entre 0 e 10: ");
                    
                }

                media = (nota[0] + nota[1] + nota[2] + nota[3]) / 4;
                    Console.WriteLine("\nA média do aluno(a) {0:N2} é {1}", nome, media);

                if (media >= 7)
                    Console.WriteLine("O aluno(a) " + nome + " passou.");
                else if (media < 5)
                    Console.WriteLine("O aluno(a) " + nome + " ficou retido.");
                else
                    Console.WriteLine("O aluno(a) " + nome + " Tem uma segunda chance com exame.");

                Console.Write("\nPressione // para encerrar ou continue com o nome de um novo aluno: ");
                nome = Console.ReadLine();
            } while (nome != "//");

            Console.WriteLine("\n\nBom, agora que já tem a média do(s) aluno(s), pressione qualquer tecla para encerrar o programa (Autor: {0}).", autor);
            Console.ReadKey();

        }
    }
}

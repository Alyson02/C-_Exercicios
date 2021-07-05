using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA10_MatrizAleatorio
{
    class Program
    {
        static int limite = 200;
        static int time = 5000;
        const string autor = "Alyson";
        static void Main(string[] args)//inicio metodo main
        {
            Random aleat = new Random(); //Gera numeros aleatorios
            int[,] matriz = new int[4, 4];//declaração de uma matriz com 2 dimenssoes
            int[,] limpa = new int[4, 4];
            int num, nivel, tentativa = 1;
            int sorteioLin, sorteioCol;




            Console.BackgroundColor = ConsoleColor.Blue;//comando usado para alterar a cor de fundo do console
            Console.ForegroundColor = ConsoleColor.Cyan;//comando usado para alterar a cor das letras do console
            Console.Clear();//Comando de limpara a tela para n bugar as cores
            Console.Title = "Joginho com matriz";//Comando para alterar o titulo do programa

            Console.WriteLine("Sp, " + DateTime.Now);
            Console.WriteLine("Autor: {0}\n\n", autor);
            Console.WriteLine("\t====Teste sua memória====\n");
            Console.WriteLine("\nSelecione uma dificuldade: \n\n1- Easy\n2- Normal\n3- Hard\n4- Dark Souls mode");
            Console.Write("...");
            while (!int.TryParse(Console.ReadLine(), out nivel) || (nivel < 1 || nivel > 4))
                Console.WriteLine("Erro! escolha um nivel entre 1 a 4");

            do//inicio do loop
            {
                if (nivel == 1)
                {
                    limite = 10;
                    time = 5000;
                }
                else if (nivel == 2)
                {
                    limite = 30;
                    time = 4500;
                }
                else if (nivel == 3)
                {
                    limite = 50;
                    time = 4300;
                }

                matriz = cadastraNum(4, 4);// usando o metodo cadastranum para gerar numeros aleatórios para minha matriz

                Console.Clear();
                Console.WriteLine("\nJoginho com matriz3x3\n");

                Console.WriteLine("{0}º tentativa.", tentativa++);
                Console.WriteLine("\n\t     ====Memorize!====\n");
                exibirDados(matriz);//usando o metodo exibir dados com valores da minha matriz

                Thread.Sleep(time);//comando para pausar o tempo de tela
                Console.Clear();//necessario  para o funcionamento do jogo, ele limpa a tela

                sorteioLin = aleat.Next(1, 4);//sorteando qual linha tera o numero 
                sorteioCol = aleat.Next(1, 4);//sorteando qual coluna tera o numero 

                limpa[sorteioLin, sorteioCol] = 900;
                exibirDados(limpa);
                limpa[sorteioLin, sorteioCol] = 0;

                Console.Write("\nQual número consta na posição: linha {0}, coluna {1} da matriz: ", sorteioLin, sorteioCol);//apresetando para o usuario os numeros sorteados
                while (!int.TryParse(Console.ReadLine(), out num) || (num < 0))//consistencia de dados 
                    Console.Write("Meu filho! Digite apenas números inteiros positivos: ");

                if (verifica(matriz[sorteioLin, sorteioCol], num))//usando o método verifica para exatamente verificar se o que o usuario digitou corresponde com o numero sorteado
                    Console.WriteLine("\nParabéns! Você acertou!\n");
                else
                    Console.WriteLine("\nPoxa… Não foi dessa vez! O número correto era: {0}\n", matriz[sorteioLin, sorteioCol]);

                exibirDados(matriz);
                Console.Write("\nCaso queira continuar pressione s, se não...");
                //encerra = Console.ReadLine();
                
            } while (Console.ReadKey().KeyChar == 's'/*encerra != "//"*/);//fim do loop
        }// fim do metodo main

        static int[,] cadastraNum(int nLin, int nCol)
        {
            int[,] n = new int[nLin, nCol];
            Random aleat = new Random();
            //Atribuição de números da matriz
            for (int l = 1; l < nLin; l++)
                for (int c = 1; c < nCol; c++)
                    n[l, c] = aleat.Next(0, limite);

            return n;
        }

        static bool verifica(int numMatriz, int numUsuario)
        {
            return numMatriz == numUsuario ? true : false;// Se quiser use estrutura condicional if/else
        }

        static void exibirDados(int[,] n)
        {
            int num = 1;
            //Exibição dos dados da matriz
            Console.Write("\t\tC1\tC2\tC3\n\n");
            for (int i = 1; i < n.GetLength(0); i++)
            {
                Console.Write("\tL{0}", num++); 
                for (int j = 1; j < n.GetLength(1); j++)
                {
                    if (n[i, j] == 0)
                        Console.Write("\t ");
                    else if(n[i, j] == 900)
                        Console.Write("\t? ");
                    else
                    Console.Write("\t{0:D2} ", n[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}

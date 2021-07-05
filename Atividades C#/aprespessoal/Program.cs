using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprespessoal
{
    class Program
    {
        static void Main(string[] args)
        {    
            //Projeto de apresentação pessoal proposto pelo professor Jose da máteria PA
            //Olá professor, espero que goste!
            
            string legendas, geral, data = "  Faço aniversário em 01/04/2002.";//Declaração de Variáveis
            Console.WriteLine("São Paulo,  \n" + DateTime.Now);
            Console.WriteLine("");
            Console.WriteLine("Este programa se destinará a minha apresentação pessoal. \n");
            geral = "Let's GO!";
            Console.WriteLine("Sem mais delongas, " + geral);
            Console.WriteLine("\n\n");
            Console.WriteLine("Informaçoes Básicas e Meios de Contato:");
            Console.WriteLine("");
            Console.Write("Nome: ");
            legendas = "  Alyson Subrim dos Anjos";
            Console.WriteLine("\n\n" + legendas);
            Console.WriteLine("");
            legendas = "  18 anos.";//Declarando valor a váriavel
            Console.WriteLine("Idade:" + "\n\n" +  legendas + "\n");
            Console.Write("Aniversário:");
            Console.WriteLine( " " + "\n\n" + data + " " + "Isso mesmo, eu faço aniversário no dia da mentira.\n  Talvez eu seja uma farça. Assim como esse dia, haha. \n");
            legendas = "  São Paulo - SP, Vila Sulina Anhanguera.";
            Console.WriteLine("Moro em: " + "\n\n" + legendas);
            Console.WriteLine("");
            legendas = "  Ensino Médio Completo";
            Console.WriteLine("Graduações:" + "\n\n" + legendas + " atualmente cursando curso técnico\n  na ETEC Professor Basilides de Godoy.");
            Console.WriteLine("");
            Console.Write("Contatos: \n\n");
            Console.WriteLine("  E-mail: alissonsubrim@gmail.com");
            Console.WriteLine("  Celular: (11) 93363-8836\n");
            Console.WriteLine("Relacionamento:");
            legendas = "  Solteiro. (*^_^*)";
            Console.WriteLine("\n" + legendas + "\n");
            Console.Write("Nacionalidade:");
            legendas = "\n\n  Brasileiro.";
            Console.WriteLine(legendas);
            Console.WriteLine("");
            geral = "Cursos extracurriculares:";
            legendas = "\n\n  *Montagem e Manutenção de Computadores;\n  *Redes de Computadores;\n  *Eletricista Instalador;\n  *Informática Básica;\n  *Gestão Empresarial.";
            Console.WriteLine(geral + legendas);
            Console.WriteLine("\n");
            Console.WriteLine("Carreira Pretendida: ");
            legendas = "\n  Funções correlativas a área de TI, mas um dos meus sonhos é desenvolver um jogo. ";
            Console.WriteLine(legendas);
            Console.WriteLine("");
            Console.WriteLine("Sonho Principal: ");
            legendas = "\n  Que as pessoas tenham mais LIBERDADE para seguirem seus sonhos, inclusive eu. ";
            Console.WriteLine(legendas);


            //Espaço para ficar mais agradável


            Console.WriteLine("\n\n"); //Uso de muitos new lines para ficar agradavel de se ler
            Console.WriteLine("Curiosidades:");
            Console.WriteLine("\n");
            Console.Write("Passa tempo: ");
            legendas = "  Jogar jogos eletrônicos, principalmente online e assistir animes e séreies";
            Console.WriteLine("\n\n" + legendas);
            Console.WriteLine("");
            legendas = "  1-Dark Souls (Série)\n  2-The Witcher 3\n  3-GTAV";
            Console.WriteLine("Top 3 Jogos Prefereidos: " + "\n\n" + legendas);
            geral = "Top 3 Animes e Séries Preferidos:";
            legendas = "\n\n  1-Naruto                1-The Mandalorian\n  2-Hunter x Hunter       2-Vikings\n  3-Shinkeg no Kyojin     3-The Boys";
            Console.WriteLine("");
            Console.WriteLine(geral + legendas);
            Console.WriteLine("");
            Console.WriteLine("Top 3 Livros Preferidos:");
            legendas = "  1-As 6 liçoes\n  2-Guia Politicamente incorreto da História do Brasil\n  3-Revolução do Bichos";
            Console.WriteLine("\n" + legendas);
            Console.WriteLine("");
            geral = "Top 3 Músicas preferidas:";
            legendas = "\n\n  1-By the Way - Red Hot Chili Pappers\n  2-Warriors\n  3-Inferno";
            Console.WriteLine(geral + legendas);
            Console.WriteLine("");
            geral = "Top 3 Filmes Preferidos:\n\n  1-Star Wars: A Vingança dos Sith\n  2-O Hobbit: A Batalha dos Cinco Exércitos\n  3-Vingadores: Guerra Infinita";
            Console.WriteLine(geral);
            Console.WriteLine("\n\n\n");


            Console.WriteLine("Bom, infelizmente chegamos ao fim da minha apresentação\nPara encerra-la, pressione qualquer tecla. Foi um prazer!:v");
            Console.ReadKey();
        }
    }
}

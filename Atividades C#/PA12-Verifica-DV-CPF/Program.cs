using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA12_Verifica_DV_CPF
{
    class Program
    {
        static void Main(string[] args)
        {
            const string autor = "Alyson";
            string cpf;
            char[] caracteres;
            int[] numeros = new int[11];
            int dv;

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("Programa desenvolvido por: {0}", autor);
            Console.WriteLine("SP, {0}", DateTime.Now);
            Console.WriteLine("Validador de Digitos Verificadores de CPF");
            
            do
            {
                Console.Write("\n\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-==-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.Write("\n\nDigite apenas os números do CPF: ");
                cpf = Console.ReadLine();

                if (cpf.Length == 11)
                {
                    caracteres = cpf.ToCharArray();
                    for (int i = 0; i < 11; i++)
                    {
                        if (!int.TryParse(caracteres[i].ToString(), out numeros[i]))
                        {
                            Console.WriteLine("\nO que foi digitado não é CPF, pois não tem 11 dígitos numéricos!\n");
                            break;
                        }
                    }

                    dv = calculaDV(numeros);
                    Console.WriteLine("\nO valor do DV do CPF {0} é {1:D2}\n", cpf, dv);

                    if (numeros[9] * 10 + numeros[10] == dv)
                        Console.WriteLine("CPF {0} possivelmente coerente!\n", cpf);
                    else
                        Console.WriteLine("CPF {0} não é coerente. DV digitado {1} não " +
                            "corresponde ao calculado ({2:D2})\n", cpf, cpf.Substring(9, 2), dv);
                }

                else Console.WriteLine("\nO que foi digitado não é CPF, pois não tem 11 digitos\n");

                Console.Write("Se deseja cadastrar um novo CPF pressione s, caso contrario, pressione qualquer tecla... ");
            } while (Console.ReadKey().KeyChar == 's');
        }

        static int calculaDV(int[] cpf)
        {
            int dv = 0, dv1, dv2, acum;

            acum = cpf[0] * 10 + cpf[1] * 9 + cpf[2] * 8 + cpf[3] * 7 + cpf[4] * 6 + cpf[5] * 5 + cpf[6] * 4 + cpf[7] * 3 + cpf[8] * 2;
            dv1 = 11 - (acum % 11);
            if (dv1 >= 10)
                dv1 = 0;

            acum = cpf[0] * 11 + cpf[1] * 10 + cpf[2] * 9 + cpf[3] * 8 + cpf[4] * 7 + cpf[5] * 6 + cpf[6] * 5 + cpf[7] * 4 + cpf[8] * 3 + dv1 * 2;
            dv2 = 11 - (acum % 11);
            if (dv2 >= 10)
                dv2 = 0;

            dv = dv1 * 10 + dv2;

            return dv;
        }
    }
}

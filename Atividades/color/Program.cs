using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace color
{
    class Program
    {
        static void Main(string[] args)
        {
            // loop console colors
            foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
            {
                Console.ForegroundColor = color;
                Console.WriteLine( "Foreground color set to {color}");
            }
            Console.WriteLine("=====================================");
            Console.ForegroundColor = ConsoleColor.White;
            // loop background colors
            foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
            {
                Console.BackgroundColor = color;
                Console.WriteLine( "Background color set to {color}");
            }
            Console.WriteLine("=====================================");
            // resetar cores
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}

using System;
using System.Runtime.InteropServices;

namespace MerryMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            //do
            //{
            //    MethodBench.PrintMm();
            //    i++;
            //} 
            //while (i < 3);

            //MethodBench.PrintString("C# now and forever");
            Console.Write("Sriv något  ");
            string input = Console.ReadLine();
            MethodBench.PrintString(input);

            //Console.Write("Byt till stora eller små bokstäver b/s  ");
            //ConsoleKeyInfo consoleKey = Console.ReadKey();
            //Console.WriteLine();
            //switch (consoleKey.Key)
            //{
            //    case ConsoleKey.B:
            //        MethodBench.PrintUpperOrLower(input, true);
            //        break;
            //    case ConsoleKey.S:
            //        MethodBench.PrintUpperOrLower(input, false);
            //        break;
            //    default:
            //        break;
            //}

            Console.Write("Vill du skrika eller viska? s/v  ");
            ConsoleKeyInfo choice = Console.ReadKey();
            Console.WriteLine();
            while (choice.Key != ConsoleKey.S && choice.Key != ConsoleKey.V)
            {
                Console.Write("\nSkriv s eller v  ");
                choice = Console.ReadKey();
            }
            bool shout = MethodBench.Shout(choice);

            Console.WriteLine();

            MethodBench.PrintUpperOrLower(input, shout);
            MethodBench.PrintUpperOrLower(input, MethodBench.Shout(choice));

           
        }
    }
}

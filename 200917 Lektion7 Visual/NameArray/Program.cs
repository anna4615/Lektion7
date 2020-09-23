using System;

namespace NameArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många namn vill du registrera?  ");
            string[] names = new string[int.Parse(Console.ReadLine())];
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"Ange namn {i + 1}  ");
                names[i] = Console.ReadLine();
            }

            Console.WriteLine();

            //for (int i = names.Length -1; i >= 0; i--)
            //{
            //    Console.WriteLine($"Namn {i +1}: {names[i]}");
            //}
            //Console.WriteLine();

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Namn {i + 1}: {names[i]}");
            }

            Console.WriteLine();

            Console.Write("Vilken person vill du byta ut?  ");
            string oldName = Console.ReadLine();

            while (!CheckName(names, oldName))
            {
                Console.Write($"Hittar inte {oldName}, skriv ett namn som finns i listan  ");
                oldName = Console.ReadLine();
                CheckName(names, oldName);
            }

            Console.Write("Vem vill du skriva in istället?  ");
            string newname = Console.ReadLine();
            Console.WriteLine();

            ReplacePerson(names, newname, FindPosition(names, oldName));

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Namn {i +1}: {names[i]}");
            }
            Console.WriteLine();

            Console.WriteLine("Vems position vill du hitta?  ");
            string input = Console.ReadLine();

            while (!CheckName(names, input))
            {
                Console.Write($"Hittar inte {input}, skriv ett namn som finns i listan  ");
                input = Console.ReadLine();
                CheckName(names, input);
            }

            int position = FindPosition(names, input);
            Console.WriteLine($"{input} finns på position {position +1}.");



        }

        private static bool CheckName(string[] names, string name)
        {
            bool nameExists = false;
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                {
                    nameExists = true;
                    break;
                }
            }
            return nameExists;
        }

        private static void ReplacePerson(string[] names, string newname, int replacePosition)
        {
            names[replacePosition] = newname;
        }

        private static int FindPosition(string[] names, string oldName)
        {
            int position = 0;
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == oldName)
                {
                    position = i;
                    break;
                }
            }
            return position;
        }
    }
}

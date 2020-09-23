using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            //while (true)
            //{
            //    Console.Write("Välj år  ");
            //    int year = int.Parse(Console.ReadLine());
            //    if (year == 0)
            //    {
            //        break;
            //    }
            //    else if (IsLeapYear(year))
            //    {
            //        Console.WriteLine($"År {year} är ett skottår med 366 dagar.");
            //    }
            //    else
            //        {
            //        Console.WriteLine($"År {year} är inte ett skottår, det har 365 dagar.");
            //    }
            //}
            Console.Write("Ange några år åtskilda av mellanslag  ");
            string input = Console.ReadLine();
            string[] years = input.Split(' ');

            for (int i = 0; i < years.Length; i++)
            {
                int year = int.Parse(years[i]);
                if (IsLeapYear(year))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"{year} ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($"{year} ");
                }
            }
            Console.ResetColor();

            if (File.Exists(input))
            {
                Console.WriteLine("Filen finns");
            }
            else
            {
                Console.WriteLine("Filen finns inte");
            }
            
        }

        
        public static bool IsLeapYear(int year)
        {
            if (ModulusFour(year))
            {
                if (ModulusOneHundred(year))
                {
                    if (ModulusFourHundred(year))
                    {
                        return true;
                    }
                    else
                        return false;
                }
                else
                    return true;
            }
            else
                return false;
        }


        public static bool ModulusFour(int year)
        {
            if (year % 4 == 0)
                return true;
            else
                return false;
        }
        public static bool ModulusOneHundred(int year)
        {
            if (year % 100 == 0)
                return true;
            else
                return false;
        }
        private static bool ModulusFourHundred(int year)
        {
            if (year % 400 == 0)
                return true;
            else
                return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MerryMethods
{
    class MethodBench
    {
        public static void PrintMm()
        {
            Console.WriteLine("Merry Methods");
        }
        public static void PrintString(string s)
        {
            Console.WriteLine(s);
        }
        public static void PrintUpperOrLower(string s, bool b)
        {
            if (b)
            {
                s = s.ToUpper();
            }
            else
            {
                s = s.ToLower();
            }
            PrintString(s);
        }
        public static bool Shout(ConsoleKeyInfo k) // MerryMethods p.9 säger, deklarera inga parametrar, hur skulle det funka?
        {
            if (k.Key == ConsoleKey.S)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        
    }
}

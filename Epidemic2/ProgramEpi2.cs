using System;
using System.Collections.Generic;

namespace Epidemic2
{
    class ProgramEpi2
    {
        static void Main(string[] args)
        {
            Console.Write("Ange antal personer på diskot  ");
            int numberOfGuests = int.Parse(Console.ReadLine());
            Console.WriteLine();

            List<Person2> disco = new List<Person2>();
            CreateGuestList(disco, numberOfGuests);

            int numberOfInfected = 1;
            int numberOfImmune = 0;
            int hoursPassed = 0;

            //Console.WriteLine("Startläge\nGäst nr\tSmittad\tTid\tImmun");
            //for (int j = 0; j < disco.Count; j++)
            //{
            //    Console.WriteLine($"{j}\t{disco[j].Infected}\t" +
            //        $"{disco[j].TimeInfected}\t{disco[j].Immune}");
            //}
            Console.WriteLine();
            Console.WriteLine($"Antal smittade:\t{numberOfInfected}\n" +
            $"Antal immuna:\t{numberOfImmune}\n" +
            $"Passerad tid (h):\t{hoursPassed}");
            Console.WriteLine();

            while (numberOfImmune < disco.Count)
            {
                for (int i = 0; i < disco.Count; i++)
                {
                    if (disco[i].Infected)
                    {
                        disco[i].TimeInfected++;
                        if (numberOfInfected + numberOfImmune < disco.Count)
                        {
                            numberOfInfected++;
                        }
                        if (disco[i].TimeInfected == 5 && numberOfImmune < disco.Count)
                        {
                            disco[i].Immune = true;
                            disco[i].Infected = false;
                            numberOfImmune ++;                            
                            numberOfInfected --;
                        }
                    }
                    if (disco[i].Infected == false && disco[i].Immune == false)
                    {
                        if (i < numberOfInfected + numberOfImmune && i < disco.Count)
                        {
                            disco[i].Infected = true;
                        }
                    }
                }

                hoursPassed ++;

                //Console.WriteLine("Tryck på valfri tangent för att visa nästa läget för nästa timme  ");
                //Console.ReadLine();
                //Console.Clear();

                //Console.WriteLine("Gäst nr\tSmittad\tTid\tImmun");
                //for (int j = 0; j < disco.Count; j++)
                //{
                //    Console.WriteLine($"{j}\t{disco[j].Infected}\t" +
                //        $"{disco[j].TimeInfected}\t{disco[j].Immune}");
                //}

                Console.WriteLine();
                Console.WriteLine($"Antal smittade:\t{numberOfInfected}\n" +
                $"Antal immuna:\t{numberOfImmune}\n" +
                $"Passerad tid (h):\t{hoursPassed}");
                Console.WriteLine();
            }

        }

        private static List<Person2> CreateGuestList(List<Person2> disco, int numberOfGuests)
        {
            for (int i = 0; i < numberOfGuests; i++)
            {
                //Person guest = new Person();
                //guest.Infected = false;
                //guest.TimeOfInfection = 0;
                //guest.Immune = false;
                //disco.Add(guest);                
                if (i == 0)
                {
                    disco.Add(new Person2(true, 0, false)); //Kräver konstruktor i klassen Person2
                }
                else
                {
                    disco.Add(new Person2(false, 0, false)); //Kräver konstruktor i klassen Person2
                }
            }
            return disco;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Epidemic2
{
    class Person2
    {
        public bool Infected { get; set; }
        public int TimeInfected { get; set; }
        public bool Immune { get; set; }

        public Person2(bool infected, int timeInfected, bool immune) // konstruktor
        {
            Infected = infected;
            TimeInfected = timeInfected;
            Immune = immune;
        }
    }
}

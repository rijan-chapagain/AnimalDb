using System;

namespace AnimalDb
{
    class Program
    {
        static void Main(string[] args)
        {
            Kangaroo a = new Kangaroo("meat", "Perth", 4);
            Kangaroo child = new Kangaroo("meat", "Nepal", 4);
            Emu e = new Emu("vagetirian", "South Australia", 2);

            Console.WriteLine(a.animalDetails());
            Console.WriteLine(child.animalDetails());
            Console.WriteLine(e.animalDetails());
        }
    }
}

namespace AnimalDb
{
    using System;

    internal class Emu : Animal
    {
        public Emu(string name, string food, string location, int legs, string moves) : base(name, food, location, legs, moves)
        {
            _move = "Flying";
            _name = "Emu";
        }

        public override void PrintMovingType()
        {
            Console.WriteLine("Moving medium for emu is: " + _move);
        }
    }
}

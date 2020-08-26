namespace AnimalDb
{
    using System;

    public class Kangaroo : Animal
    {
        public Kangaroo(string name, string food, string location, int legs, string moves) : base(name, food, location, legs, moves)
        {
            _move = "Jumping";
            _name = "Kangaroo";
        }

        public override void PrintMovingType()
        {
            Console.WriteLine("Moving medium of Kangaroo is: " + _move);
        }
    }
}

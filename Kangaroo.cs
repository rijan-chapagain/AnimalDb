using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalDb
{
    public class Kangaroo : Animal
    {
        public Kangaroo( string name, string food, string location, int legs, string moves) : base (name, food, location, legs, moves)
        {
            _move = "Jumping";
            _name = "Kangaroo";
        }

        public int MyProperty { get; set; }

        public override void PrintMovingType()
        {
            Console.WriteLine("Moving medium of Kangaroo is: " + _move);
        }
    }
}

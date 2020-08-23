namespace AnimalDb
{
    using System;

    /// <summary>
    /// Defines the <see cref="Emu" />.
    /// </summary>
    internal class Emu : Animal
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Emu"/> class.
        /// </summary>
        /// <param name="name">The name<see cref="string"/>.</param>
        /// <param name="food">The food<see cref="string"/>.</param>
        /// <param name="location">The location<see cref="string"/>.</param>
        /// <param name="legs">The legs<see cref="int"/>.</param>
        /// <param name="moves">The moves<see cref="string"/>.</param>
        public Emu(string name, string food, string location, int legs, string moves) : base(name, food, location, legs, moves)
        {
            _move = "Flying";
            _name = "Emu";
        }

        /// <summary>
        /// The PrintMovingType.
        /// </summary>
        public override void PrintMovingType()
        {
            Console.WriteLine("Moving medium for emu is: " + _move);
        }
    }
}

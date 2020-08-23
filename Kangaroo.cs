namespace AnimalDb
{
    using System;

    /// <summary>
    /// Defines the <see cref="Kangaroo" />.
    /// </summary>
    public class Kangaroo : Animal
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Kangaroo"/> class.
        /// </summary>
        /// <param name="name">The name<see cref="string"/>.</param>
        /// <param name="food">The food<see cref="string"/>.</param>
        /// <param name="location">The location<see cref="string"/>.</param>
        /// <param name="legs">The legs<see cref="int"/>.</param>
        /// <param name="moves">The moves<see cref="string"/>.</param>
        public Kangaroo(string name, string food, string location, int legs, string moves) : base(name, food, location, legs, moves)
        {
            _move = "Jumping";
            _name = "Kangaroo";
        }

        /// <summary>
        /// Gets or sets the MyProperty.
        /// </summary>
        public int MyProperty { get; set; }

        /// <summary>
        /// The PrintMovingType.
        /// </summary>
        public override void PrintMovingType()
        {
            Console.WriteLine("Moving medium of Kangaroo is: " + _move);
        }
    }
}

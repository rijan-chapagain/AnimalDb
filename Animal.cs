namespace AnimalDb
{
    using System;
    using System.Text;

    /// <summary>
    /// Defines the <see cref="Animal" />.
    /// </summary>
    public abstract class Animal : IAnimal
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Animal"/> class.
        /// </summary>
        /// <param name="name">The name<see cref="string"/>.</param>
        /// <param name="food">The food<see cref="string"/>.</param>
        /// <param name="location">The location<see cref="string"/>.</param>
        /// <param name="legs">The legs<see cref="int"/>.</param>
        /// <param name="moves">The moves<see cref="string"/>.</param>
        public Animal(string name, string food, string location, int legs, string moves)
        {
            _name = name;
            _food = food;
            _location = location;
            _legs = legs;
            _move = moves;
        }

        /// <summary>
        /// Gets or sets the _name.
        /// </summary>
        protected string _name { get; set; }

        /// <summary>
        /// Gets or sets the _food.
        /// </summary>
        protected string _food { get; set; }

        /// <summary>
        /// Gets or sets the _legs.
        /// </summary>
        protected int _legs { get; set; }

        /// <summary>
        /// Gets or sets the _move.
        /// </summary>
        protected string _move { get; set; }

        /// <summary>
        /// Gets or sets the _text.
        /// </summary>
        private string _text { get; set; }

        /// <summary>
        /// Defines the _location.
        /// </summary>
        protected string _location = "Australia";

        /// <summary>
        /// The PrintAnimalDetails.
        /// </summary>
        public virtual void PrintAnimalDetails()
        {
            _text = ("\nAnimals Details:>\n" +
                "\tName: " + _name + "\n" +
                "\tLocation is: " + _location +
                "\n\tCommon Food is: " + _food +
                "\n\tHave " + _legs + " legs\n");
            Console.WriteLine(_text);

            WriteLine();
        }

        /// <summary>
        /// The WriteLine.
        /// </summary>
        private void WriteLine()
        {
            string path = @"..\..\..\text.txt";

            System.IO.File.AppendAllText(path, _text, Encoding.UTF8);

            Console.WriteLine("Successfull write data in file");
        }

        /// <summary>
        /// The PrintMovingType.
        /// </summary>
        public abstract void PrintMovingType();
    }
}

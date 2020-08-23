namespace AnimalDb
{
    using System;
    using System.Globalization;

    public abstract class Animal : IAnimal
    {
        public Animal(string name, string food, string location, int legs, string moves)
        {
            _name = name;
            _food = food;
            _location = location;
            _legs = legs;
            _move = moves;
        }

        protected string _name { get; set; }

        protected string _food { get; set; }

        protected int _legs { get; set; }

        protected string _move { get; set; }

        public String Text { get; set; }

        protected string _location = "Australia";

        public virtual void PrintAnimalDetails()
        {
            Text =("\nAnimals Details:>\n" +
                "\tName: " + _name + "\n" +
                "\tLocation is: " + _location +
                "\n\tCommon Food is: " + _food +
                "\n\tHave " + _legs + " legs\n");
            Console.WriteLine(Text);

            WriteLine();
        }

        public void WriteLine()
        {
            System.IO.File.WriteAllText(@"..\..\..\text", Text);
            Console.WriteLine("Successfull write data in file");
        }




        public abstract void PrintMovingType();

    }
}

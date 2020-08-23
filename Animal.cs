using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace AnimalDb
{
    public abstract class Animal : IAnimal
    {
        public Animal( string name, string food, string location, int legs, string moves)
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


        protected string _location = "Australia";

        public virtual void PrintAnimalDetails()
        {
            Console.WriteLine("Animals Details:>\n" +
                "\tName: " + _name + "\n" +
                "\tLocation is: " + _location +
                "\n\tCommon Food is: " + _food + 
                "\n\tHave " + _legs + " legs\n");
        }

        public abstract void PrintMovingType();


    }
}

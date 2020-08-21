using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace AnimalDb
{
    class Animal
    {
        public Animal(string food, string location, int leg)
        {
            _food = food;
            _location = location;
            _leg = leg;
        }

        public Animal()
        {
        }

        protected string _food { get; set; }
        protected int _leg { get; set; }

        protected string _location = "Australia";

        public string animalDetails()
        {
            return ("Location is: " + _location + "\nCommon Food is: " + _food + "\nHave " + _leg + " legs\n" );
        }

    }
}

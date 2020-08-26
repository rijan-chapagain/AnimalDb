namespace AnimalDb
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            Animal k = new Kangaroo("", "meat", "Perth", 4, "");
            Animal child = new Kangaroo("", "meat", "Nepal", 4, "");
            Animal e = new Emu("", "vageterian", "South Australia", 2, "");

            // Displays moving types from derived classes
            k.PrintMovingType();
            child.PrintMovingType();
            e.PrintMovingType();

            // display Animals details from abstract class
            k.PrintAnimalDetails();
            child.PrintAnimalDetails();
            e.PrintAnimalDetails();
        }
    }
}

namespace AnimalDb
{
    /// <summary>
    /// Defines the <see cref="Program" />.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The Main.
        /// </summary>
        /// <param name="args">The args<see cref="string[]"/>.</param>
        internal static void Main(string[] args)
        {
            Animal k = new Kangaroo("", "meat", "Perth", 4, "");
            Animal child = new Kangaroo("", "meat", "Nepal", 4, "");
            Animal e = new Emu("", "vageterian", "South Australia", 2, "");
            Animal write = new WriteLine()

            // Displays moving types from derived classes
            k.PrintMovingType();
            child.PrintMovingType();
            e.PrintMovingType();

            // display Animals details from abstract class
            k.PrintAnimalDetails();
            child.PrintAnimalDetails();
            e.PrintAnimalDetails();
            write.WriteLineToFile();

        }
    }
}

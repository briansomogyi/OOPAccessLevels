using OOPAccessLevels.Library;
using System.Reflection;

namespace OOPAccessLevels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            // Car private field not accessible in child class
            // from another project
            // Console.WriteLine(car.manufacturer);
            // Car protected field not accessible in child class
            // from another project
            // Console.WriteLine(car.model);
            // Car private protected field not accessible in child class
            // from another project
            // Console.WriteLine(modelVariant);
            // Car internal field not accessible in child class
            // from another project
            // Console.WriteLine(year);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOPAccessLevels.Library
{
    public class CarDealer
    {
        void DealerPrintInventory()
        {
            Car car = new Car();
            // Car private field not accessible in another class
            // from within the same project
            // Console.WriteLine(car.manufacturer);
            // Car protected field not accessible in child class
            // from within the same project
            // Console.WriteLine(car.model);
            // Car private protected field not accessible in child class
            // from within the same project
            // Console.WriteLine(modelVariant);
            // Car internal field not accessible in child class
            // from within the same project
            // Console.WriteLine(year);
        }
    }
}

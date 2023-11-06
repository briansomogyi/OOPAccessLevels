using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPAccessLevels.Library;

namespace OOPAccessLevels
{
    public class SubCar:Car
    {
        private Wheel subWheel = new Wheel();
        void SubPrintManufacturer()
        {
            // Car private field not accessible in child class
            // from another project
            // Console.WriteLine(manufacturer);
            // Car protected field not accessible in child class
            // from another project
            Console.WriteLine(model);
            // Car private protected field not accessible in child class
            // from another project
            // Console.WriteLine(modelVariant);
            // Car internal field not accessible in child class
            // from another project
            // Console.WriteLine(year);
        }
        private class SubWheel:Wheel
        {

        }
    }
}

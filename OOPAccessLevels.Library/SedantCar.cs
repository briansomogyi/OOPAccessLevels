using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAccessLevels.Library
{
    public class SedantCar:Car
    {
        private Wheel sedantWheel = new Wheel();
        void SedantPrintManufacturer()
        {
            // Car private field not accessible in child class
            // from within the same project
            // Console.WriteLine(manufacturer);
            // Car protected field accessible in child class
            // from within the same project
            Console.WriteLine(model);
            // Car private protected field accessible in child class
            // from within the same project
            Console.WriteLine(modelVariant);
            // Car internal field accessible in child class
            // from within the same project
            Console.WriteLine(year);
            Console.WriteLine(sedantWheel.name);
        }
        protected class SedantWheel : Wheel
        {
            public void SpinWheel()
            {
                Console.WriteLine(name);
            }
        }
    }
}

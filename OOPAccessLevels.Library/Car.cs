namespace OOPAccessLevels.Library
{
    public class Car
    {
        private string manufacturer = "Renaut";
        protected string model = "Clio";
        private protected string modelVariant = "BaseModel";
        internal int year = 2023;
        public BodyType bodyType = BodyType.Unknown;
        private Wheel wheel = new Wheel();
        void CarPrintManufacturer()
        {
            // Private field accessible from within this class
            Console.WriteLine(manufacturer);
            // Protected field accessible from within this class
            Console.WriteLine(model);
            // Private protected field accessible from within this class
            Console.WriteLine(modelVariant);
            // Internal protected field accessible from within this class
            Console.WriteLine(year);
            // Console.WriteLine(wheel.name);
            // Console.WriteLine(wheel.value);
        }
        public enum BodyType
        {
            Unknown = 0,
        }
        protected class Wheel
        {
            internal string name;
        }
    }
}
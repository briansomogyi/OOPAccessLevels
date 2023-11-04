namespace OOPAccessLevels.Library
{
    public class Car
    {
        private string manufacturer = "Renaut";
        protected string model = "Clio";
        private protected string modelVariant = "BaseModel";
        internal int year = 2023;
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
        }
    }
}
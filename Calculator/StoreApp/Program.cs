namespace StoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Store store = new Store(
                "Fresh Market",
                "12 Shevchenko Street",
                StoreType.Grocery))
            {
                store.ShowInfo();
            }

            Console.WriteLine("Object has exited the using block.");

            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine("Program finished.");
            Console.ReadLine();
        }
    }
}
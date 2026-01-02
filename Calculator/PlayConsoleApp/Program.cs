namespace PlayConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Play play = new Play(
                "Forest Song",
                "Lesya Ukrainka",
                "Poetic Drama (Drama-Fantasy)",
                1911))
            {
                play.ShowInfo();
            }

            Console.WriteLine("Object has exited the using block.");

            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine("Program finished.");
            Console.ReadLine();
        }
    }
}

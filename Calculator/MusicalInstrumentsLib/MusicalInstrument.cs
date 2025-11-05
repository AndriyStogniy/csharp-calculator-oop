namespace MusicalInstrumentsLib
{
    public abstract class MusicalInstrument
    {
        public string InstrumentName { get; private set; }
        public string InstrumentDescription { get; private set; }
        public string InstrumentHistory { get; private set; }

        public MusicalInstrument(string instrumentName, string instrumentDescription, string instrumentHistory)
        {
            InstrumentName = instrumentName;
            InstrumentDescription = instrumentDescription;
            InstrumentHistory = instrumentHistory;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Name: {InstrumentName}");
        }
        public virtual void Description()
        {
            Console.WriteLine($"Description: {InstrumentDescription}");
        }
        public virtual void History()
        {
            Console.WriteLine($"History: {InstrumentHistory}");
        }

    }
}

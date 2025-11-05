using MusicalInstrumentsLib;

List<MusicalInstrument> orcestra = new List<MusicalInstrument>
{
    new Cello(),
    new Trombone(),
    new Ukulele(),
    new Violin(),
};

foreach(MusicalInstrument instrument in orcestra)
{
    instrument.Show();
    instrument.Description();
    instrument.History();
    Console.WriteLine();
}
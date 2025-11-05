using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicalInstrumentsLib
{
    public class Violin : MusicalInstrument
    {
        public Violin() : base(
            "Violin",
            "A bowed string instrument with four strings, played with a bow.",
            "The violin appeared in Italy in the 16th century, evolving from earlier bowed instruments.")
        {
        }

        public override void Show()
        {
            Console.WriteLine("This is Violin!");
        }
    }
}

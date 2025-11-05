using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicalInstrumentsLib
{
    public class Ukulele : MusicalInstrument
    {
        public Ukulele() : base(
            "Ukulele",
            "A small four-stringed plucked instrument similar to a guitar.",
            "The ukulele originated in Hawaii in the late 19th century, inspired by Portuguese instruments.")
        {
        }

        public override void Show()
        {
            Console.WriteLine("This is Ukulele!");
        }
    }
}

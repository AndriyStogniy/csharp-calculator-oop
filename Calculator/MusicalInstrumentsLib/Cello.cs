using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicalInstrumentsLib
{
    public class Cello: MusicalInstrument
    {
        public Cello() : base(
            "Cello",
            "A large bowed instrument played while sitting, held between the knees",
            "The cello appeared in the 16th century in Italy and is one of the main instruments of the symphony orchestra.")
        {
        }

        public override void Show()
        {
            Console.WriteLine("This is Cello!");
        }
    }
}

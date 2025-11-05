using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicalInstrumentsLib
{
    public class Trombone : MusicalInstrument
    {
        public Trombone() : base(
            "Trombone",
            "A brass instrument with a sliding tube for changing the pitch of the sound.",
            "The trombone appeared in the 15th century and was used in brass bands and church music.")
        {
        }

        public override void Show()
        {
            Console.WriteLine("This is Trombone!");
        }
    }
}

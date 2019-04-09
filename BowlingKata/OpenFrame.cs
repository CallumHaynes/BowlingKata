using System.Collections.Generic;
using System.Linq;

namespace BowlingKata
{
    class OpenFrame : Frame
    {
        public override int Score => Throws.Sum();

        public OpenFrame(int throw1, int throw2)
        {
            Throws = new List<int> {throw1, throw2};
        }
    }
}
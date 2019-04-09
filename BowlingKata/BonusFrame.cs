using System.Collections.Generic;

namespace BowlingKata
{
    public class BonusFrame : Frame
    {
        public override int Score => 0;

        public BonusFrame(int throw1)
        {
            ThrowsForTurn = new List<int> {throw1};
        }
    }
}

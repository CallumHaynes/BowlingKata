using System.Collections.Generic;

namespace BowlingKata
{
    class StrikeFrame : FrameWithBonus
    {
        public override int Score => 10 + SumNextBalls(2);

        public StrikeFrame(List<Frame> frameList) : base(frameList)
        {
            ThrowsForTurn = new List<int> { 10 };
        }
    }
}

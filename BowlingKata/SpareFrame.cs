using System.Collections.Generic;

namespace BowlingKata
{
    class SpareFrame : FrameWithBonus
    {
        public override int Score => 10 + SumNextBalls(1);

        public SpareFrame(int throw1, int throw2, List<Frame> frameList) : base(frameList)
        {
            ThrowsForTurn = new List<int> {throw1, throw2};
        }
    }
}

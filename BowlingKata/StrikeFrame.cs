using System.Collections.Generic;

namespace BowlingKata
{
    public class StrikeFrame : FrameWithBonus
    {
        public override int Score => 10 + SumNextBalls(2);

        public StrikeFrame(List<Frame> throwList):base(throwList)
        {
            Balls = new List<int> {10};
        }
    }
}

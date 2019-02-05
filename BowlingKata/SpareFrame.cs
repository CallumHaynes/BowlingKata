using System.Collections.Generic;

namespace BowlingKata
{
    public class SpareFrame : FrameWithBonus
    {
        public override int Score => 10 + SumNextBalls(1);

        public SpareFrame(int ball1, int ball2, List<Frame> throwList) :base(throwList)
        {
            Balls = new List<int> { ball1, ball2 };
        }
    }
}

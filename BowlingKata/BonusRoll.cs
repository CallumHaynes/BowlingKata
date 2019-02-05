using System.Collections.Generic;

namespace BowlingKata
{
    public class BonusRoll : Frame
    {
        public override int Score => 0;

        public BonusRoll(int ball1)
        {
            Balls = new List<int> { ball1 };
        }
    }
}

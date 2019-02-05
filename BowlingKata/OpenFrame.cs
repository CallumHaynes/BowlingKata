using System.Collections.Generic;
using System.Linq;

namespace BowlingKata
{
    public class OpenFrame : Frame
    {
        public override int Score => Balls.Sum();

        public OpenFrame(int ball1, int ball2)
        {
            Balls = new List<int> {ball1, ball2};
        }
    }
}

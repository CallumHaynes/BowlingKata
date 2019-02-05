using System.Collections.Generic;

namespace BowlingKata
{
    public abstract class Frame
    {
        public List<int> Balls { get; set; }
        public abstract int Score { get; }
    }
}

using System.Collections.Generic;

namespace BowlingKata
{
    public abstract class Frame
    {
        public abstract int Score { get; }
        public List<int> ThrowsForTurn;
    }
}

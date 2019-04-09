using System.Collections.Generic;
using System.Linq;

namespace BowlingKata
{   
    public abstract class FrameWithBonus : Frame
    {
        private readonly List<Frame> _frameList;

        protected FrameWithBonus(List<Frame> frameList)
        {
            _frameList = frameList;
        }

        public int SumNextBalls(int numberOfBalls)
        {
            return _frameList.FindAll(x => _frameList.IndexOf(x) > _frameList.IndexOf(this)).SelectMany(x => x.ThrowsForTurn).Take(numberOfBalls).Sum();
        }
    }
}
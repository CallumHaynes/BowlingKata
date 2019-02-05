using System.Collections.Generic;
using System.Linq;

namespace BowlingKata
{
    public abstract class FrameWithBonus : Frame
    {
        private readonly List<Frame> _throwList;

        protected FrameWithBonus(List<Frame> throwList)
        {
            _throwList = throwList;
        }

        protected int SumNextBalls(int numBalls)
        {
            var index = _throwList.IndexOf(this) + 1;
            var count = _throwList.Count - index;

            return _throwList.GetRange(index, count).SelectMany(x => x.Balls).Take(numBalls).Sum();
        }
    }
}
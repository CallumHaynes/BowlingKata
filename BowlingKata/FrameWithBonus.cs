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
            return _throwList.FindAll(x => _throwList.IndexOf(x) > _throwList.IndexOf(this)).SelectMany(x => x.Balls)
                .Take(numBalls).Sum();
        }
    }
}
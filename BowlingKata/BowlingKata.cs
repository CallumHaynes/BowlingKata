using System;
using System.Collections.Generic;
using System.Linq;

namespace BowlingKata
{
    public class BowlingKata
    {
        private readonly List<Frame> _frameList;

        public BowlingKata()
        {
            _frameList = new List<Frame>();
        }

        public void OpenFrame(int throw1, int throw2)
        {
            _frameList.Add(new OpenFrame(throw1, throw2));
        }

        public void SpareFrame(int throw1, int throw2)
        {
            _frameList.Add(new SpareFrame(throw1, throw2, _frameList));
        }

        public void StrikeFrame()
        {
            _frameList.Add(new StrikeFrame(_frameList));
        }

        public void BonusFrame(int throw1)
        {
            _frameList.Add(new BonusFrame(throw1));
        }

        public int Score()
        {
            return _frameList.Sum(x => x.Score);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

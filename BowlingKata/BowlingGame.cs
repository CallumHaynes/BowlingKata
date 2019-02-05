using System;
using System.Collections.Generic;
using System.Linq;

namespace BowlingKata
{
    public class BowlingGame
    {
        private readonly List<Frame> _throwList;

        public BowlingGame()
        {
            _throwList = new List<Frame>();
        }

        public void ResetGame()
        {
            _throwList.Clear();
        }

        public void OpenFrame(int ball1, int ball2)
        {
            _throwList.Add(new OpenFrame(ball1, ball2));
        }

        public void SpareFrame(int ball1, int ball2)
        {
            _throwList.Add(new SpareFrame(ball1, ball2, _throwList));
        }

        public void StrikeFrame()
        {
            _throwList.Add(new StrikeFrame(_throwList));
        }

        public void BonusRoll(int roll)
        {
            _throwList.Add(new BonusRoll(roll));
        }

        public int Score()
        {
            return _throwList.Sum(x => x.Score);
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Bowling Kata");
        }
    }
}

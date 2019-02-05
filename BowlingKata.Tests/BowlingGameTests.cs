using NUnit.Framework;

namespace BowlingKata.Tests
{
    [TestFixture]
    public class BowlingGameTests
    {
        private readonly BowlingGame _bowlingGame;

        public BowlingGameTests()
        {
            _bowlingGame = new BowlingGame();
        }

        [Test]
        public void OpenFrame_AllGutterBalls_ScoreIsZero()
        {
            _bowlingGame.ResetGame();
            ManyOpenFrames(10, 0, 0);

            Assert.AreEqual(0, _bowlingGame.Score());
        }

        [Test]
        public void OpenFrame_AllThrees_ScoreIsZero()
        {
            _bowlingGame.ResetGame();
            ManyOpenFrames(10, 3, 3);

            Assert.AreEqual(60, _bowlingGame.Score());
        }

        [Test]
        public void SpareFrame_OneSpare_ScoreIsCorrect()
        {
            _bowlingGame.ResetGame();
            _bowlingGame.SpareFrame(4, 6);
            _bowlingGame.OpenFrame(3, 5);
            ManyOpenFrames(8, 0, 0);
            Assert.AreEqual(21, _bowlingGame.Score());
        }

        [Test]
        public void SpareFrame_OneSpare2_ScoreIsCorrect()
        {
            _bowlingGame.ResetGame();
            _bowlingGame.SpareFrame(4, 6);
            _bowlingGame.OpenFrame(5, 3);
            ManyOpenFrames(8, 0, 0);
            Assert.AreEqual(23, _bowlingGame.Score());
        }

        [Test]
        public void StrikeFrame_OneStrike_ScoreIsCorrect()
        {
            _bowlingGame.ResetGame();
            _bowlingGame.StrikeFrame();
            _bowlingGame.OpenFrame(5, 3);
            ManyOpenFrames(8, 0, 0);
            Assert.AreEqual(26, _bowlingGame.Score());
        }

        [Test]
        public void BonusFrame_StrikeFinalFrame_CorrectScore()
        {
            _bowlingGame.ResetGame();
            ManyOpenFrames(9,0,0);
            _bowlingGame.StrikeFrame();
            _bowlingGame.BonusRoll(5);
            _bowlingGame.BonusRoll(3);
            Assert.AreEqual(18, _bowlingGame.Score());
        }

        [Test]
        public void BonusFrame_SpareFinalFrame_CorrectScore()
        {
            _bowlingGame.ResetGame();
            ManyOpenFrames(9, 0, 0);
            _bowlingGame.SpareFrame(5, 5);
            _bowlingGame.BonusRoll(5);
            Assert.AreEqual(15, _bowlingGame.Score());
        }

        [Test]
        public void PerfectGame()
        {
            _bowlingGame.ResetGame();
            for (int i = 0; i < 10; i++)
            {
                _bowlingGame.StrikeFrame();
            }
            _bowlingGame.BonusRoll(10);
            _bowlingGame.BonusRoll(10);

            Assert.AreEqual(300, _bowlingGame.Score());
        }

        [Test]
        public void Alternating()
        {
            _bowlingGame.ResetGame();
            for (int i = 0; i < 5; i++)
            {
                _bowlingGame.StrikeFrame();
                _bowlingGame.SpareFrame(4, 6);

            }
            _bowlingGame.BonusRoll(10);

            Assert.AreEqual(200, _bowlingGame.Score());
        }

        private void ManyOpenFrames(int count, int ball1, int ball2)
        {
            for (int i = 0; i < count; i++)
            {
                _bowlingGame.OpenFrame(ball1, ball2);
            }
        }
    }
}
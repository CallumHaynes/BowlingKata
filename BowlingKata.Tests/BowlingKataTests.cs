using NUnit.Framework;

namespace BowlingKata.Tests
{
    [TestFixture]
    class BowlingKataTests
    {
        private BowlingKata _bowlingKata;

        [SetUp]
        public void SetUp()
        {
            _bowlingKata = new BowlingKata();
        }

        [Test]
        public void GutterBalls()
        {
            ManyOpenFrames(10, 0, 0);

            Assert.AreEqual(0, _bowlingKata.Score());
        }

        [Test]
        public void Threes()
        {
            ManyOpenFrames(10, 3, 3);

            Assert.AreEqual(60, _bowlingKata.Score());
        }

        [Test]
        public void Spare()
        {
            _bowlingKata.SpareFrame(4, 6);
            _bowlingKata.OpenFrame(3, 5);
            ManyOpenFrames(8, 0, 0);
            Assert.AreEqual(21, _bowlingKata.Score());
        }

        [Test]
        public void Spare2()
        {
            _bowlingKata.SpareFrame(4, 6);
            _bowlingKata.OpenFrame(5, 3);
            ManyOpenFrames(8, 0, 0);
            Assert.AreEqual(23, _bowlingKata.Score());
        }

        [Test]
        public void Strike()
        {
            _bowlingKata.StrikeFrame();
            _bowlingKata.OpenFrame(5, 3);
            ManyOpenFrames(8, 0, 0);
            Assert.AreEqual(26, _bowlingKata.Score());
        }

        [Test]
        public void StrikeFinalFrame()
        {
            ManyOpenFrames(9, 0, 0);
            _bowlingKata.StrikeFrame();
            _bowlingKata.BonusFrame(5);
            _bowlingKata.BonusFrame(3);
            Assert.AreEqual(18, _bowlingKata.Score());
        }

        [Test]
        public void SpareFinalFrame()
        {
            ManyOpenFrames(9, 0, 0);
            _bowlingKata.SpareFrame(4, 6);
            _bowlingKata.BonusFrame(5);
            Assert.AreEqual(15, _bowlingKata.Score());
        }

        [Test]
        public void Perfect()
        {
            for (var i = 0; i < 10; i++)
            {
                _bowlingKata.StrikeFrame();
            }
            _bowlingKata.BonusFrame(10);
            _bowlingKata.BonusFrame(10);
            Assert.AreEqual(300, _bowlingKata.Score());
        }

        [Test]
        public void Alternating()
        {
            for (var i = 0; i < 5; i++)
            {
                _bowlingKata.StrikeFrame();
                _bowlingKata.SpareFrame(4, 6);
            }
            _bowlingKata.BonusFrame(10);
            Assert.AreEqual(200, _bowlingKata.Score());
        }

        private void ManyOpenFrames(int amountOfFrames, int throw1, int throw2)
        {
            for (var i = 0; i < amountOfFrames; i++)
            {
                _bowlingKata.OpenFrame(throw1, throw2);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameLib.Frame
{
    internal class NormalFrame : IFrame
    {
        private PinCollection _pinCollection;
        private readonly IFrame _nextFrame;

        internal NormalFrame(IFrame nextFrame)
        {
            _pinCollection = new PinCollection();
            _nextFrame = nextFrame;
        }


        public bool IsFull => _pinCollection.Count() >= 2;//TODO:ストライク対応

        public Score BonusScoreForSpare => _pinCollection.PinAt(0).ToScore();

        public void Add(Pin pin)
        {
            _pinCollection.Add(pin);
        }

        public Score Score()
        {
            Score basicScore = CalcBasicScore();
            var bonusScore = CalcSpareBonus();
            return basicScore.Add(bonusScore);
        }

        private Score CalcBasicScore()
        {
            return _pinCollection.Sum().ToScore();
        }

        private Score CalcSpareBonus()
        {
            if (IsSpare()) return _nextFrame.BonusScoreForSpare;
            return new Score(0);
        }

        private bool IsSpare()
        {
            return CalcBasicScore().Equals(new Score(10));
        }
    }
}

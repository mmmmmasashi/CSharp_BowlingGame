using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameLib.Frame
{
    internal class NormalFrame : IFrame
    {
        private List<Pin> _pins = new List<Pin>();
        private readonly IFrame _nextFrame;

        internal NormalFrame(IFrame nextFrame)
        {
            _nextFrame = nextFrame;
        }


        public bool IsFull => _pins.Count >= 2;

        public Score BonusScoreForSpare => _pins[0].ToScore();

        public void Add(Pin pin)
        {
            _pins.Add(pin);
        }

        public Score Score()
        {
            Score basicScore = CalcBasicScore();
            var bonusScore = CalcSpareBonus();
            return basicScore.Add(bonusScore);
        }

        private Score CalcBasicScore()
        {
            return new Score(_pins.Sum(pin => pin.Num));
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

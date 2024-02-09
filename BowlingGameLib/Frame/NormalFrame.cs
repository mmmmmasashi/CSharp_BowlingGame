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

        public bool IsFull => _pins.Count >= 2;

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
            if (CalcBasicScore().Equals(new Score(10))) return new Score(2);
            return new Score(0);
        }
    }
}

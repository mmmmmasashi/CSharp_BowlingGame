using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameLib.Frame
{
    internal class FinalFrame : IFrame
    {
        private List<Pin> _pins;

        public FinalFrame()
        {
            _pins = new List<Pin>();
        }

        public bool IsFull => _pins.Count() >= 2;//TODO:

        public Score BonusScoreForSpare => _pins.First().ToScore();//TODO:TEST追加

        public void Add(Pin pin)
        {
            _pins.Add(pin);
        }

        public Score Score()
        {
            return new Score(_pins.Sum(pin => pin.Num));
        }
    }
}

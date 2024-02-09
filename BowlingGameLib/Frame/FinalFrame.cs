using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameLib.Frame
{
    internal class FinalFrame : IFrame
    {
        private PinCollection _pinCollection;

        internal FinalFrame()
        {
            _pinCollection = new PinCollection();
        }

        public bool IsFull => _pinCollection.Count() >= 2;//TODO:

        public Score BonusScoreForSpare => _pinCollection.PinAt(0).ToScore();//TODO:TEST追加

        public void Add(Pin pin)
        {
            _pinCollection.Add(pin);
        }

        public Score Score()
        {
            return _pinCollection.Sum().ToScore();
        }
    }
}

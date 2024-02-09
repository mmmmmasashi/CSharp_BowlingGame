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

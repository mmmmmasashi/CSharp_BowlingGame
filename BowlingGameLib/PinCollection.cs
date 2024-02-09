using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameLib
{
    internal class PinCollection
    {
        private List<Pin> _pins = new List<Pin>();
        internal void Add(Pin pin)
        {
            _pins.Add(pin);
        }

        internal Pin Sum()
        {
            return new Pin(_pins.Sum(pin => pin.Num));
        }

        internal int Count()
        {
            return _pins.Count;
        }

        internal Pin PinAt(int idx)
        {
            return _pins[idx];
        }
    }
}

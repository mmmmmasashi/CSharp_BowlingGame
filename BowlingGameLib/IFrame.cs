using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameLib
{
    internal interface IFrame
    {
        bool IsFull { get; }
        Score BonusScoreForSpare { get; }

        void Add(Pin pin);
        Score Score();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameLib
{
    public class Score
    {
        private int _val;

        public Score(int val)
        {
            this._val = val;
        }

        public override string ToString()
        {
            return $"Score : {_val}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Score score &&
                   _val == score._val;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_val);
        }
    }
}

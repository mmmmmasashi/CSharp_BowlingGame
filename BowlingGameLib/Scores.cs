using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameLib
{
    internal class Scores
    {
        private List<Score> _scores;
        internal Scores(IEnumerable<Score> scores)
        {
            _scores = scores.ToList();
        }

        internal Score Sum()
        {
            var total = new Score(0);
            _scores.ForEach(each => total = total.Add(each));
            return total;
        }
    }
}

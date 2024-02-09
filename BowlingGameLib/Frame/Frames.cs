using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameLib.Frame
{
    internal class Frames
    {
        private IList<IFrame> _frames;
        public Frames(IList<IFrame> frames)
        {
            _frames = frames;
        }

        internal Score ScoreAll()
        {
            return new Score(_frames.Select(frame => frame.Score()).Sum(score => score.Value));
        }

        internal IEnumerable<Score> ScoreEach()
        {
            return _frames.Select(frame => frame.Score());
        }

        internal IFrame SearchCurrentFrame()
        {
            return _frames.First(frame => !frame.IsFull);
        }
    }
}

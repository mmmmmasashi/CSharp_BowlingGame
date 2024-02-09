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

        internal Scores ToScores()
        {
            return new Scores(_frames.Select(frame => frame.Score()));
        }

        internal IFrame SearchCurrentFrame()
        {
            return _frames.First(frame => !frame.IsFull);
        }
    }
}

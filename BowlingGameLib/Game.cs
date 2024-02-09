using BowlingGameLib.Frame;
using System.Linq;

namespace BowlingGameLib
{
    public class Game
    {
        private Frames _frames;

        public Game()
        {
            var frames = new Queue<IFrame>();
            frames.Enqueue(new FinalFrame());

            for (int i = 0; i < 9; i++)
            {
                frames.Enqueue(new NormalFrame(frames.Last()));
            }

            _frames = new Frames(frames.Reverse().ToArray());
        }

        public void Roll(Pin pin)
        {
            var currentFrame = _frames.SearchCurrentFrame();
            currentFrame.Add(pin);
        }

        public Score Score()
        {
            var scores = _frames.ToScores();
            return scores.Sum();
        }
    }
}
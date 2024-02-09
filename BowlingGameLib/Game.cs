using BowlingGameLib.Frame;

namespace BowlingGameLib
{
    public class Game
    {
        private IList<IFrame> _frames;

        public Game()
        {
            var frames = new Queue<IFrame>();
            frames.Enqueue(new FinalFrame());

            for (int i = 0; i < 9; i++)
            {
                frames.Enqueue(new NormalFrame(frames.Last()));
            }

            _frames = frames.Reverse().ToArray();
        }

        public void Roll(Pin pin)
        {
            var currentFrame = _frames.First(frame => !frame.IsFull);
            currentFrame.Add(pin);
        }

        public Score Score()
        {
            return new Score(_frames.Select(frame => frame.Score()).Sum(score => score.Value));
        }
    }
}
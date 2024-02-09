using BowlingGameLib.Frame;

namespace BowlingGameLib
{
    public class Game
    {
        private List<IFrame> _frames;

        public Game()
        {
            _frames = Enumerable.Range(0, 10).Select(_ => (IFrame)new NormalFrame()).ToList();
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
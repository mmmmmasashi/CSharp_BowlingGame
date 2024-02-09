using BowlingGameLib.Frame;

namespace BowlingGameLib
{
    public class Game
    {
        private IFrame _frame;
        private int _ballCount;

        public Game()
        {
            _ballCount = 0;
            _frame = new NormalFrame();
        }

        public void Roll(Pin pin)
        {
            if (_ballCount >= 2) return;
            _ballCount++;
            _frame.Add(pin);

        }

        public Score Score()
        {
            return _frame.Score();
        }
    }
}
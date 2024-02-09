using BowlingGameLib;
using System;
using Xunit;

namespace BowlingGameLibTest
{
    public class GameTest
    {
        Game _game;

        public GameTest()
        {
            _game = new Game();
        }

        private void RollMany(Pin pin, int times)
        {
            Enumerable.Repeat(pin, times).ToList().ForEach(pin => _game.Roll(pin));
        }

        [Fact]
        public void AllGutter()
        {
            RollMany(new Pin(0), 20);
            Assert.Equal(new Score(0), _game.Score());
        }

        [Fact]
        public void NoMark()
        {
            _game.Roll(new Pin(2));
            _game.Roll(new Pin(3));

            RollMany(new Pin(0), 2 * 9);
            Assert.Equal(new Score(5), _game.Score());
        }

        [Fact]
        public void NoMark_10Frames()
        {
            for (int i = 0; i < 10; i++)
            {
                _game.Roll(new Pin(1));
                _game.Roll(new Pin(2));
            }

            Assert.Equal(new Score(3 * 10), _game.Score());
        }

        [Fact]
        public void Spare()
        {
            _game.Roll(new Pin(1));
            _game.Roll(new Pin(9));

            _game.Roll(new Pin(2));
            _game.Roll(new Pin(7));

            RollMany(new Pin(0), 2 * 8);

            Assert.Equal(new Score(12 + 9), _game.Score());
        }
    }
}
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
    }
}
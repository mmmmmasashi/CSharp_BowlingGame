using BowlingGameLib;
using System;
using Xunit;

namespace BowlingGameLibTest
{
    public class GameTest
    {
        [Fact]
        public void AllGutter()
        {
            var game = new Game();
            for (var i = 0; i < 20; i++)
            {
                game.Roll(new Pin(0));
            }

            Assert.Equal(new Score(0), game.Score());

        }

        [Fact]
        public void NoMark()
        {
            var game = new Game();
            game.Roll(new Pin(2));
            game.Roll(new Pin(3));

            for (int i = 0; i < 9; i++)
            {
                game.Roll(new Pin(0));
                game.Roll(new Pin(0));
            }

            Assert.Equal(new Score(5), game.Score());
        }
    }
}
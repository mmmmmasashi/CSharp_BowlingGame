using BowlingGameLib;

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
    }
}
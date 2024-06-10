using MemoryGameLogic;
namespace Program
{
    public class Program
    {
        static void Main()
        {
            MemoryGame game = new MemoryGame();

            game.startGame();

            while(game.isActive())
            {

            }
        }
    }
}

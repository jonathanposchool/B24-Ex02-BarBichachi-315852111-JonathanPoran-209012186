namespace GanricCardGame
{
    public abstract class GameBase
    {
        private bool gameActivation=false;
        public int numOfPlayers;
        private Player[] Players;

        public GameBase()
        {
            this.numOfPlayers = 0;
        }
        public bool isActive()
        {
            return gameActivation;
        }
        public void startGame()
        {
            gameActivation = true;
        }
        public abstract void InitiateGame();
    }
}

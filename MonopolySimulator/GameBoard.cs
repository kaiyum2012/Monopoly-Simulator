namespace MonopolySimulator
{
    //DONE:: Apply singleton pattern on Game Board
    public sealed class GameBoard
    {
        private static GameBoard _instance = null;
        private static readonly object threadLock = new object();
        
        private GameBoard()
        {

        }

        // Singleton Instance
        // METHOD 1: Access instance over Property
        public static GameBoard Instance 
        {
            get {
                lock (threadLock) // acquiring lock on shared object 
                {
                    if(_instance == null)
                    {
                        _instance = new GameBoard();
                    }
                }
                return _instance;
            }
        }

        // Method 2: Access Instance over Method

        public static GameBoard GetBoard()
        {
           lock (threadLock) // acquiring lock on shared object 
           {
                if (_instance == null)
                {
                    _instance = new GameBoard();
                }
           }
           return _instance;
        }
    }
}
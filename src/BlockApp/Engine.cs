namespace BlockApp
{
    public class Engine
    {
        public Block Block { get; set; } = new Block();
        public Level Level { get; set; } = new Level();

        private static Engine _instance;
        public static Engine Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Engine();

                return _instance;
            }
        }

        private Engine()
        {
            Level.LevelUp(Block);
        }        

        public void Reset()
        {
            Block = new Block();
            Level = new Level();
            Level.LevelUp(Block);
        }

        public void LevelUp()
        {
            Level.LevelUp(Block);
        }

        public void Move(Move movement)
        {
            switch (movement)
            {
                case BlockApp.Move.Left:
                    Block.MoveLeft();
                    break;
                case BlockApp.Move.Right:
                    Block.MoveRight();
                    break;
                case BlockApp.Move.Up:
                    Block.MoveUp();
                    break;
                case BlockApp.Move.Down:
                    Block.MoveDown();
                    break;
            }

            if (Block.Area == Level.Area)
                LevelUp();
            if (Block.Area > Level.Area)
                throw new System.Exception("Loser!");
        }
    }
}

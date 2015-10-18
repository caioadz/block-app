namespace BlockApp.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run)
            {
                System.Console.WriteLine($"{ nameof(Engine.Instance.Block.Height) }: { Engine.Instance.Block.Height }");
                System.Console.WriteLine($"{ nameof(Engine.Instance.Block.Length) }: { Engine.Instance.Block.Length }");
                System.Console.WriteLine($"{ nameof(Engine.Instance.Block.Area) }: { Engine.Instance.Block.Area }");
                System.Console.WriteLine($"{ nameof(Engine.Instance.Level) }: { Engine.Instance.Level.Area }");
                System.Console.WriteLine("--------------------------------------");
                System.Console.WriteLine("Press any arrow key to continue!");
                
                switch (System.Console.ReadKey().Key)
                {
                    case System.ConsoleKey.UpArrow:
                        Engine.Instance.Move(Move.Up);
                        break;
                    case System.ConsoleKey.LeftArrow:
                        Engine.Instance.Move(Move.Left);
                        break;
                    case System.ConsoleKey.RightArrow:
                        Engine.Instance.Move(Move.Right);
                        break;
                    case System.ConsoleKey.DownArrow:
                        Engine.Instance.Move(Move.Down);
                        break;
                    default:
                        run = false;
                        break;
                }

                System.Console.Clear();
            }
        }
    }
}

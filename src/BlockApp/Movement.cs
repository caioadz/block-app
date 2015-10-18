namespace BlockApp
{
    public enum Move
    {
        Left,
        Right,
        Up,
        Down
    }

    public static class Movement
    {
        public static void MoveLeft(this Block sqr) => sqr.Length += 1;

        public static void MoveRight(this Block sqr) => sqr.Length += 1;

        public static void MoveUp(this Block sqr) => sqr.Height += 1;

        public static void MoveDown(this Block sqr) => sqr.Height += 1;
    }
}

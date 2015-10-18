namespace BlockApp
{
    public class Block
    {
        public long Height { get; set; } = 1;
        public long Length { get; set; } = 1;
        public long Area => Height * Length;
    }
}

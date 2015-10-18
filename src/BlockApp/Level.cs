using System.Collections.Generic;

namespace BlockApp
{
    public class Level
    {
        public int _stepCounter = 0;

        public long Area { get; set; }
        public int Step { get; set; }

        public void LevelUp(Block block)
        {
            GetNextArea(0, Step, block);
            IncrementStep();
        }

        private void IncrementStep()
        {
            if (_stepCounter >= 3)
            {
                _stepCounter = 0;
                Step += 1;
            }
            else
            {
                _stepCounter += 1;
            }
        }

        private void GetNextArea(int idx, int step, Block block)
        {
            var possibleAreas = new List<long>();
            FillPossibleAreas(idx, step, block, possibleAreas);
            Area = possibleAreas.Random();
        }

        private void FillPossibleAreas(int idx, int step, Block block, List<long> possibleAreas)
        {
            Block byHeight = Clone(block);
            byHeight.Height += 1;
            AddAreaRecursively(idx, step, byHeight, possibleAreas);

            Block byLength = Clone(block);
            byLength.Length += 1;
            AddAreaRecursively(idx, step, byLength, possibleAreas);
        }

        private void AddAreaRecursively(int idx, int step, Block block, List<long> possibleAreas)
        {
            if (possibleAreas.Contains(block.Area) == false)
                possibleAreas.Add(block.Area);   

            if (idx < Step)
                FillPossibleAreas(++idx, step, block, possibleAreas);
        }

        private static Block Clone(Block block)
        {
            Block clone = new Block()
            {
                Height = block.Height,
                Length = block.Length
            };

            return clone;
        }
    }
}

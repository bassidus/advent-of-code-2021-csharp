namespace AdventOfCode
{
    public class Day2
    {
        private string[] directions = File.ReadAllLines("./input/day2.txt");

        public int Part1()
        {
            int pos = 0, depth = 0;
            foreach (var line in directions)
            {
                var direction = line.Split(' ')[0];
                int.TryParse(line.Split(' ')[1], out int value);

                switch (direction)
                {
                    case "forward":
                        pos += value;
                        break;
                    case "down":
                        depth += value;
                        break;
                    case "up":
                        depth -= value;
                        break;
                    default:
                        break;
                }
            }

            return pos * depth;
        }

        public int Part2()
        {
            int aim = 0, pos = 0, depth = 0;
            foreach (var line in directions)
            {
                var direction = line.Split(' ')[0];
                int.TryParse(line.Split(' ')[1], out int value);

                switch (direction)
                {
                    case "forward":
                        pos += value;
                        depth += value * aim;
                        break;
                    case "down":
                        aim += value;
                        break;
                    case "up":
                        aim -= value;
                        break;
                    default:
                        break;
                }
            }
            return pos * depth;
        }
    }
}

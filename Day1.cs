namespace AdventOfCode
{
    using System.IO;

    using System;

    public class Day1
    {
        private List<int>
            depths =
                Array
                    .ConvertAll(File.ReadAllLines("./input/day1.txt"),
                    int.Parse)
                    .ToList();

        public void Part1()
        {
            var prev = depths[0];
            var incr = 0;

            foreach (var depth in depths)
            {
                incr += depth > prev ? 1 : 0;
                prev = depth;
            }

            Console.WriteLine($"Day 1, Part 1: {incr}");
        }

        public void Part2()
        {
            var prev = depths[0];
            var incr = 0;

            for (int i = 0; i < depths.Count - 3; i++)
            {
                int window = depths.GetRange(i, 3).Sum();
                incr += window > prev ? 1 : 0;
                prev = window;
            }

            Console.WriteLine($"Day 1, Part 2: {incr}");
        }
    }
}

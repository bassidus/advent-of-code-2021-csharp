namespace AdventOfCode
{
    using System.Diagnostics;
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new Stopwatch();
            var day1 = new Day1();
            var day2 = new Day2();
            var day3 = new Day3();

            sw.Start();

            Console.WriteLine($"Day 1 - Part 1: {day1.Part1()}");
            Console.WriteLine($"Day 1 - Part 2: {day1.Part2()}");
            Console.WriteLine($"Day 2 - Part 1: {day2.Part1()}");
            Console.WriteLine($"Day 2 - Part 2: {day2.Part2()}");
            Console.WriteLine($"Day 3 - Part 1: {day3.Part1()}");
            Console.WriteLine($"Day 3 - Part 2: {day3.Part2()}");

            sw.Stop();

            Console.WriteLine($"Total: {sw.Elapsed}");
        }
    }
}

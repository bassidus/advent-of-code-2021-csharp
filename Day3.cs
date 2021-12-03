namespace AdventOfCode
{
    public class Day3
    {
        private string[] logbook = File.ReadAllLines("./input/day3.txt");
        private int BinaryToInt(string b) => Convert.ToInt32(b, 2);
        private enum Rating { OxygenRating, Co2Rating }
        public int Part1()
        {
            var gamma = string.Empty;
            var epsilon = string.Empty;

            for (var i = 0; i < 12; i++)
            {
                var ones = 0;
                var zeroes = 0;

                foreach (var log in logbook)
                {
                    ones += log[i] == '1' ? 1 : 0;
                    zeroes += log[i] == '0' ? 1 : 0;
                }

                gamma += ones > zeroes ? "1" : "0";
                epsilon += zeroes > ones ? "1" : "0";
            }

            return BinaryToInt(gamma) * BinaryToInt(epsilon);
        }
        public int Part2() => Search(Rating.OxygenRating) * Search(Rating.Co2Rating);
        private int Search(Rating rating)
        {
            var oxygenOrCO2 = rating == Rating.OxygenRating ? true : false;
            var logs = logbook.ToList();
            foreach (var i in Enumerable.Range(0, logbook[0].Length))
            {
                var logCount = logs.Count(log => log[i] == '1');
                var searchFor = (2 * logCount >= logs.Count) == oxygenOrCO2 ? '1' : '0';

                logs = logs.Where(log => log[i] == searchFor).ToList();

                if (logs.Count == 1)
                {
                    return BinaryToInt(logs[0]);
                }
            }
            return 0;
        }
    }
}
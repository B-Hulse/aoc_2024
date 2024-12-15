partial class Days
{
    public static string Day1_Part1(InputType type = InputType.Example)
    {
        var input = InputFetcher.GetInput("day1", type);

        var left = new List<int>();
        var right = new List<int>();

        foreach (var line in input.Split(Environment.NewLine))
        {
            var split = line.Split("   ");

            left.Add(int.Parse(split[0]));
            right.Add(int.Parse(split[1]));
        }

        left.Sort();
        right.Sort();

        var distSum = 0;

        foreach (var pair in left.Select((l, i) => new { Left=l, Right=right[i]}))
        {
            distSum += Math.Abs(pair.Left - pair.Right);
        }

        return distSum.ToString();
    }

    public static string Day1_Part2(InputType type = InputType.Example)
    {
        var input = InputFetcher.GetInput("day1", type);

        var left = new List<int>();
        var right = new List<int>();

        foreach (var line in input.Split(Environment.NewLine))
        {
            var split = line.Split("   ");

            left.Add(int.Parse(split[0]));
            right.Add(int.Parse(split[1]));
        }

        var score = 0;
        foreach (var entry in left)
        {
            score += entry * right.Where(i => i == entry).Count();
        }

        return score.ToString();
    }
}
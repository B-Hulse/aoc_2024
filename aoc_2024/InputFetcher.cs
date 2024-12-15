public enum InputType
{
    Example,
    Actual
}

class InputFetcher
{
    private static string folderPath = @"D:\Dev\Source\aoc_2024\aoc_2024\input\";

    private static string InputTypeToString(InputType type)
    {
        switch (type)
        {
            case InputType.Example:
                return "example";
            case InputType.Actual:
                return "actual";
        }

        return "";
    }

    public static string GetInput(string day, InputType type)
    {
        string fileName = folderPath + day + "_" + InputTypeToString(type) + ".txt";

        using StreamReader sr = File.OpenText(fileName);

        return sr.ReadToEnd();
    }
}
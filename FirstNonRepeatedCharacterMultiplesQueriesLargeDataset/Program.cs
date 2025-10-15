const string largeDataset = "kjjjkkkjkjhdfkjhrfekjbrjjkbretgkjkadjhjfhjdhgfijfhijfrghhgfrehjberfmnberjfhijherfuihjrf";

var queries = new List<(int, int)>
{
    (0, 10),
    (5, 15),
    (10, 20),
    (15, 25),
    (20, 30),
    (25, 35),
    (30, 40),
    (35, 45),
    (40, 50),
    (45, 55),
    (50, 60),
    (55, 65),
    (60, 70),
    (65, 75),
    (70, largeDataset.Length)
};

foreach (var (start, end) in queries)
{
    var @char = FirstNonRepeatedCharacter(largeDataset, start, end);

    string result = @char == default ? "none" : @char.ToString();

    Console.WriteLine($"First non-repeated character between indices {start} and {end} is: {result}");
}

Console.ReadKey();

static char FirstNonRepeatedCharacter(string stringBase, int start, int end)
{
    Dictionary<char, int> charCounts = [];

    for (int i = start; i < end; i++)
    {
        charCounts[stringBase[i]] = charCounts.GetValueOrDefault(stringBase[i]) + 1;
    }

    for (int i = start; i < end; i++)
    {
        if (charCounts[stringBase[i]] == 1)
        {
            return stringBase[i];
        }
    }

    return default;
}
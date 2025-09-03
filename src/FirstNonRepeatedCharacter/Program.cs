Console.WriteLine("Write the word:");

var input = Console.ReadLine() ?? string.Empty;

input = input.Trim().ToLower();

Dictionary<char, int> counts = [];

foreach (var c in input)
{
    if (counts.ContainsKey(c))
        counts[c]++;
    else
        counts[c] = 1;
}

char? firstNonRepeated = input.FirstOrDefault(c => counts[c] == 1);

var message = firstNonRepeated == default(char)
    ? "All characters are repeated"
    : $"First non-repeated character: {firstNonRepeated}";

Console.WriteLine(message);
Console.ReadKey();

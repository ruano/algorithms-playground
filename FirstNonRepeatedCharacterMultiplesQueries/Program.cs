Console.WriteLine("Write base string:");
string baseString = Console.ReadLine() ?? string.Empty;

List<string> queries = new() { "abacabad", "xyz", "aabb" };

Dictionary<string, char?> finalResult = new();

foreach (string query in queries)
{
    char? firstNonRepeated = null;
    int startIndex = baseString.IndexOf(query, StringComparison.OrdinalIgnoreCase);

    if (startIndex != -1)
    {
        Dictionary<char, int> counts = new();

        for (int i = startIndex; i < startIndex + query.Length; i++)
        {
            char c = baseString[i];
            counts[c] = counts.GetValueOrDefault(c) + 1;
        }

        for (int i = startIndex; i < startIndex + query.Length; i++)
        {
            if (counts[baseString[i]] == 1)
            {
                firstNonRepeated = baseString[i];
                break;
            }
        }
    }

    finalResult.Add(query, firstNonRepeated);
}

// Output
foreach (var kv in finalResult)
{
    Console.WriteLine($"{kv.Key}: {(kv.Value.HasValue ? kv.Value.ToString() : "null")}");
}



Console.ReadKey();
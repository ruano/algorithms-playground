const string stream = "abcbad";

Queue<char> queue = [];

foreach (var item in stream)
{
    var nonRepeatedChar = FirstNonRepeatedCharacterFromQueue(queue, item);

    foreach (var itemQueue in queue)
    {
        Console.Write(itemQueue + " ");
    }

    var resultChar = nonRepeatedChar == '\0' ? "none" : nonRepeatedChar.ToString();

    Console.WriteLine("-> " + resultChar);
}

Console.ReadKey();

static char FirstNonRepeatedCharacterFromQueue(Queue<char> queue, char c)
{
    queue.Enqueue(c);

    Dictionary<char, int> counts = [];

    foreach (var item in queue)
    {
        counts[item] = counts.GetValueOrDefault(item) + 1;
    }

    foreach (var item in counts)
    {
        if (item.Value == 1)
        {
            return item.Key;
        }
    }

    return '\0';
}

// ---------- ChatGPT solution below ----------
//const string stream = "abcbad";

//Queue<char> queue = new();
//Dictionary<char, int> counts = new();

//foreach (var c in stream)
//{
//    counts[c] = counts.GetValueOrDefault(c) + 1;
//    queue.Enqueue(c);

//    // remove da frente da fila tudo que não é mais único
//    while (queue.Count > 0 && counts[queue.Peek()] > 1)
//        queue.Dequeue();

//    var result = queue.Count > 0 ? queue.Peek().ToString() : "none";
//    Console.WriteLine($"{c} -> {result}");
//}

//Console.ReadKey();

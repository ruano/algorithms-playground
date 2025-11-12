var array = new int[] { 1, 4, 6, 7, 9, 15 };

Array.Sort(array);

var min = array.First();
var max = array.Last();

// search O(1)
var values = new HashSet<int>(array);

var missing = new List<int>();

for (int i = min; i <= max; i++)
{
    if (!values.Contains(i))
        missing.Add(i);
}

if (missing.Count > 0)
    Console.WriteLine($"The array is missing the following values: {string.Join(", ", missing)}");
else
    Console.WriteLine("The array values are complete!");



// ---------- using LINQ

//Array.Sort(array);

//var missing = Enumerable
//    .Range(array.First(), array.Last() - array.First() + 1)
//    .Except(array)
//    .ToList();

//Console.WriteLine(missing.Any()
//    ? $"Missing: {string.Join(", ", missing)}"
//    : "Sequence complete!");

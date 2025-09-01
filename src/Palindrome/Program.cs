using System.Text;

Console.WriteLine("Write the word or phrase:");

var input = Console.ReadLine();

input = input!.Trim().ToLower();

StringBuilder sb = new();

for (int i = input.Length - 1; i < input.Length && i >= 0; i--)
{
    sb.Append(input[i]);
}

bool isPalindrome = sb.ToString().Equals(input, StringComparison.InvariantCultureIgnoreCase);

Console.WriteLine($"Is palindrome? {isPalindrome}");

Console.ReadKey();
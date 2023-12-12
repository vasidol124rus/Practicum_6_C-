void Main(string[] args)
{
string input = "шалаш";
Console.WriteLine(isPalindrome ? "Да" : "Нет");
}
bool IsPalindrome(string str)
{
string normalized = new
string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
return normalized.SequenceEqual(normalized.Reverse());
}

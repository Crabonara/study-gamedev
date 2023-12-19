Console.WriteLine("Введите предложение: ");
string sentence = Console.ReadLine()!;

var words = SplitString(sentence);
WriteWordsToConsole(words);
Reverse(words);
foreach (var word in words)
    Console.Write(word + " ");
Console.WriteLine();
static void WriteWordsToConsole(string[] words)
{
    foreach (var word in words)
        Console.WriteLine(word);
}

static string[] SplitString(string sentence) =>
    sentence.Split(' ');

static void Reverse(string[] words)
{
    for (int i = 0, j = words.Length - 1; i < words.Length / 2; i++, j--)
    {
        var word = words[i];
        words[i] = words[j];
        words[j] = word;
    }
}

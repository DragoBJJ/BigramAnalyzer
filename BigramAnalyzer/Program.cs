
using Bigram;

class Program
{

    static void Main(string[] args)

    {
        var bigram = new BigramAnalyzer(new[] { "ala", "ma", "kota", "ala", "ma", "psa" });

        Console.WriteLine(bigram.GetCount("ala", "ma")); // wyjście: 2
        Console.WriteLine(bigram.GetCount("ma", "ala")); // wyjście: 0
        Console.WriteLine(bigram.GetCount("ma", "kota")); // wyjście: 1

    }
}
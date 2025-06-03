// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "Hallo Welt! Hallo, C# Welt. Welt sagt Hallo.";

        var wordCounts = CountWords(input);

        foreach (var pair in wordCounts)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }

    static Dictionary<string, int> CountWords(string text)
    {
        // Satzzeichen entfernen und in Kleinbuchstaben umwandeln
        string cleaned = Regex.Replace(text.ToLower(), @"[^\wäöüß]+", " ");

        // In Wörter aufteilen
        var words = cleaned.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        // Wörter zählen
        var result = words
            .GroupBy(word => word)
            .OrderBy(g => g.Key)
            .ToDictionary(g => g.Key, g => g.Count());

        return result;
    }
}

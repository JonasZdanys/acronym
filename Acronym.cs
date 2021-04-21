using System;
using System.Globalization;
using System.Linq;
public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        char[] separators = { ' ', '-', '_' };
        string[] words = phrase.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        var firstLetters = words.Select(letter => letter[0].ToString().ToUpper());
            var a = firstLetters.Aggregate((abbr, letter) => abbr += letter);
        return a;
    }
}
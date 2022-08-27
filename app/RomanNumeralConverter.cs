using System;
using System.Text.RegularExpressions;

/// <summary>
/// Simple static class for converting a String with a Roman Numeral to an Integer
/// </summary>
public static class RomanNumeralConverter
{
    private static readonly Dictionary<char, int> romanNumbersDictionary = new()
    {
        { 'I', 1 }, 
        { 'V', 5}, 
        { 'X', 10 }, 
        { 'L', 50 }, 
        { 'C', 100 }, 
        { 'D', 500 }, 
        { 'M', 1000 }
    };
    private static readonly Regex romanNumbersRegex = new Regex("^M{0,4}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})$", RegexOptions.Compiled | RegexOptions.IgnoreCase);

    /// <summary>
    /// This method extends the string class to convert a string consisting of roman numerals to an integer
    /// <example>
    /// For example:
    /// <code>
    /// string s = "III";
    /// int i = s.ConvertRomanToInt();
    /// </code>
    /// results in <c>i</c> having the value 3.
    /// </example>
    /// </summary>
    /// <param name="s">The string to be converted</param>
    /// <returns>Converted numeral as integer</returns>
    public static int ConvertRomanToInt(this string s)
    {
        if (!romanNumbersRegex.IsMatch(s))
            return 0;

        int sum = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (romanNumbersDictionary.TryGetValue(s[i], out int num))
            {
                if (i + 1 < s.Length && romanNumbersDictionary[s[i + 1]] > romanNumbersDictionary[s[i]])
                    sum -= num;
                else
                    sum += num;
            }
            else
                return 0;
        }
        return sum;
    }
}
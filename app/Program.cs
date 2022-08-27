class Program
{
    static void Main(string[] args)
    {
        string three = "III";
        string fiftyEight = "LVIII";
        string nineteenNinetyFour = "MCMXCIV";
        string test1 = "XXVII";
        string test2 = "safasfwefs";
        string test3 = "X3";
        string test4 = "IIIXX";
        
        Console.WriteLine(three.ConvertRomanToInt());
        Console.WriteLine(fiftyEight.ConvertRomanToInt());
        Console.WriteLine(nineteenNinetyFour.ConvertRomanToInt());
        Console.WriteLine(test1.ConvertRomanToInt());
        Console.WriteLine(test2.ConvertRomanToInt());
        Console.WriteLine(test3.ConvertRomanToInt());
        Console.WriteLine(test4.ConvertRomanToInt());
    }
}
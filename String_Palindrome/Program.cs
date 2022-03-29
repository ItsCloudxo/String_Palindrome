using System;

static class StringHelper
{
    public static string ReverseString(string myStr)
    {
        char[] myArr = myStr.ToCharArray();
        Array.Reverse(myArr);
        return new string(myArr);
    }
}

class StringPalindrome
{
    static void Main()
    {
        Console.WriteLine("Type a word here to see if it's a palindrome:");
        string preRev = Console.ReadLine();
        string rev = StringHelper.ReverseString(preRev);
        
        if (preRev.ToUpper() == rev.ToUpper())
        {
            Console.WriteLine($"Pre-reversed word: {preRev}. \n Reversed word: {rev}");
            Console.WriteLine("The entered word is a palindrome");
        }
        else
        {
            Console.WriteLine($"Pre-reversed word: {preRev}. \n Reversed word: {rev}");
            Console.WriteLine("The entered word is NOT a palindrome");
        }
    }
}
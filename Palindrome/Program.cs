using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Masukkan string Anda:");
        string input = Console.ReadLine();
        
        bool isPalindrome = IsPalindrome(input);
        string output = isPalindrome ? "Palindrome" : "Bukan Palindrome";

        Console.WriteLine($"Output: {output}");
    }

    static bool IsPalindrome(string word)
    {
        int i = 0;
        int j = word.Length - 1;

        while (i < j)
        {
            while (i < j && !char.IsLetterOrDigit(word[i])) i++;
            while (i < j && !char.IsLetterOrDigit(word[j])) j--;

            if (char.ToLower(word[i]) != char.ToLower(word[j]))
            {
                return false;
            }

            i++;
            j--;
        }

        return true;
    }
}

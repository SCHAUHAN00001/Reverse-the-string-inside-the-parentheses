using System;
using System.Text;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string result = ReverseStringsInParentheses(input);
        Console.WriteLine(result);
        Console.ReadLine();
    }

    static string ReverseStringsInParentheses(string input)
    {
        StringBuilder output = new StringBuilder();
        StringBuilder currentString = new StringBuilder();

        foreach (char c in input)
        {
            if (c == '(')
            {
                output.Append(currentString.ToString());
                currentString.Clear();
            }
            else if (c == ')')
            {
                char[] reversedString = currentString.ToString().ToCharArray();
                Array.Reverse(reversedString);
                output.Append(new string(reversedString));
                currentString.Clear();
            }
            else
            {
                currentString.Append(c);
            }
        }

        output.Append(currentString.ToString());
        return output.ToString();
    }
}


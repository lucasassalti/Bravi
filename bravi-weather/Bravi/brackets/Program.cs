using System;

namespace brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type some expression below: ");
            string brackets = Console.ReadLine();
            Console.WriteLine(CheckParentheses(brackets) ? "Is valid" : "Is not valid");
        }

    private static bool CheckParentheses(string input)
    {
         int brace = 0, square = 0, paren = 0;

        foreach(char c in input)
        {   //adjust sums
        if (c == '{') brace++;
        if (c == '}') brace--;
        if (c == '[') square++;
        if (c == ']') square--;
        if (c == '(') paren++;
        if (c == ')') paren--;

        //check for negatives (pair closes before it opens)
        if (brace < 0 || square < 0 || paren < 0) return false;
        }
    return (brace == 0 && square == 0 && paren == 0);
    }
    }
}

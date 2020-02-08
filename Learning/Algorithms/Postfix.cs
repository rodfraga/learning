using System;
using System.Collections.Generic;

namespace Learning.Algorithms
{
    public class Postfix
    {
        public string Convert(string infix)
        {
            string result = string.Empty;
            var stack = new Stack<char>();

            //
            for (int n = 0; n < infix.Length; n++)
            {
                if (infix[n] >= '0' && infix[n] <= '9')
                {
                    result += infix[n];
                }
                else
                {
                    while (stack.Count > 0 && Priority(stack.Peek(), infix[n]))
                    {
                        result += stack.Pop();
                    }

                    stack.Push(infix[n]);
                }
            }

            while (stack.Count > 0)
            {
                result += stack.Pop();
            }

            Console.WriteLine($"{infix} to postfix: {result}");

            return result;
        }

        bool Priority(char left, char right)
        {
            bool result = false;

            if (left == '*')
                result = true;

            if (left == '/')
            {
                if (right == '*')
                    result = false;
                else
                    result = true;
            }

            if (left == '+')
            {
                if (right == '*' || right == '/')
                    result = false;
                else
                    result = true;
            }

            if (left == '-')
                result = false;

            return result;
        }

    }
}

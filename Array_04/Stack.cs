using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_04
{
    internal class Stack
    {
        public bool RoundBrackets(string text)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '(')
                {
                    count++;
                }

                if (text[i] == ')')
                {
                    count--;
                    if (count < 0)
                        return false;
                }
            }
            if (count == 0)
                return true;
            else
                return false;
        }

        public bool Brackets(string text)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char s in text)
            {
                if (s == '(' || s == '[' || s == '{' || s == '<')
                {
                    stack.Push(s);
                }
                else if (stack.Count != 0 && s == FindClosingBracket(stack.Peek()))
                {
                    stack.Pop();
                }
                else if (s == ')' || s == ']' || s == '}' || s == '>')
                {
                    stack.Push(s);
                }
            }

            if (stack.Count == 0)
                return true;
            else
                return false;
        }

        private static char FindClosingBracket(char s)
        {
            if (s == '(')
                return ')';
            else if (s == '{')
                return '}';
            else if (s == '[')
                return ']';
            else
                return '>';
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionLibrary.Stacks
{
    //https://leetcode.com/problems/valid-parentheses/

    public class ValidParentheses
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                //If character is an openning parentheses, push onto the stack
                if (s[i] == '(' || s[i] == '[' || s[i] == '{')
                {
                    stack.Push(s[i]);
                }
                //If the character is a closing parentheses, and the stack is empty, s is not valid
                else if (stack.Count == 0)
                {
                    return false;
                }
                //If the character is a closing parentheses, and the top character of the stack is its
                //corresponding openning parentheses, pop the openning off the stack
                else if ((s[i] == ')' && stack.Peek() == '(') ||
                    (s[i] == ']' && stack.Peek() == '[') ||
                    (s[i] == '}' && stack.Peek() == '{'))
                {
                    stack.Pop();
                }
                //Else there is an invalid ordering of parentheses
                else return false;
            }

            //If the stack is not empty, there was in invalid ordering of parentheses
            return stack.Count == 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.puzzles
{
    /// <summary>
    /// https://www.interviewcake.com/question/bracket-validator
    /// You're working with an intern that keeps coming to you with JavaScript code that won't run because the braces, brackets, and parentheses are off. To save you both some time, you decide to write a braces/brackets/parentheses validator.
    /// Let's say:
    /// '(', '{', '[' are called "openers."
    /// ')', '}', ']' are called "closers."
    /// Write an efficient function that tells us whether or not an input string's openers and closers are properly nested.
    /// </summary>
    public class BracketValidator
    {
        public bool ParseBrackets(string sequenceOfBrackets)
        {
            var bracketPairs = new Dictionary<char, char>
            {
                {'(', ')'},
                {'{', '}'},
                {'[', ']'}
            };

            var stack = new Stack<char>();
            
            foreach (char bracket in sequenceOfBrackets)
            {
                if (bracketPairs.Keys.Contains(bracket))
                {
                    stack.Push(bracket);
                }
                else if (bracketPairs.Values.Contains(bracket))
                {
                    if (bracketPairs[stack.Pop()] != bracket)
                        return false;
                }
                else
                {
                    throw new Exception("Character is not an opening or closong bracket. ");
                }
            }

            return !bracketPairs.Any();
        }
    }
}
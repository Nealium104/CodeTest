﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    public static class Tester
    {
        /// <summary>
        /// Function that take a string and returns true if the string is a palindrome
        /// </summary>
        /// <param name="input">string</param>
        /// <returns>bool</returns>
        public static bool IsPalindrome(string input)
        {
            int leftPointer = 0;
            int rightPointer = input.Length - 1;

            while (leftPointer < rightPointer)
            {
                if (input[leftPointer] != input[rightPointer])
                {
                    return false;
                }
                leftPointer++;
                rightPointer--;
            }

            return true;
        }

        /// <summary>
        /// Function that takes a string and returns the count of each character in the string
        /// </summary>
        /// <param name="input">input string</param>
        /// <returns>Dictionary with each character from the string as the key and the count of each character as the value</returns>
        public static Dictionary<char, int> CharacterCount(string input)
        {
            Dictionary<char, int> output = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (!output.ContainsKey(c))
                {
                    output[c] = 1;
                } else
                {
                    output[c]++;
                }
            }
            return output;
        }


        /// <summary>
        /// Function that accepts two arrays of integers and returns an array of integers that are in both arrays.
        /// </summary>
        /// <param name="input1">an array of integers</param>
        /// <param name="input2">an array of integers</param>
        /// <returns>an array of integers</returns>
        public static int[] GetMatches(int[] input1, int[] input2)
        {
            int[] output =  new int[0];            

            return output;
        }


        /// <summary>
        /// Function that accepts two arrays of integers and returns an array of integers that are not in both arrays.
        /// </summary>
        /// <param name="input1">an array of integers</param>
        /// <param name="input2">an array of integers</param>
        /// <returns>an array of integers</returns>
        public static int[] GetDiff(int[] input1, int[] input2)
        {
            int[] output = new int[0];

            return output;
        }
    }
}

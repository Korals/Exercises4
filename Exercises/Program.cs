using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Feel free to test out your stuff below...");

            var result = FizzBuzz();
            foreach (var n in result)
                Console.WriteLine(n);
        }

        // Add PhpSucks to a string
        // Input: tacocat
        // Output: PhpSucks tacocat
        // Input: vilius
        // Output: PhpSucks vilius
        public static string AddPhpSucks(string someString)
        {

            if (string.IsNullOrWhiteSpace(someString)) return null;

            return "PhpSucks " + someString;
        }

        // Repeat given string by given amount of times
        // Input: 3, "ka"
        // Output: "kakaka"
        // Input: 2, "bybis "
        // Output: "bybis bybis "
        public static string RepeatGivenStringTimes(int repeatCount, string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return null;

            return string.Concat(Enumerable.Repeat(input,repeatCount));
        }

        // Check if given number is in given range
        // Input: 100, 69, 429
        // Output: true
        // Input: 13, 1, 10
        // Output: false
        // Input: 10, 10, 10
        // Output: true
        public static bool NumberIsInRange(int number, int from, int to)
        {
            return number >= from && number <= to;
        }

        // Remove braces from string
        // Input: "[Gays] Vithis"
        // Output: "Gays Vithis"
        // Input: "[Lol sudai]"
        // Output: "Lol sudai"
        // Input: "Kaka"
        // Output: "Kaka"
        public static string RemoveBracesFromString(string input)
        {
            if (input == null) return null;
            
            return input.Replace("[",string.Empty).Replace("]",string.Empty);
        }

        // Swap the first and last element places in array
        // Input: {1,2,5,3}
        // Output: {3,2,5,1}
        // Input: {5,3,7,8,4,2}
        // Output: {2,3,7,8,4,5}
        public static int[] SwapFirstAndLastElementsOfArray(int[] input)
        {
            if (input == null) return null;
            else if (input.Length > 0)
            {
                int temp = input[0];
                input[0] = input[^1];
                input[^1] = temp;
            }

            return input;
        }

        // Check how many times given number appears in given array
        // Input: {1,2,1,3,1,1}, 1
        // Output: 4
        // Input: {5,3,7,8,4,2,5}, 3
        // Output: 1
        public static int HowManyTimesValueInArray(int[] input, int value)
        {
            if (input == null) return 0;

            var result = 0;
            for (var i = 0; i < input.Length; i++)
            {
                if (input[i] == value) 
                    result ++;
            }

            return result;
        }

        // Write a program that prints the numbers from 1 to 100.
        // But for multiples of three print “Fizz” instead of the number and for the multiples of five print “Buzz”.
        // For numbers which are multiples of both three and five print “FizzBuzz”.
        public static string[] FizzBuzz()
        {
            var result = new[] {" "};
            for (var i = 0; i == 100; i++)
            {
                var temp3 = i % 3;
                var temp5 = i % 5;
                if (temp3 == 0 && temp5 == 0) result.SetValue("FizzBuzz", i);
                else if (temp3 == 0 && temp5 != 0) result.SetValue("Fizz", i);
                else if (temp3 != 0 && temp5 == 0) result.SetValue("Buzz", i);
                else result.SetValue(i.ToString(), i);
            }

            return result;
        }
    }
}
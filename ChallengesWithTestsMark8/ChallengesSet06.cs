using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool containsWord = false;
            if (words == null)
            {
                containsWord = false;
            }
            else
            {

                foreach (string w in words)
                {
                    try
                    {
                        if (w != null)
                        {
                            if (w == word)
                            {
                                containsWord = true;
                                break;

                            }
                            else if (ignoreCase == true && w.ToLower() == word)
                            {
                                containsWord = true;
                                break;
                            }
                        }
                    }
                    catch (NullReferenceException ex)
                    {
                        Console.WriteLine($"NullReferenceException: {ex.Message}");
                    }

                }
            }

            //"Object reference not set to an instance of an object
            return containsWord;
        }

        public bool IsPrimeNumber(int num)
        {
            
                bool isPrime = true;

                if (num <= 1)
                {
                    isPrime = false;
                }
                else
                {
                    for (int i = (num - 1); i > 1; i--)
                    {
                        if (num % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }

                return isPrime;
            }
        

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;
            bool doesContain;

                for (int i = 0; i < str.Length; i++)
                {
                    doesContain = true;

                    for (int j = 0; j < str.Length; j++)
                    {
                        if (str[i] == str[j] && i != j)
                        {
                            doesContain = false;
                        }
                    }
                    if (doesContain == true)
                    {
                        index = i;
                    }
                }
           

            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int maxCount = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int count = 1;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] != numbers[i])
                    {
                        break;
                    }
                    count++;
                }
                maxCount = (count > maxCount) ? count : maxCount;
            }

            return maxCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var nthDoubles = new List<double>();

            if (elements == null || n <= 0 || n > elements.Count)
            {
                return nthDoubles.ToArray();
            }

            for (var i = n - 1; i < elements.Count; i += n)
            {
                nthDoubles.Add(elements[i]);
                
            }

            return nthDoubles.ToArray();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            bool characterCheck = Char.IsLetter(c);
            return characterCheck;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            int count = 0;

            foreach (string i in vals) 
            {
                count ++;
            }

            bool countIsEven = (count % 2 == 0) ? true : false;
            return countIsEven;
        }

        public bool IsNumberEven(int number)
        {
            bool numberIsEven = (number % 2 == 0) ? true : false;
            return numberIsEven;
        }

        public bool IsNumberOdd(int num)
        {
            bool numberIsOdd = (num % 2 == 0) ? false : true;
            return numberIsOdd;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }

            return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            int strCount1 = str1.Length;
            int strCount2 = str2.Length;

            if(strCount1 <= strCount2)
            {
                return strCount1;
            }
            else //strCount1 > strCount2
            {
                return strCount2;
            }

        }

        public int Sum(int[] numbers)
        {
            int sum = 0;
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                foreach (int i in numbers)
                {
                    sum += i;
                }

                return sum;
            }
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;

            if (numbers == null)
            {
                return 0;
            }
            else
            {
                foreach (int i in numbers)
                {
                    if (i % 2 == 0)
                    {
                        sum += i;
                    }
                }

                return sum;
            }
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int sum = 0;

            if (numbers == null)
            {
                return false;
            }
            else
            {
                foreach (int i in numbers)
                {
                    sum += i;
                }

                bool sumIsOdd = (sum % 2 == 0) ? false : true;

                return sumIsOdd;
            }
        } 

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long count = 0;
            number -= 2;

            if (number % 2 == 0) //number is even
            {
                number += 1;
            }

            while (number > 0)
            {
                count += 1;
                number -= 2;
            }

            return count;

        }
    }
}

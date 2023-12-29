using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int result = 0;

            if (numbers == null)
            {
                return 0;
            }

            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    result += numbers[i];
                } else //is odd
                {
                    result -= numbers[i];
                }
            }
            return result;

            
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int[] lengths = new int[4] {str1.Length, str2.Length, str3.Length, str4.Length};
            
            return lengths.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] numbers = new int[4] {number1, number2, number3, number4};

            return numbers.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            bool isTriangle = ((sideLength1 + sideLength2 > sideLength3) && (sideLength2 + sideLength3 > sideLength1) && (sideLength1 + sideLength3 > sideLength2)) ? true : false;
            return isTriangle;
        }

        public bool IsStringANumber(string input)
        {
            bool result = int.TryParse(input, out int i);
            if (result == true)
            {
                return true;
            }

            result = double.TryParse(input, out double d);
            if (result == true)
            {
                return true;
            }

            result = decimal.TryParse(input, out decimal m);
            if (result == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var nulls = objs.Where(x => x == null).Count();
            bool result = (nulls > (objs.Length / 2)) ? true : false;

            return result;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
                var evens = numbers.Where(x => x % 2 == 0);
                if (evens.Count() == 0)
                {
                    return 0;
                }
                    double average = evens.Average();
                    return average;
                
        }

        public int Factorial(int number)
        {
            int factor = 1;

            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            while (number > 1)
            {
                factor *= number;
                number--;
            }

            return factor;
        }
    }
}

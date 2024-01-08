using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            startNumber += 1;

            while (startNumber % n !=0)
            {
                startNumber++;
            }

            return startNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business b in businesses)
            {
                if (b.TotalRevenue == 0)
                {
                    b.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            bool isAscending = true;
            
            if (numbers == null || numbers.Length <= 0)
            {
                return false;
            }

            for (int i=1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    isAscending = false;
                    break;
                }
            }

            return isAscending;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            
            int sum = 0;

            if (numbers == null || numbers.Length <= 0)
            {
                return sum;
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i-1] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }

            return sum;


        }

        public string TurnWordsIntoSentence(string[] words)
        {
            string sentence = "";
            if (words == null || words.Length == 0)
            {
                return sentence;
            }
            else
            {
                foreach (string w in words)
                {

                    if (w.Trim().Length > 0)
                    {
                        sentence += w.Trim() + " ";
                    }

                }

                if (sentence.Length == 0)
                {
                    return "";
                }

                sentence = sentence.Trim();
                return sentence += ".";
            }
        }

    

        public double[] GetEveryFourthElement(List<double> elements)
        {
            List<double> fourthElements = new List<double>();

            if (elements == null || elements.Count == 0)
            {
                return new double[0];
            }

            for(int i = 3; i < elements.Count; i += 4)
            {
                fourthElements.Add(elements[i]);
            }

            if (fourthElements.Count == 0)
            {
                return new double[0];
            }

            return fourthElements.ToArray();


        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            bool canSum = false;

            if (nums == null || nums.Length == 0 || targetNumber == null)
            {
                return canSum;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber && i != j)
                    {
                        canSum = true;
                        break;
                    }
                }
            }

            return canSum;
        }
    }
}

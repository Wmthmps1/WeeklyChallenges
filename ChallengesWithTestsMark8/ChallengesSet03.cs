using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            bool boolValue;

            if (vals == null)
            {
                return false;
            }
            else
            {
                foreach(bool i in vals)
                {
                    if (i == false)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            throw new NotImplementedException();
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool hasUpperCase = false; 
            bool hasLowerCase = false;
            bool hasNumber = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsUpper(password[i])){
                    hasUpperCase = true;
                }
                if (char.IsLower(password[i]))
                {
                    hasLowerCase = true;
                }
                if (char.IsNumber(password[i]))
                {
                    hasNumber = true;
                }
            }

            if (hasUpperCase && hasLowerCase && hasNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if(divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            if (nums == null)
            {
                return 0;
            }
            else
            {
                return nums[nums.Length - 1] - nums[0];
            }
        }
        
        public int[] GetOddsBelow100()
        {
            var odds = new List<int>();

            for(int i = 101; i > 0; i-= 2)
            {
                odds.Add(i);
            }

            int[] oddsArray = odds.ToArray();
            return oddsArray;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
                words[i] = words[i].ToUpper();

        }
    }
}

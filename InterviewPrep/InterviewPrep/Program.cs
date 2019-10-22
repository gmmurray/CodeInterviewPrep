using System;

namespace InterviewPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int[] result = TwoSum(nums, target);
            foreach(var x in result)
            {
                Console.WriteLine(x);
            }
           


           
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            int sum;
            int[] result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length - 1; j++)
                {
                    sum = nums[i] + nums[j];
                    if (sum == target)
                    {
                        result[0] = i;
                        result[1] = j;
                        return result;
                    }
                }
            }
            result[0] = -1;
            result[1] = -1;
            return result;
        }
    }

    class Solution
    {
       
    }
}

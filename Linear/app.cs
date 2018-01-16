using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear
{
    class App
    {
        static void Main(string[] args)
        {
            LongestSubsequence();
        }

        private static void LongestSubsequence()
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int index = 0;
            int maxStartIndex = -1;
            int maxEndIndex = -1;
            int maxCount = -1;
            int endIndex = -1;
            while (index < nums.Count && endIndex < nums.Count - 1)
            {
                int currentNum = nums[index];
                for (int i = index + 1; i < nums.Count; i++)
                {
                    if (nums[i] != currentNum)
                    {
                        endIndex = i;
                        break;
                    }
                    else if (i == nums.Count - 1)
                    {
                        endIndex = nums.Count;
                    }
                }
                if (endIndex - index > maxCount)
                {
                    maxStartIndex = index;
                    maxEndIndex = endIndex;
                    maxCount = endIndex - index;
                }
                index = endIndex;
            }

            Console.WriteLine(string.Join(" ", nums.Skip(maxStartIndex).Take(maxCount)));
        }
    }
}

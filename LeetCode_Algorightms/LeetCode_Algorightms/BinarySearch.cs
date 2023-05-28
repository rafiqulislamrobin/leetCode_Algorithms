using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Algorightms
{
    public static class BinarySearch
    {
        public static int Search(int[] nums, int target)
        {

            var left = 0;
            var right = nums.Length - 1;

            while (left <= right)
            {
                var middle = (left + right) / 2;
                if (nums[middle] == target)
                {
                    return middle;
                }
                else if (nums[middle] < target)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }

            return -1;
        }
    }
}

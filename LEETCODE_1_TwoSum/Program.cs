string input = Console.ReadLine();

int[] nums = Array.ConvertAll(input.Split(' '), int.Parse);
int target = int.Parse(Console.ReadLine());

Solution solution = new Solution();

int[] result = solution.TwoSum(nums, target);
foreach (var item in result)
{
    Console.Write("Index:" + item + " ");
}

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        // check if target is less than 0
        if (nums.Length < 0)
        {
            Console.WriteLine("Invalid input, check your array or target again");

            // return 0, 0 if target or nums is less than 0
            return new int[] { 0, 0 };
        }

        // loop through the array
        for (int i = 0; i < nums.Length; i++)
        {
            // if i is greater than target, skip
            if (nums[i] > target)
            {
                continue;
            }

            for (int x = 1; x < nums.Length; x++)
            {
                // chack to make sure i and x are not the same
                if (i != x)
                {
                    // if nums[i] + nums[x] is equal to target, return the indexes
                    if (nums[i] + nums[x] == target)
                    {
                        // return the indexes
                        return new int[] { i, x };
                    }

                }
            }
        }

            // if no 2 numbers in given array equal target
            Console.WriteLine("No 2 numbers in given array equal {0}", target);

            // return 0, 0 if no 2 numbers in given array equal target
            return new int[] { 0, 0 };
        
    }
}
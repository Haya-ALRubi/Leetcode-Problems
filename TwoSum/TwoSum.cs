public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int n = i + 1; n < nums.Length; n++)
            {
                if (nums[i] + nums[n] == target)
                {
                    return new int[] { i, n };
                }
            }
        }
        return new int[0];
    }


}
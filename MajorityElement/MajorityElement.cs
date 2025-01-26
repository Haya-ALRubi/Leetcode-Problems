public class Solution
{
    public int MajorityElement(int[] nums)
    {
        int count = 0;
        int element = 1;
        foreach (int num in nums)
        {
            if (count == 0) { element = num; }
            if (element == num) { count++; }
            else count--;

        }
        return element;

    }
}
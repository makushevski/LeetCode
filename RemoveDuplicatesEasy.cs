namespace LeetCode
{
	/*
	 Given a sorted array nums, remove the duplicates in-place such that each element appears only once and returns the new length.
		Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.

		Given nums = [0,0,1,1,1,2,2,3,3,4],

		Your function should return length = 5, with the first five elements of nums being modified to 0, 1, 2, 3, and 4 respectively.
		It doesn't matter what values are set beyond the returned length.
	 */

	public class RemoveDuplicatesEasy
	{
		public static int RemoveDuplicates(int[] nums)
		{
			if (nums.Length == 0)
				return 0;
			int j = 0;
			for (int i = 1; i < nums.Length; i++)
			{
				if (nums[j] != nums[i])
				{
					nums[j + 1] = nums[i];
					j++;
				}
			}
			return j + 1;
		}
	}
}
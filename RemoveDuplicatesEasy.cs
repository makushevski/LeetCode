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
			if (nums.Length == 1)
			{
				return 1;
			}
			for (int i = 0; i < nums.Length - 1; i++)
			{
				var current = nums[i];
				var index = i + 1;
				while (index < nums.Length && current == nums[index])
				{
					nums[index] = int.MaxValue;
					index++;
				}
			}

			Sort(nums);
			var length = nums.Length;
			for (int i = 0; i < nums.Length; i++)
			{
				if (nums[i] == int.MaxValue)
				{
					return i;
				}
			}

			return length;
		}

		private static void Sort(int[] nums)
		{
			for (int i = 0; i < nums.Length; i++)
			for (int j = 0; j < nums.Length; j++)
			{
				if (nums[j] > nums[i])
				{
					var temp = nums[i];
					nums[i] = nums[j];
					nums[j] = temp;
				}
			}
		}
	}
}
﻿using System;
using System.Collections.Generic;

namespace MyMath
{
	/// <summary>
	/// Contains operations for working with a list of integers.
	/// </summary>
	public static class Operations
	{
		/// <summary>
		/// Finds the maximum integer in a list of integers.
		/// </summary>
		/// <param name="nums">A list of integers.</param>
		/// <returns>The maximum integer in the list, or 0 if the list is empty.</returns>
		public static int Max(List<int> nums)
		{
			if (nums == null || nums.Count == 0)
			{
				return 0;
			}

			int max = nums[0];
			foreach (int num in nums)
			{
				if (num > max)
				{
					max = num;
				}
			}

			return max;
		}
	}
}
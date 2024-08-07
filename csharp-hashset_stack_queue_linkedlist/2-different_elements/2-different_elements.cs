using System;
using System.Collections.Generic;

class List
{
	public static List<int> DifferentElements(List<int> list1, List<int> list2)
	{
		HashSet<int> set1 = new HashSet<int>(list1);
		HashSet<int> set2 = new HashSet<int>(list2);
	       	HashSet<int> uniqueSet = new HashSet<int>();

		foreach (int num in list1)
		{
			if (!set2.Contains(num))
			{
				uniqueSet.Add(num);
			}
		}

		foreach (int num in list2)
		{
			if (!set1.Contains(num))
			{
				uniqueSet.Add(num);
			}
		}

		List<int> differentList = new List<int>(uniqueSet);
		differentList.Sort(); // Manual sorting can also be implemented if required

		return differentList;
	}
}

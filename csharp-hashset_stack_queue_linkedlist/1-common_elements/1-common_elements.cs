using System;
using System.Collections.Generic;

class List
{
	public static List<int> CommonElements(List<int> list1, List<int> list2)
	{
		HashSet<int> set1 = new HashSet<int>(list1);
		HashSet<int> commonSet = new HashSet<int>();
		
		foreach (int num in list2)
		{
			if (set1.Contains(num))
			{
				commonSet.Add(num);
			}
		}
		
		List<int> commonList = new List<int>(commonSet);
		commonList.Sort(); // Manual sorting can also be implemented if required

		return commonList;
	}
}

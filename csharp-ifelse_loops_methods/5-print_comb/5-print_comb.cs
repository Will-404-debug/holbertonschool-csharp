using System;

class Program
{
	static void Main(string[] args)
	{
		for (int i = 0; i <= 99; i++)
		{
			if (i < 99)
			{
				Console.Write($"{i:00}, ");
			}
			else
			{
				Console.WriteLine($"{i:00}");
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_MaxContinuousValue
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//陣列裡只會有0、3，找出連續3數的總和
			int[] arr = { 0, 3, 3, 0, 0, 0, 3 };
			Console.WriteLine(maxValue(arr));

		}
		static int maxValue(int[] arr)
		{
			int counter = 0;
			int sum = 0;
			for (int i = 2; i < arr.Length; i++)
			{
				sum = arr[i] + arr[i - 1] + arr[i - 2];
				if (sum > counter)
				{
					counter = sum;
				}
			}
			return counter;
		}
	}
}

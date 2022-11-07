using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> list = new List<int>() { 1, 5, 32, 45, 12, 45, 78, 96, 23 };
			List<int> evenList = GetEvenItems(list, i => i % 2 == 0);

			// Even
			foreach(int item in evenList)
			{
				Console.WriteLine(item);
			}
		}

		static List<int> GetEvenItems(List<int> source, Func<int, bool> func)
		{
			List<int> result = new List<int>();
			for(int i = 0; i < source.Count; i++)
			{
				if(func(source[i]))
					result.Add(source[i]);
			}
			return result;
		}
	}
}

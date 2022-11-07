using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	//Int32.IsOdd,IsEven
	internal class Program
	{
		static void Main(string[] args)
		{
			
		}

	}
	public static class IntExtensions
	{
		public static bool IsOdd(this int num)
		{
			return num % 2 == 0;
		}
		public static bool IsEven(this int num)
		{
			return num % 2 == 1;
		}
	}


}

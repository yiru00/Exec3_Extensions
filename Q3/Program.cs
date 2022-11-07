using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
		}
		static public class StringExtensions
		{
			static public int ToInt(this string value,int defaultValue)
			{
				bool isInt = int.TryParse(value, out int result);
				return isInt?result: defaultValue;
			}
		}
	}
}

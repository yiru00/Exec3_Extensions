using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
		}
	}
	static public class StringExtension
	{
		static public string Left(this string input, int length)
		{
			if (string.IsNullOrEmpty(input)) return "";
			if (input.Length == 0) return "";
			if (input.Length < length) return input;
			return input.Substring(0, length);
		}
	}
}

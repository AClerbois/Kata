using System;

namespace AClerbois.Kata
{
	public class Diamond
	{
		public static void Main()
		{
			var n = 9;
			for (int i = 1; i <= (n * 2); i++)
			{
				var rest = i < n ? n - i : i - n;
				Console.Write(new string (' ', rest));
				for (int j = 1; j <= n - rest; Console.Write(j++))
					;
				for (int k = n - rest - 1; k >= 1; Console.Write(k--))
					;
				Console.WriteLine("");
			}
		}
	}
}

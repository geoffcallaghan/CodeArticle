using System;
using Helpers;

namespace HelloWorld
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Console.WriteLine(GreetingsHelper.Greeting(Language.Australian));
			Console.ReadLine();
		}
	}
}
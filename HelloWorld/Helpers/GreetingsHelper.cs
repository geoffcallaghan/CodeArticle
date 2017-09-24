namespace Helpers
{
	public static class GreetingsHelper
	{
		public static string Greeting(Language language)
		{
			switch (language)
			{
				case Language.American:
				return "Hello World";

				case Language.Australian:
				return "G'day Mate!";

				case Language.Spanish:
				return "Hola!";

				default:
				return "Unknown language!";
			}
		}
	}

	public enum Language
	{
		American,
		Australian,
		Spanish
	}
}

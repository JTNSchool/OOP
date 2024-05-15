using System;

namespace PokemonWorld
{
	public class Functions
	{
        public static string AskString(string Question)
        {
            while (true)
            {
                Console.WriteLine(Question);
                string? UserInput = Console.ReadLine()!.ToLower();
                if (!string.IsNullOrEmpty(UserInput) ) 
                {return UserInput; }
            }
        }
        public static bool AskYesOrNoQuestion(string Question)
        {

            var UserInput = AskQuestion(Question, ["y", "yes", "n", "no"]);

			return new string[] { "y", "yes" }.Contains(UserInput);
        }
        public static string AskQuestion(string Question, string[] Awsners)
		{
			while (true)
			{
				Console.WriteLine(Question);
				string? UserInput = Console.ReadLine()!.ToLower();
				if (Awsners.Contains(UserInput)) 
				{ return UserInput;  }
			}
		}

    }
}

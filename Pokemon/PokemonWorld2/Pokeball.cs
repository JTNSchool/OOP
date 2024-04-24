using System;

namespace PokemonWorld
{
	public class PokeBall
	{
		public string PokemonInPokeball = null;
		public bool IsOutsideOfPokeBall = false;

		//public PokeBall() { }

		public void CatchPokemon(string Pokemon)
		{
			if (this.PokemonInPokeball == null)
			{
				PokemonInPokeball = Pokemon;
                Console.WriteLine($"You Catched a {Pokemon}");
			}
			else
			{ Console.WriteLine("You already have a pokemon in this pokeball"); }
		}

		public void ThrowPokeball()
		{
			if (this.PokemonInPokeball != null)
			{
				if (!this.IsOutsideOfPokeBall)
				{
					this.IsOutsideOfPokeBall = true;
                    Console.WriteLine($"You threw your pokeball and {this.PokemonInPokeball} came out");
				}
				else
				{ Console.WriteLine("Your pokemon is already outside the pokeball"); }
			}
			else
			{ Console.WriteLine("You dont have a pokemon in this pokeball"); }
		}

		public void RetrievePokemon()
		{
            if (this.PokemonInPokeball != null)
            {
                if (this.IsOutsideOfPokeBall)
                {
                    this.IsOutsideOfPokeBall = false;
                    Console.WriteLine($"You retrieved your {this.PokemonInPokeball}");
                }
                else
                { Console.WriteLine("Your pokemon is already inside of the pokeball"); }
            }
            else
            { Console.WriteLine("You dont have a pokemon for this pokeball"); }
        }





    }
}

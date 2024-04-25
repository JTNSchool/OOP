using System;

namespace PokemonWorld
{
	public class PokeBall
	{
		public Charmander PokemonInPokeball;
        private bool IsOutsideOfPokeBall = false;

		public PokeBall(Charmander charmander) { PokemonInPokeball = charmander; }

		public Charmander? ThrowPokeball()
		{
			if (this.PokemonInPokeball != null)
			{
				if (!this.IsOutsideOfPokeBall)
				{
					this.IsOutsideOfPokeBall = true;
                    Console.WriteLine($"{this.PokemonInPokeball.Name} came out");
				}
				else
				{ Console.WriteLine("Your pokemon is already outside the pokeball"); }
				return PokemonInPokeball;
            }
			else
			{ 
				Console.WriteLine("You dont have a pokemon in this pokeball");
				return null;

			}
		}

		public void RetrievePokemon()
		{
            if (this.PokemonInPokeball != null)
            {
                if (this.IsOutsideOfPokeBall)
                {
                    this.IsOutsideOfPokeBall = false;
                    Console.WriteLine($"{this.PokemonInPokeball.Name} went back to the pokeball");
                }
                else
                { Console.WriteLine("Your pokemon is already inside of the pokeball"); }
            }
            else
            { Console.WriteLine("You dont have a pokemon for this pokeball"); }
        }





    }
}

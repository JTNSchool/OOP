using System;

namespace PokemonWorld
{
	public class Trainer
	{
		public readonly string Name;
		public readonly List<PokeBall> Belt;

		public Trainer(string Username)
        {
            Name = Username;
            //Pokeball = new(new charmanders)
            Belt = [new(new Charmander()), new(new Charmander()), new(new Squirtel()) , new(new Squirtel()), new(new Bullbasaur()), new(new Bullbasaur())];
            foreach (PokeBall pokeball in Belt)
            {
                pokeball.PokemonInPokeball.Name = $"{Username}'s {pokeball.PokemonInPokeball.Name}";
            }
        }

        public void RetrievePokemon(int index)
        {
            Belt[index].RetrievePokemon();
        }

        private Pokemon? SendOutPokemon(int index)
        {
            if (this.Belt.Count <= index) { throw new Exception(); }
            return Belt[index].ThrowPokeball();
        }

        public Pokemon? TrySendOutPokemon(int index)
        {
            try
            {
                return SendOutPokemon(index);
            }
            catch (Exception)
            {
                Console.WriteLine("Index out of range for sending out a Pokemon");
                return null;
            }
 
        }

        





    }
}

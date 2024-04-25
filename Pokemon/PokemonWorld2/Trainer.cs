using System;

namespace PokemonWorld
{
	public class Trainer
	{
		public readonly string Name;
		private readonly List<PokeBall> Belt;

		public Trainer(string Username)
        {
            Name = Username;
            Belt = [new(new Charmander()), new(new Charmander()), new(new Charmander()) , new(new Charmander()), new(new Charmander()), new(new Charmander())];
            foreach (PokeBall pokeball in Belt)
            {
                pokeball.PokemonInPokeball.Name = $"{Username}'s Charmander";
            }
        }

        public void RetrievePokemon(int index)
        {
            Belt[index].RetrievePokemon();
        }

        private Charmander? SendOutPokemon(int index)
        {
            if (this.Belt.Count <= index) { throw new Exception(); }
            return Belt[index].ThrowPokeball();
        }

        public Charmander? TrySendOutPokemon(int index)
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

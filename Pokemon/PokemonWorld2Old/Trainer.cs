using System;

namespace PokemonWorld
{
	public class Trainer
	{
		public readonly string Name;
		public readonly List<dynamic> Pokemons;

		public Trainer(string Username, string[] PokemonList)
        {
            Name = Username;
            Pokemons = CreatePokemonList(PokemonList);
        }

        public List<object> CreatePokemonList(string[] PokemonList)
            {
            var PokeBelt = new List<object>();
            if (PokemonList.Length > 6 ) { throw new Exception("You can only maximum amount of 6 pokemons"); }
            foreach (string Pokemon in PokemonList)
            {
                var Ball = new PokeBall(this.Name);
                switch (Pokemon)
                {
                    case "Charmander":
                        Ball.CatchPokemon(new Charmander());
                        break;
                }
                PokeBelt.Add(Ball);
            }
           return PokeBelt;
        }
        private void SendOutPokemon(int index)
        {
            //Iets moet fout gaan zodat ik kan catchen
            if (this.Pokemons.Count <= index) { throw new Exception(); }



        }

        public bool TrySendOutPokemon(int index)
        {
            try
            {
                SendOutPokemon(index);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
 
        }

        





    }
}

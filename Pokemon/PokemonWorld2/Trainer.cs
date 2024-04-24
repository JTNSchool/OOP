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

        public static List<object> CreatePokemonList(string[] PokemonList)
            {
            var NewPokemonList = new List<object>();
            if (PokemonList.Length > 6 ) { throw new Exception("You can only maximum amount of 6 pokemons"); }
            foreach (string Pokemon in PokemonList)
            {
                switch (Pokemon)
                {
                    case "Charmander":
                        NewPokemonList.Add(new Charmander());
                        break;
                }
            }
           return NewPokemonList;
        }
        public void SendOutPokemon(int index)
        {
            //Iets moet fout gaan zodat ik kan catchen

        }

        





    }
}

using System;

namespace PokemonWorld
{
	public class Trainer
	{
		private string Name;
		private string[] Pokemons;

		public Trainer(string Username, string[] PokemonList)
        {
            Name = Username;
            Pokemons = PokemonList;
        }

        public List<Object> CreatePokemonList(string[] PokemonList)
            {
            List<object> NewPokemonList = new List<object>();
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

        }

        





    }
}

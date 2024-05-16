using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PokemonWorld
{
    public class Battle
    {
        static readonly Random random = new();

        //Creation of a object



        public static PokeBall? GetRandomPokeball(Trainer trainer)
        {
            //Check if all pokemons are unable to fight
            List<PokeBall> AvailablePokemons = [];
            foreach (PokeBall Ball in trainer.Belt)
            {
                if (Ball.PokemonInPokeball.Status == "Alive") 
                {
                    AvailablePokemons.Add(Ball);
                }
            }

            //return -1 if out of pokemons
            if (AvailablePokemons.Count <= 0) { Console.WriteLine($"{trainer.Name} Is out of Pokemons"); return null; }

            PokeBall RandomPokeball = AvailablePokemons[ random.Next(0, AvailablePokemons.Count-1) ];
            return RandomPokeball;
        }

        public static int GetWinner(Pokemon Pokemon1, Pokemon Pokemon2)
        {
            // 0=Draw | 1=Pokemon1 won | 2= Pokemon2 won
            Pokemon.Type TypeOfPokemon1 = Pokemon1.type;
            Pokemon.Type TypeOfPokemon2 = Pokemon2.type;


            switch (TypeOfPokemon1)
            {
                case Pokemon.Type.Fire:
                    if (TypeOfPokemon2 == Pokemon.Type.Fire) { return 0; }
                    if (TypeOfPokemon2 == Pokemon.Type.Grass) { return 1; }
                    if (TypeOfPokemon2 == Pokemon.Type.Water) { return 2; }
                    break;
                case Pokemon.Type.Water:
                    if (TypeOfPokemon2 == Pokemon.Type.Fire) { return 1; }
                    if (TypeOfPokemon2 == Pokemon.Type.Grass) { return 2; }
                    if (TypeOfPokemon2 == Pokemon.Type.Water) { return 0; }
                    break;
                case Pokemon.Type.Grass:
                    if (TypeOfPokemon2 == Pokemon.Type.Fire) { return 2; }
                    if (TypeOfPokemon2 == Pokemon.Type.Grass) { return 0; }
                    if (TypeOfPokemon2 == Pokemon.Type.Water) { return 1; }
                    break;
            }
            return 3;
        }


       

        public static void DefeatPokemon(PokeBall Pokemon)
        {
            Pokemon.RetrievePokemon();
            Pokemon.PokemonInPokeball.Status = "Fainted";
        }



    }
}

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
        Trainer Trainer1;
        Trainer Trainer2;
        static Random random = new();

        //Creation of a object
        public Battle(Trainer trainer1, Trainer trainer2)
        {
            Trainer1 = trainer1;
            Trainer2 = trainer2;
        }


        public PokeBall GetRandomPokeball(Trainer trainer)
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
            if (AvailablePokemons.Count <= 0) { Console.WriteLine($"{trainer.Name} Is out of Pokemons"); new Exception(); }

            
            PokeBall RandomPokeball = AvailablePokemons[ random.Next(0, AvailablePokemons.Count-1) ];
            return RandomPokeball;
        }

        public int GetWinner(Pokemon Pokemon1, Pokemon Pokemon2)
        {
            // 0=Draw | 1=Pokemon1 won | 2= Pokemon2 won
            string TypeOfPokemon1 = Pokemon1.Type;
            string TypeOfPokemon2 = Pokemon2.Type;

            if (TypeOfPokemon1 == null || TypeOfPokemon2 == null) {   Console.WriteLine("Battle Error! one of the pokemons has no type"); throw new Exception(); }

            switch (TypeOfPokemon1)
            {
                case "Fire":
                    if (TypeOfPokemon2 == "Fire") { return 0; }
                    if (TypeOfPokemon2 == "Grass") { return 1; }
                    if (TypeOfPokemon2 == "Water") { return 2; }
                    break;
                case "Water":
                    if (TypeOfPokemon2 == "Fire") { return 1; }
                    if (TypeOfPokemon2 == "Grass") { return 2; }
                    if (TypeOfPokemon2 == "Water") { return 0; }
                    break;
                case "Grass":
                    if (TypeOfPokemon2 == "Fire") { return 2; }
                    if (TypeOfPokemon2 == "Grass") { return 0; }
                    if (TypeOfPokemon2 == "Water") { return 1; }
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

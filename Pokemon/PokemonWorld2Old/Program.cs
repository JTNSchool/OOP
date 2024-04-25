using System;

namespace PokemonWorld
{

    class Program
    {
        static void Main()
        {
            while (true)
            {
                //Ask the user if he wants to play
                if (!Functions.AskYesOrNoQuestion("Do you want to play?")) { break; }

                //Create 2 trainers
                var TrainerPokemons = new string[] { "Charmander", "Charmander", "Charmander", "Charmander", "Charmander", "Charmander" };

                var Trainer1Name = Functions.AskString("what is the name of the Trainer 1");
                var Trainer1 = new Trainer(Trainer1Name, TrainerPokemons);

                var Trainer2Name = Functions.AskString("what is the name of the Trainer 2");
                var Trainer2 = new Trainer(Trainer2Name, TrainerPokemons);

                Trainer1.TrySendOutPokemon(9);
                Console.WriteLine(Trainer1.Pokemons);

                for (int i = 0; i < TrainerPokemons.Length; i++) { }
                {
                    Console.WriteLine("s");
                }


            }
        }
    }
}
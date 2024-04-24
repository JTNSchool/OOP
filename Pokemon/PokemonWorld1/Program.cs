using System;

namespace PokemonWorld1
{

    class Program
    {
        static void Main(string[] args)
        {
            var StarterPokemon = new Charmander();
            //The player gives a name to a charmander.
            StarterPokemon.ChangeName();
            //The charmander does its battle cry for ten times.
            for (int i = 0; i < 10; i++)
            {
                StarterPokemon.BattleCry();
            }

            //Infinite loop until user closes console
            while (true)
            {
                //The player can give a new name to the same charmander.
                StarterPokemon.ChangeName();
                //The charmander does its battle cry for ten times.
                for (int i = 0; i < 10; i++)
                {
                    StarterPokemon.BattleCry();
                }
            }



        }
    }
}
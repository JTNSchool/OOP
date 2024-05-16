using System;

namespace PokemonWorld
{

    class Program
    {
        static void Main()
        {
            Trainer Trainer1 = new("Henk");
            Trainer Trainer2 = new("Jan");

            Arena.SetTrainers(Trainer1, Trainer2);

            Arena.StartBattle();
        }
    }
}
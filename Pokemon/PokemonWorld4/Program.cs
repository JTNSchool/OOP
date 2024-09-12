using System;

namespace PokemonWorld
{

    class Program
    {
        static void Main()
        {
            Trainer Trainer1 = new Trainer("Henk");
            Trainer Trainer2 = new Trainer("Jan");

       

            Arena.SetTrainers(Trainer1, Trainer2);

            Arena.StartBattle();
        }
    }
}
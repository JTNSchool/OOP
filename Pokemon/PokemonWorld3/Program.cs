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
                var Trainer1Name = Functions.AskString("what is the name of the Trainer 1");
                var Trainer1 = new Trainer(Trainer1Name);

                var Trainer2Name = Functions.AskString("what is the name of the Trainer 2");
                var Trainer2 = new Trainer(Trainer2Name);

                for (int i = 0; i < 6; i++) 
                {
                    Pokemon? Trainer1charmander = Trainer1.TrySendOutPokemon(i);
                    if (Trainer1charmander == null) { break; }
                    Trainer1charmander.BattleCry();

                    Pokemon? Trainer2charmander = Trainer2.TrySendOutPokemon(i);
                    if (Trainer2charmander == null) { break; }
                    Trainer2charmander.BattleCry();

                    Trainer1.RetrievePokemon(i);
                    Trainer2.RetrievePokemon(i);





                }

            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PokemonWorld
{
    public class Arena
    {
        //Static belong class not object Arena. <Object>
        static int CurrentBattleRounds;
        static int Battles;
        static Trainer Trainer1;
        static Trainer Trainer2;
        static Battle CurrentBattle;
        static PokeBall? WinnerOfLastRound;
        static Trainer? TrainerWinnerOfLastRound;

        //Creation of a object

        public static void SetTrainers(Trainer t1, Trainer t2)
        {
            Trainer1 = t1;
            Trainer2 = t2;
        }

        public static void StartBattle()
        {
            CurrentBattle = new Battle(Trainer1, Trainer2);

            int Loops = Trainer1.Belt.Count;
            if (Trainer2.Belt.Count >= Trainer1.Belt.Count) { Loops = Trainer2.Belt.Count; }

            for (int Round = 1; Round <= Loops; Round++)
            {
                PlayRound(Round);
            }
        }


        private static void PlayRound(int Round)
        {
            
            Console.WriteLine();
            Console.WriteLine($"Round {Round}");

            PokeBall PokemonOfTrainer1 = CurrentBattle.GetRandomPokeball(Trainer1); ;
            PokeBall PokemonOfTrainer2 = CurrentBattle.GetRandomPokeball(Trainer2); ;

            if (TrainerWinnerOfLastRound != Trainer1) 
            {
                PokemonOfTrainer1 = CurrentBattle.GetRandomPokeball(Trainer1);
                PokemonOfTrainer1.ThrowPokeball();
            }
            else
            {
                Console.WriteLine($"{PokemonOfTrainer1.PokemonInPokeball.Name} Is still standing!");
            }
            if (TrainerWinnerOfLastRound != Trainer2)
            {
                PokemonOfTrainer2 = CurrentBattle.GetRandomPokeball(Trainer2);
                PokemonOfTrainer2.ThrowPokeball();
            }
            else
            {
                Console.WriteLine($"{PokemonOfTrainer2.PokemonInPokeball.Name} Is still standing!");
            }


            // 0=Draw | 1=Pokemon1 won | 2= Pokemon2 won | 3= error
            int Winner = CurrentBattle.GetWinner(PokemonOfTrainer1.PokemonInPokeball, PokemonOfTrainer2.PokemonInPokeball);
            
            switch (Winner)
            {
                case 0:
                    Console.WriteLine("It is a draw!");
                    if (CurrentBattleRounds == 1)
                    {
                        Battle.DefeatPokemon(PokemonOfTrainer1);
                        Battle.DefeatPokemon(PokemonOfTrainer2);
                    }
                    else 
                    { 
                        if (WinnerOfLastRound != null) 
                        { 
                            Battle.DefeatPokemon(WinnerOfLastRound);
                            WinnerOfLastRound = null;
                            TrainerWinnerOfLastRound = null;
                        } 
                    }
                
                    break;

                case 1:
                    Console.WriteLine($"{PokemonOfTrainer1.PokemonInPokeball.Name} Won this round!");
                    Battle.DefeatPokemon(PokemonOfTrainer2);
                    if (WinnerOfLastRound == PokemonOfTrainer1) 
                    { 
                        Battle.DefeatPokemon(PokemonOfTrainer1);
                        WinnerOfLastRound = null;
                        TrainerWinnerOfLastRound = null;
                    }
                    else 
                    { 
                        WinnerOfLastRound = PokemonOfTrainer1;
                        TrainerWinnerOfLastRound = Trainer1;
                    }
                    break;

                case 2:
                    Console.WriteLine($"{PokemonOfTrainer2.PokemonInPokeball.Name} Won this round!");
                    Battle.DefeatPokemon(PokemonOfTrainer1);
                    if (WinnerOfLastRound == PokemonOfTrainer2)
                    {
                        Battle.DefeatPokemon(PokemonOfTrainer2);
                        WinnerOfLastRound = null;
                        TrainerWinnerOfLastRound = null;
                    }
                    else 
                    { 
                        WinnerOfLastRound = PokemonOfTrainer2;
                        TrainerWinnerOfLastRound = Trainer2;
                    }
                    break;
            }


        }









    }
}

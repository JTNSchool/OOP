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
        static Trainer? Trainer1;
        static Trainer? Trainer2;
        static Battle? CurrentBattle;
        static PokeBall? WinnerOfLastRound;
        static Trainer? TrainerWinnerOfLastRound;

        //Deze 2 moeten gemaakt worden maar 1 keer
        static PokeBall? PokemonOfTrainer1;
        static PokeBall? PokemonOfTrainer2;

        //Creation of a object

        public static void SetTrainers(Trainer t1, Trainer t2)
        {
            Trainer1 = t1;
            Trainer2 = t2;
        }

        public static void StartBattle()
        {
            if (Trainer1 == null || Trainer2 == null) { return; }
            CurrentBattle = new Battle();


            bool KeepPlaying = true;
            while (KeepPlaying)
            {
                CurrentBattleRounds++;

               var Winstate = PlayRound(CurrentBattleRounds);
               
               switch (Winstate)
                {
                    case (false, false):
                        break;
                    case (true, true): // draw
                        Console.WriteLine("It is a draw!");
                        KeepPlaying = false;
                        break;
                    case (true, false): // plr 1 win
                        Console.WriteLine($"{Trainer1.Name} wins!");
                        KeepPlaying = false;
                        break;
                    case (false, true): // plr 2 win
                        Console.WriteLine($"{Trainer2.Name} wins!");
                        KeepPlaying = false;
                        break;
                }
               Console.ReadLine();
            }    
        }


        private static (bool, bool) PlayRound(int CurrentBattleRounds)
        {

            Console.WriteLine();
            Console.WriteLine($"Round {CurrentBattleRounds}");

            bool Trainer1defeated = false;
            bool Trainer2defeated = false;
            

            if (TrainerWinnerOfLastRound != Trainer1)
            {
                if (CurrentBattle == null || Trainer1 == null) { return (false, false);  }
                PokemonOfTrainer1 = Battle.GetRandomPokeball(Trainer1);
                if (PokemonOfTrainer1 == null) { Trainer1defeated = true; }

                else { PokemonOfTrainer1.ThrowPokeball(); }
                
            }
            else if (PokemonOfTrainer1 != null)
            {
                Console.WriteLine($"{PokemonOfTrainer1.PokemonInPokeball.Name} Is still standing!");
            }
            if (TrainerWinnerOfLastRound != Trainer2)
            {
                if (CurrentBattle == null ||  Trainer2 == null) { return (false, false);  }
                PokemonOfTrainer2 = Battle.GetRandomPokeball(Trainer2);
                if (PokemonOfTrainer2 == null) { Trainer2defeated = true; }
                
                else { PokemonOfTrainer2.ThrowPokeball(); }
            }
            else if (PokemonOfTrainer2 != null)
            {
                Console.WriteLine($"{PokemonOfTrainer2.PokemonInPokeball.Name} Is still standing!");
            }

            if (Trainer1defeated || Trainer2defeated)
            {
                return (Trainer1defeated, Trainer2defeated);
            }


            // 0=Draw | 1=Pokemon1 won | 2= Pokemon2 won | 3= error
            if (PokemonOfTrainer1 == null || PokemonOfTrainer2 == null) { throw new Exception(); }

            Console.WriteLine($"{PokemonOfTrainer1.PokemonInPokeball.Name} vs {PokemonOfTrainer2.PokemonInPokeball.Name}");

            if (CurrentBattle == null) { return (false, false); }

            int Winner = Battle.GetWinner(PokemonOfTrainer1.PokemonInPokeball, PokemonOfTrainer2.PokemonInPokeball);
            
            switch (Winner)
            {
                case 0:
                    Console.WriteLine("It is a draw!");
                    if (CurrentBattleRounds == 1 || WinnerOfLastRound == null)
                    {
                        Battle.DefeatPokemon(PokemonOfTrainer1);
                        Battle.DefeatPokemon(PokemonOfTrainer2);
                        WinnerOfLastRound = null;
                        TrainerWinnerOfLastRound = null;
                    }
                    else 
                    { 
                        if (WinnerOfLastRound != null) 
                        { 
                            Battle.DefeatPokemon(WinnerOfLastRound);

                            if (WinnerOfLastRound == PokemonOfTrainer1)
                            {
                                WinnerOfLastRound = PokemonOfTrainer2;
                                TrainerWinnerOfLastRound = Trainer2;
                            }
                            else if (WinnerOfLastRound == PokemonOfTrainer2)
                            {
                                WinnerOfLastRound = PokemonOfTrainer1;
                                TrainerWinnerOfLastRound = Trainer1;
                            }
                            
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
        return (false, false);
        }








    }
}

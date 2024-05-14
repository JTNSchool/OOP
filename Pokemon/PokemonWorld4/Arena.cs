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

        //Creation of a object

        static void SetTrainers(Trainer t1, Trainer t2)
        {
            Trainer1 = t1;
            Trainer2 = t2;
        }

        static void StartBattle()
        {
            CurrentBattle = new Battle(Trainer1, Trainer2);
             
        }


        static void PlayRound()
        {
            CurrentBattleRounds++;

        }



       





    }
}

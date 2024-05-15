using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PokemonWorld
{
    public class Bullbasaur: Pokemon
    {

        //Creation of a object
        public Bullbasaur() : base("Bullbasaur", Pokemon.Type.Grass) { }


        //The BattleCry
        public override void BattleCry()
        {
            Console.WriteLine($"{this.Name}: Bullbasaur!");
        }




    }
}

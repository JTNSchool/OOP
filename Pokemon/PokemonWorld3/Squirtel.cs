using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PokemonWorld
{
    public class Squirtel:Pokemon
    {

        //Creation of a object
        public Squirtel() : base("Squirtel", "Water") { }


        //The BattleCry
        public override void BattleCry()
        {
            Console.WriteLine($"{this.Name}: Squirtel!");
        }




    }
}

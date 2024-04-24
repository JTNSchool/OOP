using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PokemonWorld1
{
    class Charmander
    {
        public string Name;
        public string Type;

        //Creation of a object
        public Charmander()
        {
            this.Name = "Charmander";
            this.Type = "Fire";
        }

        //The BattleCry
        public void BattleCry()
        {
            Console.WriteLine($"{this.Name}: Charmander!");
        }

        //Changees the name of the Pokemon
        public void ChangeName()
        {
            string Name = "";
            while (string.IsNullOrEmpty(Name))
            {
                Console.WriteLine("What is the name of your Charmander?");
                Name = Console.ReadLine();
            }
            this.Name = Name;


        }


    }
}

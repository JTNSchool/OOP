using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PokemonWorld
{
    public abstract class Pokemon
    {
        public string Name;
        public readonly string Type;
        public string Status = "Alive";

        //Creation of a object
        public Pokemon(string name, string type)
        {
            this.Name = name;
            this.Type = type;
        }

        //Changes the name of the Pokemon
        public void ChangeName()
        {
            string? Name = "";
            while (string.IsNullOrEmpty(Name))
            {
                Console.WriteLine($"What is the name of your {this.Name}?");
                Name = Console.ReadLine();
            }
            this.Name = Name;
        }


        public abstract void BattleCry();




    }
}

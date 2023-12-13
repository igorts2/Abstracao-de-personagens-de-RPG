using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstraçãoRPG.Modelos
{
    internal class Knight : Heros
    {
        public Knight(string Name, int Level, int Hp, int Mp) : base(Name, Level, Hp, Mp)
        {
        }
        public override void Apresentar()
        {
            Console.WriteLine();
            Console.WriteLine($"Meu nome é {Name} e sou um Knight!");
            Console.WriteLine($"Atributos:" +
                $"\nLevel: {Level}" +
                $"\nHp: {Hp}" +
                $"\nMp: {Mp}");
        }
        public override void Atacar()
        {
            Console.WriteLine(Name + " Atacou com espada! ");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstraçãoRPG.Modelos
{
    internal class BlackWizard : Heros
    {
        public BlackWizard(string Name, int Level, int Hp, int Mp) : base(Name, Level, Hp, Mp)
        {
        }
        public override void Apresentar()
        {
            Console.WriteLine();
            Console.WriteLine($"Meu nome é {Name} e sou um Black Wizard!");
            Console.WriteLine($"Atributos:" +
                $"\nLevel: {Level}" +
                $"\nHp: {Hp}" +
                $"\nMp: {Mp}");
        }
        public override void Atacar()
        {
            Console.WriteLine(Name + " Atacou com magia! ");
        }
    }
}

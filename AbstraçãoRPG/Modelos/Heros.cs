using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstraçãoRPG.Modelos
{
    internal abstract class Heros
    {
        public Heros(string Name, int Level, int Hp, int Mp)
        {
            this.Name = Name;
            this.Level = Level;
            this.Hp = Hp;
            this.Mp = Mp;
        }
        public string Name;
        public int Level;
        public int Hp;
        public int Mp;

        public virtual void Apresentar () 
        {
            Console.WriteLine($"Meu nome é {Name} e sou um heroi!");
            Console.WriteLine($"\nLevel: {Level}" +
                $"\nHp: {Hp}" +
                $"\nMp: {Mp}");
        }
        public virtual void Atacar()
        {
            Console.WriteLine(Name + " Atacou! ");
        }
    }
}

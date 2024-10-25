using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstraindo_jogo_RPG_Usando_OO.src.Entities
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }
        public int HP { get; set; }
        public int Strength { get; set; }



        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

        public virtual string Attack()
        {
            return this.Name + "Atacou com a sua espada";
        }
        public void Speed()
        {
            if (this.HP >= 10)
            {
                Console.WriteLine($"{this.Name} aumentou sua velocidade em: {this.HP + 10}");
            }
            else
            {
                Vitality();
            }
        }

        public void Vitality()
        {
            if (this.HP >= 10)
            {
                this.Strength += 10;
                Console.WriteLine($"{this.Name} sua força é: {this.Strength}");
                Magic();
            }
            else if (this.HP < 10)
            {
                this.Strength -= 5;
                Console.WriteLine($"{this.Name} sua força diminuiu para: {this.Strength}, fuja!");
                Magic();
            }
            else if (this.HP == 0)
            {
                Console.WriteLine($"{this.Name} morreu.");
            }

        }

        internal void Magic()
        {
            if (this.HP >= 10)
            {
                Console.WriteLine($"sua força mágica, defesa mágica e evasão aumentou!");
            }
            else
            {
                Console.WriteLine($"sua força mágica, defesa mágica e evasão diminui!");
            }
        }

    }
}
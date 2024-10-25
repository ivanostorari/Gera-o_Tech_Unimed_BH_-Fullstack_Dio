using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstraindo_jogo_RPG_Usando_OO.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string Herotype, int hp, int strength)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = Herotype;
            this.HP = hp;
            this.Strength = strength;
        }
        public override string Attack()
        {
            return this.Name + "Atacou com a sua magia";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + "Lançou Magia  super  efetiva com bonus de: " + Bonus;
            }
            else
            {
                return this.Name + " Lançou uma magia com força fraca com bonus de: " + Bonus;
            }
        }

    }
}
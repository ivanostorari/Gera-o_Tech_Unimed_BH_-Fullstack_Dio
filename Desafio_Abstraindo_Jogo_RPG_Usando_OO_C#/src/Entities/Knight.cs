using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstraindo_jogo_RPG_Usando_OO.src.Entities
{
    public class Knight : Hero
    {


        public Knight(string Name, int Level, string Herotype, int hp, int strength)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = Herotype;
            this.HP = hp;
            this.Strength = strength;
        }
        

       
    }

}
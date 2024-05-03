using System;
using static System.Net.Mime.MediaTypeNames;
using System.Numerics;
using System.Xml.Linq;

namespace B02_TextRPG
{
    public class Monster : IDamage
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Gold { get; set; }
        public bool isDead { get; set; }





        public Monster(string name, int level, int health, int attack)
        {
            Name = name;
            Level = level;
            Health = health;
            Attack = attack;
        }

        public int Attackopp(IDamage opp)
        {
            int damage = Attack;
            opp.Health -= damage;
            if (opp.Health < 0)
            {
                opp.isDead = true;
            }
            return damage;
        }
    }
}

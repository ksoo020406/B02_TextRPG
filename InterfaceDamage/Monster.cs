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
            Random random = new Random();
            double fluctuation = Attack * 0.1; // 공격력의 10%
            double randomFluctuation = random.NextDouble() * fluctuation * 2 - fluctuation; // -10% ~ 10% 사이의 무작위 값
            int finalAttack = Attack + (int)Math.Ceiling(randomFluctuation); // 오차를 더하고, 소수점이라면 올림 처리

            int damage = finalAttack;
            opp.Health -= damage;
            if (opp.Health <=0)
            {
                opp.isDead = true;
            }
            return damage; // 실제로 입힌 피해량을 반환
        }
    }
}

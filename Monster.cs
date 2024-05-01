using System;
using static System.Net.Mime.MediaTypeNames;
using System.Numerics;
using System.Xml.Linq;

namespace B02_TextRPG
{
    public class Monster
    {
        public string MonsterName { get; set; }
        public int MonsterLevel { get; set; }
        public int MonsterHealth { get; set; }
        public int MonsterDamage { get; set; }


        public Monster(string monsterName, int monsterLevel, int monsterHealth, int monsterDamage)
        {
            MonsterLevel = monsterLevel;
            MonsterName = monsterName;
            MonsterHealth = monsterHealth;
            MonsterDamage = monsterDamage;
        }



        


    }
}

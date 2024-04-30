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
        

        public Monster(int monsterLevel, string monsterName, int monsterHealth, int monsterDamage)
        {
            MonsterLevel = monsterLevel;
            MonsterName = monsterName;
            MonsterHealth = monsterHealth;
            MonsterDamage = monsterDamage;
        }

        public void Attack(Player player)
        {
           player.TakeDamage(MonsterDamage);
        } 

        public void TakeDamage(int amount)
        {
            MonsterHealth -= amount;
            if (MonsterHealth <= 0)
            {
                Die();
            }
        }
        private void Die()
        {
            Console.WriteLine($"{MonsterName} 은 쓰러졌다!.");
        }


    }
}

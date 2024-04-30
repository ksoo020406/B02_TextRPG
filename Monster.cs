using System;
using static System.Net.Mime.MediaTypeNames;
using System.Numerics;
using System.Xml.Linq;

namespace B02_TextRPG
{
    public class Monster
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }


        public Monster(int monsterLevel, string monsterName, int monsterHealth, int attackDamage)
        {
            level = monsterLevel;
            name = monsterName;
            health = monsterHealth;
            damage = attackDamage;
        }

        public void Attack(Player player)
        {
            character.TakeDamage(damage);
        } 

        public void TakeDamage(int amount)
        {
            health -= amount;
            if (health <= 0)
            {
                Die();
            }
        }
        private void Die()
        {
            Console.WriteLine($"{name} 은 쓰러졌다!.");
        }


    }
}

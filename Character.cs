using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace B02_TextRPG
{
    public class Character
    {

        static int level = 1;
        static string name = "Chad";
        static string job = "전사";
        static int attack = 10;
        static int defense = 5;
        static int health = 100;

        public int Gold { get; set; }

        public Character()
        {
            Gold = 1500;   

        }

        public static void ShowInfo() //1(1) 상태보기
        {
            bool exit = false;
            Character character = new Character();

            while (!exit)
            {
                // 시작 멘트
                Console.Clear();
                Console.WriteLine("상태보기");
                Console.WriteLine("캐릭터의 정보가 표시됩니다");
                Console.WriteLine();

                // 캐릭터 스탯
                Console.WriteLine($"Lv. {level:D2}");
                Console.WriteLine($"{name} ( {job} )");
                Console.WriteLine($"공격력 : {attack}");
                Console.WriteLine($"방어력 : {defense}");
                Console.WriteLine($"체 력 : {health}");
                Console.WriteLine($"Gold : {character.Gold} G");

                //나가기 멘트
                Console.WriteLine();
                Console.WriteLine("0. 나가기");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "0":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("잘못된 선택입니다");
                        break;
                }
            }
        }

        public int Health { get; set; }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health <= 0)
            {
                Die();
            }
        }

        private void Die()
        {
            Console.WriteLine("Character is dead.");
        }



    }


   

}

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

    public class Player
    {
        public int Level { get; set; } //캐릭터 레벨
        public string Name { get; set; } //캐릭터 이름
        public string Job { get; set; } //캐릭터 직업
        public int Attack { get; set; } //캐릭터 공격력
        public int Defense { get; set; } // 캐릭터 방어력
        public int Gold { get; set; } // 캐릭터 소지 골드  

        public int Health //캐릭터 체력
        {
            get { return health; }
            set
            {
                health = value;
                if (health <= 0)
                {
                    Die();
                }
            }
        }

        public Player(string name, string job)
        {
            Level = 1;
            Name = name;
            Job = job;
            SetJobStats();
            Gold = 0;
            Health = 100;
        }

        public void SetJobStats() //직업정보
        {
            switch (Job)
            {
                case "전사":
                    Attack = 10;
                    Defense = 5;
                    break;

                case "마법사":
                    Attack = 8;
                    Defense = 4;
                    break;

                case "도적":
                    Attack = 12;
                    Defense = 4;
                    break;

                default:
                    Console.WriteLine("잘못된 직업을 선택했습니다. 기본 직업으로 설정됩니다.");
                    Attack = 10;
                    Defense = 5;
                    Job = "전사";
                    break;
            }
        }

        public void ShowInfo()
        {
            Console.Clear();

            Console.WriteLine("상태 보기");
            Console.WriteLine("캐릭터의 정보가 표시됩니다");
            Console.WriteLine();

            Console.WriteLine($"Lv. {Level:D2}");
            Console.WriteLine($"{Name} ( {Job} )");
            Console.WriteLine($"공격력 : {Attack}");
            Console.WriteLine($"방어력 : {Defense}");
            Console.WriteLine($"체력 : {Health}");
            Console.WriteLine($"Gold : {Gold} G");
        }

        private void Die()
        {
            Console.WriteLine("Character is dead.");
        }



    }






}




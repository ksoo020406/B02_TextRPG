﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace B02_TextRPG
{
    public class Player : IDamage
    {
        public int Level { get; set; } //캐릭터 레벨
        public string Name { get; set; } //캐릭터 이름
        public string Job { get; set; } //캐릭터 직업
        public int Attack { get; set; } //캐릭터 공격력
        public int AttackPlus { get; set; }
        public int Defense { get; set; } // 캐릭터 방어력
        public int DefensePlus { get; set; }
        public int Gold { get; set; } // 캐릭터 소지 골드
        public int Health { get; set; }//캐릭터 체력
        public int MaxHealth { get; set; }
        public int Potion { get; set; }
        public bool isDead { get; set; }


        //public Player(string name, string job, int level, int atk, int def, int health, int gold)
        //{
        //    Level = level;
        //    Name = name;
        //    Job = job;
        //    SetJobStats();
        //    Gold = 10000;
        //    Health = health;
        //    MaxHealth = health;
        //    Attack = atk;
        //    Defense = def;
        //    DefensePlus = 0;
        //    AttackPlus = 0;
        //    Potion = 3;
        //}

        public Player(string name, string job)
        {
            Level = 1;
            Name = name;
            Job = job;
            SetJobStats();
            Gold = 1500;
            Health = 100;
            MaxHealth = Health;
            Attack = Attack;
            Defense = Defense;
            DefensePlus = 0;
            AttackPlus = 0;
            Potion = 3;
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
                    Defense = 6;
                    break;
                case "도적":
                    Attack = 12;
                    Defense = 4;
                    break;
                default:
                    Console.WriteLine("잘못된 직업을 선택했습니다. 기본 직업 <전사> 으로 설정됩니다.");
                    Attack = 10;
                    Defense = 5;
                    Job = "전사";
                    break;
            }
        }
        public static void ShowInfo(int Level, string Name, string Job, int Attack, int Defense, int Health, int Gold, int AttackPlus, int DefensePlus)
        {

            Console.Clear();
            Console.WriteLine("상태 보기");
            Console.WriteLine("캐릭터의 정보가 표시됩니다");
            Console.WriteLine();
            Console.WriteLine($"Lv. {Level:D2}");
            Console.WriteLine($"{Name} ( {Job} )");
            if (AttackPlus > 0)
            {
                Console.WriteLine($"공격력 : {Attack} (+ {AttackPlus})");
            }
            else if (AttackPlus <= 0)
            {
                Console.WriteLine($"공격력 : {Attack}");
            }
            if (DefensePlus > 0)
            {
                Console.WriteLine($"방어력 : {Defense} (+ {DefensePlus})");
            }
            else if (DefensePlus <= 0)
            {
                Console.WriteLine($"방어력 : {Defense}");
            }
            Console.WriteLine($"체력 : {Health}");
            Console.WriteLine($"Gold : {Gold} G");

            Console.WriteLine("");
            Console.WriteLine("[영구버프]");
            Console.WriteLine("");

            for (int i = 0; i < Item.InventoryItems.Count; i++) // 리스트에는 항상 Count(몇 개?)라는 값이 있다.
            {
                //인벤토리 아이템 타입 판별하기
                if (Item.InventoryItems[i].ThisItemType == ItemType.SPECIAL)
                {
                    Console.WriteLine("당신에겐 " + Item.InventoryItems[i].Name + "이 깃들어있습니다.");
                }
            }

            Console.WriteLine();
            Console.WriteLine("0. 나가기");

            switch (ConsoleUtility.PromptMenuChoice(0, 0))
            {
                case 0:
                    return;

            }
        }
        public int Attackopp(IDamage opp)
        {
            Random random = new Random();
            double fluctuation = Attack * 0.1; // 공격력의 10%
            double randomFluctuation = random.NextDouble() * fluctuation * 2 - fluctuation; // -10% ~ 10% 사이의 무작위 값
            int finalAttack = Attack + (int)Math.Ceiling(randomFluctuation); // 오차를 더하고, 소수점이라면 올림 처리

            int damage = finalAttack;
            opp.Health -= damage;
            if (opp.Health <= 0)
            {
                opp.isDead = true;
            }
            return damage; // 실제로 입힌 피해량을 반환
        }



    }
}




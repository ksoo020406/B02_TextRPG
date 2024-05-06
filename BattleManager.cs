﻿using B02_TextRPG;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;


namespace B02_TextRPG
{

    public class BattleManager
    {
        MonsterManager monsterManager;
        List<Monster> currentMonsters;
        public BattleManager()
        {
            monsterManager = new MonsterManager();
            currentMonsters = new List<Monster>();
        }


        public void StartBattle(Player player)
        {

            Console.Clear();
            Console.WriteLine("Battle!!");
            Console.WriteLine("");
            currentMonsters = monsterManager.GetMonsters();
            currentMonsters = currentMonsters.OrderBy(x => Guid.NewGuid()).ToList(); // 몬스터 목록을 랜덤하게 섞음
            DisplayMonsters(currentMonsters);
            Console.WriteLine("");
           

            // 플레이어 정보
            Console.WriteLine("[내 정보]");
            Console.WriteLine($"LV.{player.Level},{player.Name}({player.Job})");
            Console.WriteLine($"HP{player.Health}/{player.MaxHealth}");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("1.공격");
            Console.WriteLine("2.도망친다");
            int input = ConsoleUtility.PromptMenuChoice(1, 2);

            switch (input)
            {
                case 1:
                    
                    Console.WriteLine("1.공격");
                    ChoiceAttack(player);
                    ConsoleUtility.PromptMenuChoice(1, 2);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("도망 성공!");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("0.메인메뉴로 나가기");
                    ConsoleUtility.PromptMenuChoice(0,0);
                    break;
            }

        }
        public void ChoiceAttack(Player player)
        {
            Console.Clear();
            Console.WriteLine("Battle!!");
            Console.WriteLine("");
            for (int i = 0; i < currentMonsters.Count; i++)
            {
                Monster monster = currentMonsters[i];
                string monsterStatus = monster.isDead ? "Dead" : $"HP {monster.Health}";
                Console.WriteLine($"{i + 1} Lv.{monster.Level} {monster.Name}  {monsterStatus}");
            }

            Console.WriteLine("\n[내정보]");
            Console.WriteLine($"Lv.{player.Level}  {player.Name} ({player.Job})");
            Console.WriteLine($"HP {player.Health}/{player.MaxHealth}\n");
            Console.WriteLine("0. 취소\n");
            Console.WriteLine("");
            Console.WriteLine("대상을 원하시는 번호로 선택해주세요.");
            Console.WriteLine("");


            int monsterIndex = ConsoleUtility.PromptMenuChoice(1, currentMonsters.Count);

            if (monsterIndex <= 0 || monsterIndex > currentMonsters.Count)
            {
                Console.WriteLine("잘못된 입력입니다.");
                return;
            }

            Monster selectedMonster = currentMonsters[monsterIndex - 1];

            if (selectedMonster.Health <= 0)
            {
                Console.WriteLine("잘못된 입력입니다.");
                return;
            }

            // 플레이어가 몬스터를 공격
            int damage = player.Attackopp(selectedMonster);
            Console.Clear();
            Console.WriteLine("Battle!!");
            Console.WriteLine("");
            Console.WriteLine($"{player.Name} 의 공격!");
            Console.WriteLine($"Lv.{selectedMonster.Level} {selectedMonster.Name} 을(를) 맞췄습니다. [데미지 : {damage}]");
            Console.WriteLine("");
            


            if (selectedMonster.isDead)
            {
                Console.WriteLine($"\nLv.{selectedMonster.Level} {selectedMonster.Name}\nHP {selectedMonster.Health + damage} -> Dead");
                Console.WriteLine("");
                Console.WriteLine("0. 다음");
            }
            else
            {
                Console.WriteLine($"{selectedMonster.Name}에게 {damage}의 피해를 입혔습니다. 남은 체력: {selectedMonster.Health}");
                Console.WriteLine("");
                Console.WriteLine("0. 다음");
            }

            
        }
        private void DisplayMonsters(List<Monster> monsters) // 몬스터 정보를 출력하는 메서드
        {
            foreach (Monster monster in monsters)
            {
                Console.WriteLine($"Lv.{monster.Level} {monster.Name}  HP {monster.Health}");
            }
            Console.WriteLine("");
            Console.WriteLine("");
        }
        private void DisplayMonstersWithNumbers(List<Monster> monsters) // 번호와 함께 몬스터 정보를 출력하는 메서드
        {
            for (int i = 0; i < monsters.Count; i++)
            {
                Monster monster = monsters[i];
                if (monster.isDead)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray; // 텍스트 색상을 어두운 회색으로 변경
                    Console.WriteLine($"{i + 1}. Lv.{monster.Level} {monster.Name}  HP Dead");
                    Console.ResetColor(); // 텍스트 색상을 기본값으로 복원
                }
                else
                {
                    Console.WriteLine($"{i + 1}. Lv.{monster.Level} {monster.Name}  HP {monster.Health}");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("");
        }



    }
}
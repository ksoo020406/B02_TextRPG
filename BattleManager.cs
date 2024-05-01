﻿using B02_TextRPG;
using System;


namespace B02_TextRPG
{

    public class BattleManager
    {

        private Random random = new Random();

        public void StartBattle(Player player)
        {

            Console.Clear(); 
            MonsterManager monsterManager = new MonsterManager();
            List<Monster> monsters = GetRandomMonsters();

            Console.WriteLine("Battle!!");
            Console.WriteLine();

            foreach (var monster in monsters)
            {
                Console.WriteLine($"Lv.{monster.MonsterLevel} {monster.MonsterName} HP {monster.MonsterHealth}");
            }

            Console.WriteLine();
            Console.WriteLine("[내정보]");
            Console.WriteLine($"Lv.{player.Level} {player.Name} ({player.Job})");
            Console.WriteLine($"HP {player.Health}/100");
            Console.WriteLine();
            Console.WriteLine("1. 공격");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    //공격 로직 구현
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }
        }

        private List<Monster> GetRandomMonsters()
        {
            MonsterManager monsterManager = new MonsterManager();
            List<Monster> allMonsters = monsterManager.GetMonsters();
            List<Monster> randomMonsters = new List<Monster>();
            List<Monster> selectedMonsters = new List<Monster>();
            int numberOfMonsters = random.Next(1, 5);

            for (int i = 0; i < numberOfMonsters; i++)
            {
                int randomIndex = random.Next(0, allMonsters.Count);
                selectedMonsters.Add(allMonsters[randomIndex]);
            }

            return selectedMonsters;
        }
    }
}
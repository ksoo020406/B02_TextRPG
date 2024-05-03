using B02_TextRPG;
using System;
using System.Collections.Generic;
using System.Numerics;


namespace B02_TextRPG
{

    public class BattleManager
    {

        public void StartBattle(Player player)
        {
            Random random = new Random();
            Console.Clear();
            MonsterManager monsterManager = new MonsterManager();
            List<Monster> monsters = monsterManager.GetRandomMonsters();

            Console.WriteLine("Battle!!");
            Console.WriteLine();

            foreach (var monster in monsters)
            {
                Console.WriteLine($"Lv.{monster.Level} {monster.Name} HP {monster.Health}");
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
                case "2":
                    //도망 로직 구현
                    break;
                case "3":
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }
        }


       
    }
}
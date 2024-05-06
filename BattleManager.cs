using B02_TextRPG;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;


namespace B02_TextRPG
{

    public class BattleManager
    {
        MonsterManager monsterManager;
        public BattleManager()
        {
            monsterManager = new MonsterManager();
        }


        public void StartBattle(Player player)
        {

            Console.Clear();
            Console.WriteLine("Battle!!");
            Console.WriteLine("");
            monsterManager.DisplayRandomMonsters();
            Console.WriteLine("");
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
                    break;
                case 2:
                    Console.WriteLine("2.도망친다");
                    break;



            }



        }




    }
}
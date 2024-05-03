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

            // 플레이어 정보
            Console.WriteLine("[내 정보]");
            Console.WriteLine($"LV.{player.Level},{player.Name}({player.Job})");
            Console.WriteLine($"HP{player.Health}/{player.MaxHealth}");
            int input = ConsoleUtility.PromptMenuChoice(0, 3);

        }
       



    }
}
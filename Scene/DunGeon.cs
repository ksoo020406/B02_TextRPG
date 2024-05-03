using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B02_TextRPG
{
    internal class DunGeon
    {

        public DunGeon() { }

        public static void StartDunGeon(Player player)
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■"); // 60개 
            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("이제 전투를 시작할 수 있습니다.");
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■"); // 60개 
            Console.WriteLine("");
            Console.ResetColor();

            Console.WriteLine("1. 상태보기");
            Console.WriteLine("2. 전투시작");
            Console.WriteLine("3. 회복 아이템");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("0. 나가기");
            Console.ResetColor();
            Console.WriteLine();

            int input = ConsoleUtility.PromptMenuChoice(0, 3);
            BattleManager battlemanager;
            
            switch (input)
            {
                case 1:
                    Player.ShowInfo
                        (player.Level, player.Name, player.Job, player.Attack, player.Defense, player.Health, player.Gold, player.AttackPlus, player.DefensePlus);
                    break;
                case 2:
                    battlemanager = new BattleManager();
                    
                    battlemanager.StartBattle(player);
                    break;
                case 3: // 포션 먹는 메소드 
                    potionUse(player);
                    break;
                case 0: return;
            }
        }

        public static void potionUse(Player player)
        {
            Console.Clear();

            Console.WriteLine("**회복**");
            // 플레이어가 가지고 있는 포션 개수로 표시 
            Console.WriteLine($"포션을 사용하면 체력을 30 회복 할 수 있습니다. (남은 포션 : {player.Potion})");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1. 사용하기");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("0. 나가기");
            Console.ResetColor();
            Console.WriteLine();
            int input = ConsoleUtility.PromptMenuChoice(0, 1);

            switch (input)
            {
                case 1: // 포션이 충분하고 체력이 100 보다 작을 때 
                    if (player.Potion > 0 && player.Health < 100)
                    {
                        player.Health += 30;
                        Console.WriteLine("회복(+30)을 완료했습니다!");

                        //최대 체력을 넘기는 경우 100으로 체력 설정
                        if (player.Health > 100)
                        {
                            player.Health = 100;
                        }

                        // 포션 갯수 감소
                        player.Potion--;
                    }
                    // 포션이 없을때
                    else if (player.Potion <= 0)
                    {
                        Console.WriteLine("포션이 부족합니다! 포션을 구해오세요!");
                    }
                    else
                    {
                        Console.WriteLine("이미 최대 체력입니다!");
                    }
                    Thread.Sleep(500);
                    StartDunGeon(player);
                    break;
                case 0: StartDunGeon(player); break;

            }
        }
    }
}

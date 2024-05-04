using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace B02_TextRPG
{
    internal class StartQuest
    {
        public static void StartQuest1(Player player)
        {
            Console.Clear();
            Console.WriteLine("과제발생기 강탈 미션을 시작합니다.");
            Console.WriteLine();
            Console.WriteLine("'여기야!!" + Start.player.Name + " !!!'");
            Console.WriteLine("'이게 우리에게 자꾸 과제를 내준다는 극악무도한 <매니저님의 컴퓨터>야! 이걸 부숴줘!'");
            Console.WriteLine();
            Console.WriteLine("         .~;!!;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;.        ");           
            Console.WriteLine("         .=$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$,        ");             
            Console.WriteLine("         .$!,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,!$-        ");             
            Console.WriteLine("         .$!                                   !$-        ");             
            Console.WriteLine("         .$!          오늘은                   !$-        ");             
            Console.WriteLine("         .$!                                   !$-        ");             
            Console.WriteLine("         .$!          어떤과제를               !$-        ");             
            Console.WriteLine("         .$!                                   !$-        ");                
            Console.WriteLine("         .$!          내볼까나...  ^^          !$-        ");             
            Console.WriteLine("         .$!                                   !$-        ");                             
            Console.WriteLine("         .$!                                   !$-        ");             
            Console.WriteLine("         .$*:::::::::::::::::::::::::::::::::::*$-        ");             
            Console.WriteLine("         .=======================================-        ");             
            Console.WriteLine("         .~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~.        ");              
            Console.WriteLine("         .=$$$$$$$$$$$$$$$$$=;;=$$$$$$$$$$$$$$$$$$,       ");                                    
            Console.WriteLine("                         ,$$$$$$$,                        ");                   
            Console.WriteLine("                  .!======$$$$$$$======*~                 ");
            Console.WriteLine();

            Console.WriteLine("1. 컴퓨터를 공격하기");
            Console.WriteLine();
            Console.WriteLine("0. 마을로 돌아가기");

            Console.WriteLine();
            Console.Write(">>");

            int choice = ConsoleUtility.PromptMenuChoice(0, 3);

            switch (choice)
            {
                case 0:
                    GameManager gameManager = new GameManager(); //게임매니저 인스턴스 생성                       
                    gameManager.MainMenu(player);  // 플레이어 정보를 MainMenu 메서드에 전달
                    break;

                case 1:
                    /// 컴퓨터를 공격해야함.
                    break;


            }

        }

        public static void StartQuest2(Player player)
        {
            Console.Clear();
            Console.WriteLine("수진이의 사랑을 얻어라!");
            Console.WriteLine();

            Console.WriteLine("| ♡⃘♡⃘♡⃘♡⃘♡⃘♡⃘♡⃘♡⃘♡-----------------------------------|");
            Console.WriteLine("| 　　　　　　　　　　　　　　　                      |");
            Console.WriteLine("| 　　　　　화창한 날씨!!!　　　　　　　　　　        |");
            Console.WriteLine("| 　　　　　내가 짝사랑하는 옆반 수진이에게　　　     |");
            Console.WriteLine("| 　　　　　고백을 할거야            　　　           |");
            Console.WriteLine("| 　　　　　　　　　　　　　　　                      |");
            Console.WriteLine("|------------------------------------♡⃘♡⃘♡⃘♡⃘♡⃘♡⃘♡⃘♡⃘♡");


            Console.WriteLine();
            Console.WriteLine("0. 마을로 돌아가기");

            Console.WriteLine();
            Console.Write(">>");

            int choice = ConsoleUtility.PromptMenuChoice(0, 3);

            switch (choice)
            {
                case 0:
                    GameManager gameManager = new GameManager(); //게임매니저 인스턴스 생성                       
                    gameManager.MainMenu(player);  // 플레이어 정보를 MainMenu 메서드에 전달
                    break;

                case 1:
                    Console.WriteLine("붕붕붕 아주작은 자동차");
                    break;


            }

        }
    }
}

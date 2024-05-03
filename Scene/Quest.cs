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
            Console.WriteLine("과제발생기 강탈 미션을 시작합니다.");

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

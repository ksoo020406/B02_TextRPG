using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace B02_TextRPG
{
    internal class QuestManager  
    {
        public static void Quest (Player player)
        {

            bool exit = false;

            while (!exit)
            {
                Console.Clear();

                Console.WriteLine("   ____                  _     _ ");
                Console.WriteLine("  / __ \\                | |   | |");
                Console.WriteLine(" | |  | |_   _  ___  ___| |_  | |");
                Console.WriteLine(" | |  | | | | |/ _ \\/ __| __| | |");
                Console.WriteLine(" | |__| | |_| |  __/\\__ \\ |_  |_|");
                Console.WriteLine("  \\___\\_\\\\__,_|\\___||___/\\__| (_)");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("1. 과제발생기 강탈 미션 ★");                      // 기본 공격으로 매니저님들의 컴퓨터를 부수면 되는 게임
                Console.WriteLine("2. 수진이의 사랑을 얻어라 ★ ★ ★");               // 수진이의 사랑과 눈물을 얻기 위한 여정
                Console.WriteLine();
                Console.WriteLine("0. 마을로 돌아가기");

                Console.WriteLine();



                int choice = ConsoleUtility.PromptMenuChoice(0, 2);

                switch (choice)
                {
                    case 0:
                        exit = true;
                        break;

                    case 1:
                        Quest1(player);
                        break;
                    case 2:
                        Quest2(player);
                        break;
                }

            }
        }

        public static void Quest1(Player player)
        {
            Console.Clear();

            Console.WriteLine("[ 퀘스트1. 과제발생기 강탈 미션 ]");
            Console.WriteLine("난이도 : ★");

            Console.WriteLine();
            Console.WriteLine("'있잖아... " + Start.player.Name + " ...'");
            Console.WriteLine("'그 소문 들었어?... 우리에게 자꾸 과제를 내주는 과제발생기의 위치를 알아냈대...'");
            Console.WriteLine("'그곳에 가서... 과제 발생기를 없애면 과제가 줄어들지도 몰라...'");
            Console.WriteLine("'어떻게 할래?... 도전해볼래?...'");

            Console.WriteLine();
            Console.WriteLine("1. 당연히 참여한다");
            Console.WriteLine("0. 무서우니 도망친다");
            Console.WriteLine();

            int choice = ConsoleUtility.PromptMenuChoice(0, 1);

            switch (choice)
            {
                case 0:
                    GameManager gameManager = new GameManager(); //게임매니저 인스턴스 생성      
                    gameManager.MainMenu(player);  // 플레이어 정보를 MainMenu 메서드에 전달
                    break;

                case 1:
                    StartQuest.StartQuest1(player);
                    break;

            }
        }

        public static void Quest2(Player player)
        {
            Console.Clear();

            Console.WriteLine("[ 퀘스트2. 수진이의 사랑을 얻어라! ]");
            Console.WriteLine("난이도 : ★ ★ ★");

            Console.WriteLine();
            Console.WriteLine("| ♡⃘♡⃘♡⃘♡⃘♡⃘♡⃘♡⃘♡⃘♡-----------------------------------|");
            Console.WriteLine("| 　　　　　　　　　　　　　　　                      |");
            Console.WriteLine("| 　　　　　화창한 날씨!!!　　　　　　　　　　        |");
            Console.WriteLine("| 　　　　　내가 짝사랑하는 옆반 수진이에게　　　     |");
            Console.WriteLine("| 　　　　　고백을 할거야            　　　           |");
            Console.WriteLine("| 　　　　　　　　　　　　　　　                      |");
            Console.WriteLine("|------------------------------------♡⃘♡⃘♡⃘♡⃘♡⃘♡⃘♡⃘♡⃘♡");

            Console.WriteLine();
            Console.WriteLine("1. 수진아 기다려 내가 간다!");
            Console.WriteLine("0. 자신없이 없어.. 마을로 도망갈래");
            Console.WriteLine();

            int choice = ConsoleUtility.PromptMenuChoice(0, 1);

            switch (choice)
            {
                case 0:
                    GameManager gameManager = new GameManager(); //게임매니저 인스턴스 생성      
                    gameManager.MainMenu(player);  // 플레이어 정보를 MainMenu 메서드에 전달
                    break;

                case 1:
                    StartQuest.Sujin1(player);
                    break;

            }
        }

        
    }
}

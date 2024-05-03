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
        public static void Quest()
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
                Console.WriteLine("2. 거대한 혁최몬 소탕 미션 ★ ★ ★");               // 혁최몬 체력이 좀 더 많아집니다
                Console.WriteLine("3. 스파르타 코딩클럽에서 생존하기 ★ ★ ★ ★ ★");    // 일단 넣어봄
                Console.WriteLine("0. 마을로 돌아가기");

                Console.WriteLine();
                Console.WriteLine("참여하실 퀘스트 번호를 입력해주세요");
                Console.Write(">>");


                int choice = ConsoleUtility.PromptMenuChoice(0, 3);

                switch (choice)
                {
                    case 0:
                        exit = true;
                        break;

                    case 1:
                        Quest1();
                        break;
                    case 2:
                        Quest2();
                        break;
                    case 3:
                        Quest3();
                        break;
                }

            }
        }

        public static void Quest1()
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
            Console.Write(">>");

            int choice = ConsoleUtility.PromptMenuChoice(0, 1);

            switch (choice)
            {
                case 0:
                    return;

                case 1:
                    StartQuest.StartQuest1();
                    break;

            }
        }

        public static void Quest2()
        {
            Console.Clear();

            Console.WriteLine("[ 퀘스트2. 거대한 혁최몬 소탕 미션 ]");
            Console.WriteLine("난이도 : ★ ★ ★");

            Console.WriteLine();
            Console.WriteLine("'큰일이야!! " + Start.player.Name + " !!!'");
            Console.WriteLine("'혁최몬이 내가 낸 과제물을 보고 분노해서 거대해져버렸대!!'");
            Console.WriteLine("'마을 사람들을 마구 찌르며 괴롭히고 있다는데, 도와주지 않을래?'");
            
            Console.WriteLine();
            Console.WriteLine("1. 당연히 참여한다");
            Console.WriteLine("0. 무서우니 도망친다");
            Console.WriteLine();
            Console.Write(">>");

            int choice = ConsoleUtility.PromptMenuChoice(0, 1);

            switch (choice)
            {
                case 0:
                    return;

                case 1:
                    // 퀘스트 2번으로 가야한다
                    break;

            }
        }

        public static void Quest3()
        {
            Console.Clear();

            Console.WriteLine("[ 퀘스트3. 스파르타 코딩클럽에서 생존하기 ]");
            Console.WriteLine("난이도 : ★ ★ ★ ★ ★");

            Console.WriteLine();
            Console.WriteLine("'스파르타 코딩클럽에 온 것을 환영한다... " + Start.player.Name + " 이여...'");
            Console.WriteLine("'이곳에 온 이상 너는 도망칠 수 없다'");
            Console.WriteLine("'코딩을 해라.. 공부를 해라.. " + Start.player.Name + " ..!!!!");

            Console.WriteLine();
            Console.WriteLine("도망칠 수 없습니다. 아무 키나 입력해 스파르타 코딩클럽에 입장하세요");
            Console.ReadKey();

            //퀘스트 3번으로 가야한다.

            // 아무 키를 누르면 스파르타코딩클럽으로 입장
            // 지금은 아무거나 누르면 메인화면으로 돌아감
        }

        
    }
}

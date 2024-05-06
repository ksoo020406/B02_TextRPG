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

        /// //// //// //// //// //// //// //// //// //// //// //// //// //// //// //// //// //// //// //// //// //// //// //// //// //// //// /

        public static void Sujin1(Player player)
        {
            Console.Clear();
            Console.WriteLine();

            Console.WriteLine("| ♡⃘♡⃘♡⃘♡⃘♡⃘♡⃘♡⃘♡⃘♡-----------------------------------|");
            Console.WriteLine("| 　　　　　　　　　　　　　　　                      |");
            Console.WriteLine("| 　　　　　수진이의 마음을 얻기 위해선　　　         |");
            Console.WriteLine("| 　　　　　수진이의 취향을 잘 알아야겠지?　　　      |");
            Console.WriteLine("| 　　　　　밸런스 게임을 맞춰보자!                   |");
            Console.WriteLine("| 　　　　　　　　　　　　　　　                      |");
            Console.WriteLine("|------------------------------------♡⃘♡⃘♡⃘♡⃘♡⃘♡⃘♡⃘♡⃘♡");


            Console.WriteLine();
            Console.WriteLine("1. 밸런스 게임 진행하기");
            Console.WriteLine("0. 마을로 돌아가기");
            Console.WriteLine();
            Console.WriteLine(" * 게임을 진행하는 동안은 마을로 돌아갈 수 없습니다. *");
            Console.WriteLine();

            int choice = ConsoleUtility.PromptMenuChoice(0, 1);

            switch (choice)
            {
                case 0:
                    GameManager gameManager = new GameManager(); //게임매니저 인스턴스 생성                       
                    gameManager.MainMenu(player);  // 플레이어 정보를 MainMenu 메서드에 전달
                    break;

                case 1:
                    Sujin2(player);
                    break;
            }
        }

        public static void Sujin2(Player player)
        {
            Console.Clear();
            Console.WriteLine();

            Console.WriteLine("| ♡⃘♡⃘♡⃘♡⃘♡⃘♡⃘♡⃘♡⃘♡-----------------------------------|");
            Console.WriteLine("| 　　　　　　　　　　　　　　　                      |");
            Console.WriteLine("| 　　　　　        <첫번째 문제>　 　  　            |");
            Console.WriteLine("| 　　　　　                              　　　      |");
            Console.WriteLine("| 　　　　       부먹     VS     찍먹                 |");
            Console.WriteLine("| 　　　　　　　　　　　　　　　                      |");
            Console.WriteLine("|------------------------------------♡⃘♡⃘♡⃘♡⃘♡⃘♡⃘♡⃘♡⃘♡");


            Console.WriteLine();
            Console.WriteLine("1. 부먹");
            Console.WriteLine("2. 찍먹");
            Console.WriteLine();

            int choice = ConsoleUtility.PromptMenuChoice(1, 2);

            switch (choice)
            {
                case 1:
                    Console.WriteLine();
                    Console.WriteLine("틀렸습니다. 수진이는 찍먹파입니다.");
                    Console.WriteLine("아무 키를 눌러 퀘스트 화면으로 돌아가세요.");
                    Console.ReadKey();
                    break;

                case 2:
                    Console.WriteLine();
                    Console.WriteLine("정답입니다.");
                    Console.WriteLine("아무 키를 눌러 다음 문제로 넘어가세요.");
                    Console.ReadKey();
                    Sujin3(player);
                    break;
            }
        }

        public static void Sujin3(Player player)
        {
            Console.Clear();
            Console.WriteLine();

            Console.WriteLine("| ♡⃘♡⃘♡⃘♡⃘♡⃘♡⃘♡⃘♡⃘♡-----------------------------------|");
            Console.WriteLine("| 　　　　　　　　　　　　　　　                      |");
            Console.WriteLine("| 　　　　　        <두번째 문제>　 　  　            |");
            Console.WriteLine("| 　　　　　                              　　　      |");
            Console.WriteLine("| 　　　　       바다     VS      산                  |");
            Console.WriteLine("| 　　　　　　　　　　　　　　　                      |");
            Console.WriteLine("|------------------------------------♡⃘♡⃘♡⃘♡⃘♡⃘♡⃘♡⃘♡⃘♡");


            Console.WriteLine();
            Console.WriteLine("1. 바다");
            Console.WriteLine("2. 산");
            Console.WriteLine();

            int choice = ConsoleUtility.PromptMenuChoice(1, 2);

            switch (choice)
            {
                case 2:
                    Console.WriteLine();
                    Console.WriteLine("틀렸습니다. 수진이는 바다를 더 좋아합니다.");
                    Console.WriteLine("아무 키를 눌러 퀘스트 화면으로 돌아가세요.");
                    Console.ReadKey();
                    break;

                case 1:
                    Console.WriteLine();
                    Console.WriteLine("정답입니다.");
                    Console.WriteLine("아무 키를 눌러 다음 문제로 넘어가세요.");
                    Console.ReadKey();
                    Sujin4(player);
                    break;
            }
        }

        public static void Sujin4(Player player)
        {
            Console.Clear();
            Console.WriteLine();

            Console.WriteLine("| ♡⃘♡⃘♡⃘♡⃘♡⃘♡⃘♡⃘♡⃘♡-----------------------------------|");
            Console.WriteLine("| 　　　　　　　　　　　　　　　                      |");
            Console.WriteLine("| 　　　　　        <세번째 문제>　 　  　            |");
            Console.WriteLine("| 　　　　　                              　　　      |");
            Console.WriteLine("| 　　　　       짜장     VS     짬뽕                 |");
            Console.WriteLine("| 　　　　　　　　　　　　　　　                      |");
            Console.WriteLine("|------------------------------------♡⃘♡⃘♡⃘♡⃘♡⃘♡⃘♡⃘♡⃘♡");


            Console.WriteLine();
            Console.WriteLine("1. 짜장");
            Console.WriteLine("2. 짬뽕");
            Console.WriteLine();

            int choice = ConsoleUtility.PromptMenuChoice(1, 2);

            switch (choice)
            {
                case 1:
                    Console.WriteLine();
                    Console.WriteLine("틀렸습니다. 수진이는 짬뽕을 더 좋아합니다");
                    Console.WriteLine("아무 키를 눌러 퀘스트 화면으로 돌아가세요.");
                    Console.ReadKey();
                    break;

                case 2:
                    Console.WriteLine();
                    Console.WriteLine("정답입니다.");
                    Console.WriteLine("아무 키를 눌러 다음 문제로 넘어가세요.");
                    Console.ReadKey();
                    Sujin5(player);
                    break;
            }
        }

        public static void Sujin5(Player player)
        {
            Console.Clear();
            Console.WriteLine();

            Console.WriteLine("| ♡⃘♡⃘♡⃘♡⃘♡⃘♡⃘♡⃘♡⃘♡-----------------------------------|");
            Console.WriteLine("| 　　　　　　　　　　　　　　　                      |");
            Console.WriteLine("| 　　　　　        <마지막 문제>　    　  　         |");
            Console.WriteLine("| 　　　　　                              　　　      |");
            Console.WriteLine("| 　　　　       치킨     VS     피자                 |");
            Console.WriteLine("| 　　　　　　　　　　　　　　　                      |");
            Console.WriteLine("|------------------------------------♡⃘♡⃘♡⃘♡⃘♡⃘♡⃘♡⃘♡⃘♡");


            Console.WriteLine();
            Console.WriteLine("1. 치킨");
            Console.WriteLine("2. 피자");
            Console.WriteLine();

            int choice = ConsoleUtility.PromptMenuChoice(1, 2);

            switch (choice)
            {
                case 1:
                    Console.WriteLine();
                    Console.WriteLine("틀렸습니다. 수진이는 피자를 더 좋아합니다");
                    Console.WriteLine("아무 키를 눌러 퀘스트 화면으로 돌아가세요.");
                    Console.ReadKey();
                    break;

                case 2:
                    Console.WriteLine();
                    Console.WriteLine("정답입니다.");
                    Console.WriteLine("아무 키를 눌러 대화를 진행하세요");
                    Console.ReadKey();
                    Sujin6(player);
                    break;
            }
        }

        public static void Sujin6(Player player)
        {
            Console.Clear();
            Console.WriteLine();

            Console.WriteLine("| ♡⃘♡⃘♡⃘♡⃘♡⃘♡⃘♡⃘♡⃘♡-----------------------------------|");
            Console.WriteLine("| 　　　　　　　　　　　　　　　                      |");
            Console.WriteLine("| 　　　　　       와! 수진이의 취향을　   　         |");
            Console.WriteLine("| 　　　　　          모두 맞혔어!!       　　　      |");
            Console.WriteLine("| 　　　　   보상으로 수진이의 사랑을 줄게!           |");
            Console.WriteLine("| 　　　　　　　　　　　　　　　                      |");
            Console.WriteLine("|------------------------------------♡⃘♡⃘♡⃘♡⃘♡⃘♡⃘♡⃘♡⃘♡");


            Console.WriteLine();
            Console.WriteLine("1. 와~ 수진이의 사랑이다~");
            Console.WriteLine("2. 난 보상따위 필요없어.. 수진이 너만 있으면 돼");
            Console.WriteLine();

            int choice = ConsoleUtility.PromptMenuChoice(1, 2);

            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("             .---------.           .------ - ~.                   "); 
                    Console.WriteLine("           ~= ~,.......-:#$!. . .$*~,........-*$                  ");
                    Console.WriteLine("  .       !*..,..........;#*, :=-. ...........*$,                 ");
                    Console.WriteLine("         - !...............-$$;=,...............*=.               ");
                    Console.WriteLine("        .! - ...............-$$,................-#-               ");
                    Console.WriteLine("        - !..................,.......,......... .!=               ");
                    Console.WriteLine("        ,$~....................................;#-                ");
                    Console.WriteLine("         ~$:.................................,!@*.                ");
                    Console.WriteLine("          ;#;..................., ..........:#@=.                 ");
                    Console.WriteLine("          .,$$; -,...........,...........,~; @@$~                 ");
                    Console.WriteLine("            .~!=$!~,...............,.,~!=@= !~                    ");
                    Console.WriteLine("               , -~@$!,.............,:$#@~-,              .  .    ");
                    Console.WriteLine("                     !=; -......-*$=.                             ");
                    Console.WriteLine("                      , !$:....;#=-                               ");
                    Console.WriteLine("     .                  .-#;.,;@:.         .                      ");
                    Console.WriteLine("                          ~@!:@:                                  ");
                    Console.WriteLine("                           ~##;.                                  ");   


                    Console.WriteLine();
                    Console.WriteLine("<수진이의 사랑> 아이템을 획득합니다.");
                    Console.WriteLine();
                    Console.WriteLine("아이템은 인벤토리에서 확인하실 수 있습니다.");
                    Console.WriteLine("아무 키를 눌러 퀘스트 화면으로 돌아가세요.");
                    Console.ReadKey();
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("낭만을 선택하셨습니다.");
                    Console.WriteLine();
                    Console.WriteLine("수진이가 당신의 선택에 감동해 눈물을 흘립니다.");
                    Console.WriteLine();

                    Console.WriteLine("                        .                          ");
                    Console.WriteLine("                       ..                          ");
                    Console.WriteLine("                      ....                         ");
                    Console.WriteLine("                     ......                        ");
                    Console.WriteLine("                    .........                      ");
                    Console.WriteLine("                   ...........                     ");
                    Console.WriteLine("                 ...............                   ");
                    Console.WriteLine("               ... ...............                 ");
                    Console.WriteLine("              ...  ................                ");
                    Console.WriteLine("             ...  ..................               ");
                    Console.WriteLine("             ...  ..................               ");
                    Console.WriteLine("             . .  ..................               ");
                    Console.WriteLine("             . .  ..................               ");
                    Console.WriteLine("             . ..  .................               ");
                    Console.WriteLine("              .....................                ");
                    Console.WriteLine("               .....  ...........                 ");
                    Console.WriteLine("                    .........                      ");
                    Console.WriteLine();

                    Console.WriteLine("<수진이의 눈물> 아이템을 획득합니다");
                    Console.WriteLine();
                    Console.WriteLine("아이템은 인벤토리에서 확인하실 수 있습니다.");
                    Console.WriteLine("아무 키를 눌러 퀘스트 화면으로 돌아가세요.");
                    Console.ReadKey();
                    break;
            }
        }

        
    }


}

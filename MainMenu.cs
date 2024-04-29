using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B02_TextRPG
{
    internal class MainMenu
    {
        public static void mainMenu()
        {
            // 구성
            // 0. 화면 정리
            Console.Clear();

            // 1. 선택 멘트를 준다.
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■"); // 60개 
            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("이곳에서 던전으로 들어가기 전활동을 할 수 있습니다.");
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■"); // 60개 
            Console.WriteLine("");

            Console.WriteLine("1. 상태보기");
            Console.WriteLine("2. 전투하기");
            Console.WriteLine("3. 인벤토리");
            Console.WriteLine("4. 상점");
            Console.WriteLine("");

            // 2. 선택한 결과를 검증한다.
            int choice = ConsoleUtility.PromptMenuChoice(1, 4);

            // 3. 선택한 결과에 따라 보내준다.
            switch (choice)
            {
                case 1:
                    //StatusMenu();
                    break;
                case 2:
                    //전투하기 메뉴 메소드
                    break;
                case 3:
                    //InventoryMenu();
                    break;
                case 4:
                    //StoreMenu();
                    break;
            }
            mainMenu();// 문제가 발생할 수 있으니 끝날 때 다시 호출해서 잡아주기.
        }

    }
}

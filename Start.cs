using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B02_TextRPG
{
    internal class Start
    {
        public static void startScene()
        {

            Console.Clear(); //화면정리

            //게임입장 시 멘트
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            Console.WriteLine("스파르타 던전에 오신 여러분 환영합니다.");
            Console.WriteLine("캐릭터를 생성하려면 이름을 입력하세요");
            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");

            Console.WriteLine();
            Console.Write(">>");

            string name = Console.ReadLine();
            Console.WriteLine("당신의 이름은 <" + name + "> 입니다."); 

            Console.WriteLine();
            Console.WriteLine("직업을 선택하세요 (전사, 마법사, 도적): ");

            string job = Console.ReadLine();   
            Console.WriteLine("당신의 직업은 <" + job + "> 입니다.");

            Player player = new Player(name, job);


            Console.WriteLine();
            Console.WriteLine("마을로 들어가려면 아무 키나 입력하세요");
            Console.ReadKey(); // 아무 키나 누르면 마을로 이동

            
            GameManager gameManager = new GameManager(); //게임매니저 인스턴스 생성      
            gameManager.StoreItems();
            gameManager.MainMenu();  // 마을로 가기
            
        }

       
    }

    
}

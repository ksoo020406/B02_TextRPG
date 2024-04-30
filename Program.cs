using System.Security.Cryptography.X509Certificates;

namespace B02_TextRPG
{
    public class GameManager
    {
        public GameManager() { }

        public static void StoreItems()
        {
            Store_B02.Store Armor1 = new Store_B02.Store("수련자의 갑옷", " 수련에 도움을 주는 갑옷입니다. ", 0, 5, 1000);
            Store_B02.Store Armor = new Store_B02.Store("무쇠 갑옷", "무쇠로 만들어져 튼튼한 갑옷입니다.", 0, 9, 2000);
            Store_B02.Store SpartaArmor = new Store_B02.Store("스파르타의 갑옷", "스파르타의 전사들이 사용했다는 전설의 갑옷입니다.", 0, 15, 3500);
            Store_B02.Store Spear = new Store_B02.Store("스파르타의 창", "스파르타의 전사들이 사용했다는 전설의 창입니다.", 7, 0, 1500);
            Store_B02.Store Sword = new Store_B02.Store("낡은 검", " 쉽게 볼 수 있는 낡은 검 입니다.", 2, 0, 600);
            Store_B02.Store axe = new Store_B02.Store("청동 도끼", " 어디선가 사용됐던거 같은 도끼입니다.", 7, 0, 1800);
            Store_B02.Store sujin = new Store_B02.Store("수진이의 사랑", "이 분의 사랑만 있으면 공격력이 올라갑니다.", 100, 0, 50000);

            Store_B02.Store.AddItem(Armor1);
            Store_B02.Store.AddItem(Armor);
            Store_B02.Store.AddItem(SpartaArmor);
            Store_B02.Store.AddItem(Spear);
            Store_B02.Store.AddItem(Sword);
            Store_B02.Store.AddItem(axe);
            Store_B02.Store.AddItem(sujin);
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Character character = new Character();
            GameManager gameManager = new GameManager();
            GameManager.StoreItems();
            //Store_B02.Store.ShowStore(character);

            static void mainMenu(Character character)
            {
                //Character character = new Character();


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
                        Inventory.ShowInventory();
                        break;
                    case 4:
                        Store_B02.Store.ShowStore(character);
                        break;
                }
                mainMenu(character);// 문제가 발생할 수 있으니 끝날 때 다시 호출해서 잡아주기.
            }

            mainMenu(character);
            //Character.ShowInfo();


        }
    }
}

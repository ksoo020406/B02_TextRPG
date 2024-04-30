using System.Security.Cryptography.X509Certificates;
using static B02_TextRPG.Store_B02;

namespace B02_TextRPG
{
    internal class Inventory
    {
        public string Name { get; set; }  // 아이템 이름 
        public string Description { get; set; }  // 아이템 설명 
        public int AttackPower { get; set; }  // 공격력 
        public int DefensePower { get; set; }   // 방어력 
        public int Gold { get; set; } // 가격 

        public bool Purchase { get; set; }
        public Inventory(string name, string des, int attack, int defense, int gold)
        {
            Name = name;
            Description = des;
            AttackPower = attack;
            DefensePower = defense;
            Gold = gold;
            Purchase = false;
        }

        public static List<Inventory> InventoryItems = new List<Inventory>();  // 인벤 아이템

        // 아이템 추가 메소드
        public static void AddItem(Inventory inventoryItems)
        {
            InventoryItems.Add(inventoryItems);
        }

        public static void ShowInventory()
        {
            Console.Clear();

            Console.WriteLine("**인벤토리**");
            //ConsoleUtility.ShowTitle("■ 인벤토리 ■");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine("");
            Console.WriteLine("[아이템 목록]");
            Console.WriteLine("");

            for (int i = 0; i < InventoryItems.Count; i++) // 리스트에는 항상 Count(몇 개?)라는 값이 있다.
            {
                string status = InventoryItems[i].Purchase ? "구매완료" : $"{InventoryItems[i].Gold} G";
                string Statistics = InventoryItems[i].AttackPower > 0 ? $"공격력: {InventoryItems[i].AttackPower}" :
                      InventoryItems[i].DefensePower > 0 ? $"방어력: {InventoryItems[i].DefensePower}" : "";
                Console.WriteLine($"- {InventoryItems[i].Name} | {Statistics} | {InventoryItems[i].Description} | {status}");
            }

            Console.WriteLine("");
            Console.WriteLine("1. 장착관리");
            Console.WriteLine("");
            Console.WriteLine("0. 나가기");
            Console.WriteLine("");

            switch (ConsoleUtility.PromptMenuChoice(0, 1))
            {
                case 0:
                    MainMenu.mainMenu();
                    break;
                case 1:
                    //EquipMenu();
                    break;
            }
        }
    }
}
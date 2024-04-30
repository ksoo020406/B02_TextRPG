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

       // public static List<Item> InventoryItems = new List<Item>();  // 인벤 아이템

        public static void ShowInventory()
        {
            Console.Clear();

            Console.WriteLine("**인벤토리**");
            //ConsoleUtility.ShowTitle("■ 인벤토리 ■");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine("");
            Console.WriteLine("[아이템 목록]");
            Console.WriteLine("");

            for (int i = 0; i < Item.InventoryItems.Count; i++) // 리스트에는 항상 Count(몇 개?)라는 값이 있다.
            {
                string status = Item.InventoryItems[i].Purchase ? "구매완료" : $"{Item.InventoryItems[i].Gold} G";
                string Statistics = Item.InventoryItems[i].AttackPower > 0 ? $"공격력: {Item.InventoryItems[i].AttackPower}" :
                      Item.InventoryItems[i].DefensePower > 0 ? $"방어력: {Item.InventoryItems[i].DefensePower}" : "";
                Console.WriteLine($"- {Item.InventoryItems[i].Name} | {Statistics} | {Item.InventoryItems[i].Description} | {status}");
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
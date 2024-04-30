using System.Security.Cryptography.X509Certificates;
using static B02_TextRPG.Store_B02;

namespace B02_TextRPG
{
    internal class Inventory
    {

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
                    return;
                case 1:
                    //EquipMenu();
                    break;
            }
        }
    }
}
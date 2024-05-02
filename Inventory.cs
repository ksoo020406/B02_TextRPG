using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using static B02_TextRPG.Store_B02;

namespace B02_TextRPG
{
    internal class Inventory
    {
        public static void ShowInventory(Player player)
        {
            Console.Clear();

            Console.WriteLine("");
            Console.WriteLine("**소지품 목록**");
            //ConsoleUtility.ShowTitle("■ 인벤토리 ■");
            Console.WriteLine("");
            Console.WriteLine("보유 중인 소지품을 관리할 수 있습니다.");
            Console.WriteLine("");
            Console.WriteLine("[아이템 목록]");
            Console.WriteLine("");

            for (int i = 0; i < Item.InventoryItems.Count; i++) // 리스트에는 항상 Count(몇 개?)라는 값이 있다.
            {
                //string status = Item.InventoryItems[i].Purchase ? "구매완료" : $"{Item.InventoryItems[i].Gold} G";
                //string Statistics = Item.InventoryItems[i].AttackPower > 0 ? $"공격력: {Item.InventoryItems[i].AttackPower}" :
                //                    Item.InventoryItems[i].DefensePower > 0 ? $"방어력: {Item.InventoryItems[i].DefensePower}" : "";
                //Console.WriteLine($"- {Item.InventoryItems[i].Name} | {Statistics} | {Item.InventoryItems[i].Description}");

                Item.InventoryItems[i].PrintItemStatChange();
            }

            Console.WriteLine("");
            Console.WriteLine("1. 장착관리");
            Console.WriteLine("");
            Console.WriteLine("0. 나가기");
            Console.WriteLine("");

            switch (ConsoleUtility.PromptMenuChoice(0, 1))
            {
                case 0:
                    GameManager gameManager = new GameManager();
                    gameManager.MainMenu(player);
                    break;
                case 1:
                    EquipMenu(player);
                    break;
            }
        }
        private static void EquipMenu(Player player)
        {
            Console.Clear();

            Console.WriteLine("");
            Console.WriteLine("**장착관리**");
            Console.WriteLine("");
            Console.WriteLine("장비의 장착관리를 할 수 있습니다.");
            Console.WriteLine("");
            Console.WriteLine("[아이템 목록]");
            Console.WriteLine("");

            for (int i = 0; i < Item.InventoryItems.Count; i++) // 리스트에는 항상 Count(몇 개?)라는 값이 있다.
            {
                Item.InventoryItems[i].PrintItemStatChange(true, i + 1);
            }

            Console.WriteLine("");
            Console.WriteLine("0. 돌아가기");
            Console.WriteLine("");

            int choiceItem = ConsoleUtility.PromptMenuChoice(0, Item.InventoryItems.Count); // 아이템 보유 종류에 따라 최대 갯수 달라진다.

            switch (choiceItem)
            {
                case 0:
                    ShowInventory(player);
                    break;
                default:
                    Item.InventoryItems[choiceItem - 1].ToggleEquip();

                    Item selectedItem = Item.InventoryItems[choiceItem - 1];
                    // 장비를 하면 능력치 더하기
                    if (selectedItem.Equipped)
                    {
                        player.AttackPlus += selectedItem.AttackPower;
                        player.DefensePlus += selectedItem.DefensePower;
                        // 선택한 아이템이 힐템이면
                        if (selectedItem.HealingPower > 0)
                        {
                            player.Health += selectedItem.HealingPower;

                            if (player.Health > 100)
                            {
                                player.Health = 100;
                            }
                            selectedItem.Purchase = false;
                            Item.InventoryItems.Remove(selectedItem);
                        }      
                    }
                    // 아니면 능력치 빼기
                    else
                    {
                        player.AttackPlus -= selectedItem.AttackPower;
                        player.DefensePlus -= selectedItem.DefensePower;
                    }

                    EquipMenu(player); // 장비 선택 하고서도 장착관리에 남아있어라.
                    break;
            }

        }
    }
}
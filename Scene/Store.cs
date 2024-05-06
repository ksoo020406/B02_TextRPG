using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace B02_TextRPG
{
    internal class Store_B02
    {
        public Store_B02(Player player)
        {

        }

        public static void ShowStore(Player player)
        {

            Console.Clear();

            Console.WriteLine("**상점**");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("[보유 골드]");
            Console.WriteLine($"{player.Gold} G");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("[구매한 아이템 목록]");
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < Item.InventoryItems.Count; i++) // 리스트에는 항상 Count(몇 개?)라는 값이 있다.
            {
                Console.Write($" - {i + 1}. "); Item.InventoryItems[i].PrintItemStatChange1();
            }
            Console.WriteLine();
            Console.WriteLine("1. 아이템 구매");
            Console.WriteLine("2. 아이템 판매");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("0. 나가기");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
            int input = ConsoleUtility.PromptMenuChoice(0, 2);

            if (input == 1)
            {
                PurchasedMogi(player);
            }
            else if (input == 2)
            {
                Resale(player);
            }
            else if (input == 0)
            {
                GameManager gm = new GameManager();
                gm.MainMenu(player);

            }


        }

        public static void PurchasedMogi(Player player)
        {

            Console.Clear();

            Console.WriteLine("**상점**");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("[보유 골드]");
            Console.WriteLine($"{player.Gold} G");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("[아이템 목록]");
            for (int i = 0; i < Item.storeItems.Count; i++)
            {
                Console.Write($" - {i + 1}. "); Item.storeItems[i].PrintItemStatChange1();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("0. 나가기");
            Console.ResetColor();
            int input = ConsoleUtility.PromptMenuChoice(0, Item.storeItems.Count);

            switch (input)
            {
                case 0: ShowStore(player); break;
                default:

                    if (Item.storeItems.Count >= input && 1 <= input)
                    {
                        Item selectedItem = Item.storeItems[input - 1];
                        if (selectedItem.Purchase)
                        {
                            // 아이템 구매
                            Console.WriteLine();
                            Console.WriteLine("이미 구매한 아이템 입니다! 다시 입력해 주세요!");
                            Thread.Sleep(800);
                            PurchasedMogi(player);

                        }
                        else if (player.Gold >= selectedItem.Gold)
                        {
                            // 재화 감소
                            player.Gold -= selectedItem.Gold;
                            // 구매 
                            selectedItem.Purchase = true;
                            // 구매한 아이템 리스트에 추가 
                            Item.InventoryItems.Add(selectedItem);

                            // 구매한 아이템이 InventoryItems에 추가 되고 나서
                            // 인벤토리 아이템에서 아이템 타입이 CONSUME면
                            if (selectedItem.ThisItemType == ItemType.CONSUME)
                            {
                                // ConsumeItems 리스트에 추가
                                Item.ConsumeItems.Add(selectedItem);
                            }

                            // 인벤토리 아이템에서 아이템 타입이 WEAPON 이거나 ARMOR 이면
                            if (selectedItem.ThisItemType == ItemType.WEAPON || selectedItem.ThisItemType == ItemType.ARMOR)
                            {
                                // EquippedItems 리스트에 추가
                                Item.EquippedItems.Add(selectedItem);
                            }

                            Console.WriteLine("구매를 완료했습니다!");
                            PurchasedMogi(player);
                        }
                        else if (player.Gold < selectedItem.Gold)
                        {

                            Console.WriteLine("골드가 부족합니다..");
                            Thread.Sleep(500);
                            PurchasedMogi(player);
                        }
                        else
                        {
                            Console.WriteLine("잘못된 입력입니다.");
                            Thread.Sleep(500);
                            PurchasedMogi(player);
                        }

                    }
                    ShowStore(player);
                    break;
            }



        }



        static void Resale(Player player)
        {
            Console.Clear();
            Console.WriteLine("상점 - 아이템 판매");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
            Console.WriteLine();
            Console.WriteLine($"보유 골드 {player.Gold} G");
            Console.WriteLine();
            Console.WriteLine("[아이템 목록]");
            Console.WriteLine();

            //보유한 아이템 목록 띄우기
            for (int i = 0; i < Item.InventoryItems.Count; i++)
            {
                if (Item.InventoryItems[i].ThisItemType == ItemType.WEAPON || Item.InventoryItems[i].ThisItemType == ItemType.ARMOR || Item.InventoryItems[i].ThisItemType == ItemType.CONSUME || Item.InventoryItems[i].ThisItemType == ItemType.SPECIAL)
                {
                    Console.Write($" - {i + 1}. "); Item.InventoryItems[i].PrintItemStatChange2();
                }
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("0. 나가기");
            Console.ResetColor();
            int input = ConsoleUtility.PromptMenuChoice(0, Item.InventoryItems.Count);


            switch (input)
            {
                case 0: ShowStore(player); break;
                default:
                    // 사용자 입력에 따라 선택된 아이템 인덱스 계산
                    int selectedItemIndex = input - 1;
                    Item selectedItem = Item.InventoryItems[selectedItemIndex];
                    if (selectedItemIndex >= 0 && selectedItemIndex < Item.InventoryItems.Count)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"'{selectedItem.Name}'을(를) {selectedItem.Gold * 0.85} G에 판매하였습니다.");
                        Console.ResetColor();

                        // 장착중이면 해제하고 리스트에서 삭제
                        if (Item.InventoryItems.Contains(selectedItem))
                        {
                            selectedItem.Purchase = false;
                            selectedItem.Equipped = false;
                            selectedItem.Consumed = false;

                            Item.InventoryItems.Remove(selectedItem);
                            Item.EquippedItems.Remove(selectedItem);
                            Item.ConsumeItems.Remove(selectedItem);
                            // 다시 원상태로
                            player.AttackPlus -= selectedItem.AttackPower;
                            player.DefensePlus -= selectedItem.DefensePower;

                            // 아이템 판매 및 골드 추가
                            player.Gold += (int)(selectedItem.Gold * 0.85);
                        }

                        Thread.Sleep(800);
                        Resale(player);

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("잘못된 입력입니다! 다시 입력해주세요!");
                        Console.ResetColor();
                        Thread.Sleep(700);
                        Resale(player);
                    }
                    break;

            }
        }


    }
}





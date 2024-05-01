using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B02_TextRPG
{
    internal class Store_B02
    {
        public Store_B02()
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
                string status = Item.InventoryItems[i].Purchase ? "구매완료" : $"{Item.InventoryItems[i].Gold} G";
                string Statistics = Item.InventoryItems[i].AttackPower > 0 ? $"공격력: {Item.InventoryItems[i].AttackPower}" :
                      Item.InventoryItems[i].DefensePower > 0 ? $"방어력: {Item.InventoryItems[i].DefensePower}" : "";
                Console.WriteLine($"- {Item.InventoryItems[i].Name} | {Statistics} | {Item.InventoryItems[i].Description} | {status}");
            }
            Console.WriteLine();
            Console.WriteLine("1. 아이템 구매");
            Console.WriteLine("2. 아이템 판매");
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\n원하시는 행동을 입력해주세요.");
            Console.Write(">> ");
            int input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                PurchasedMogi(player);
            }
            else if (input == 2)
            {
                Resale(player);
            }
            else
            {
                // 다시 메인 화면으로 현재 메소드 종료 
                return;
                
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
                string status = Item.storeItems[i].Purchase ? "구매완료" : $"{Item.storeItems[i].Gold} G";
                string Statistics = Item.storeItems[i].AttackPower > 0 ? $"공격력: {Item.storeItems[i].AttackPower}" :
                      Item.storeItems[i].DefensePower > 0 ? $"방어력: {Item.storeItems[i].DefensePower}" : "";
                Console.WriteLine($"- {i + 1}. {Item.storeItems[i].Name} | {Statistics} | {Item.storeItems[i].Description} | {status}");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("구매할 아이템의 번호를 누르세요.");
            Console.Write(">> ");
            Console.WriteLine();
            Console.WriteLine();
            int input = int.Parse(Console.ReadLine());

            // input 값 확인하기 
            if (Item.storeItems.Count >= input && 1 <= input)
            {
                Item selectedItem = Item.storeItems[input - 1];
                if (selectedItem.Purchase)
                {
                    // 아이템 구매
                    Console.WriteLine("이미 구매한 아이템 입니다!");
                
                }
                else if (player.Gold >= selectedItem.Gold)
                {
                    // 재화 감소
                    player.Gold -= selectedItem.Gold;
                    selectedItem.Purchase = true;
                    // 구매한 아이템 리스트에 추가 
                    Item.InventoryItems.Add(selectedItem);
                    Console.WriteLine("구매를 완료했습니다!");
                    ShowStore(player);
                }
                else if (player.Gold < selectedItem.Gold)
                {
                    Console.WriteLine("골드가 부족합니다..");
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");
                }
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
            int index = 1;
            for (int i = 0; i < Item.InventoryItems.Count; i++)
            {
                if (Item.InventoryItems[i].Purchase)
                {
                    string equipped = Item.equippedItems.Contains(Item.InventoryItems[i]) ? "[E]" : "";
                    string Statistics = Item.InventoryItems[i].AttackPower > 0 ? $"공격력: {Item.InventoryItems[i].AttackPower}" :
                      Item.InventoryItems[i].DefensePower > 0 ? $"방어력: {Item.InventoryItems[i].DefensePower}" : "";
                    Console.WriteLine($"{index}. {equipped} {Item.InventoryItems[i].Name} | {Statistics} | {Item.InventoryItems[i].Description}");
                    index++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("판매할 아이템의 번호를 눌러주세요.");
            Console.Write(">>");
            int input = int.Parse(Console.ReadLine());


            switch (input)
            {
                case 0: return;
                default:
                //    Console.Clear();

                    // 사용자 입력에 따라 선택된 아이템 인덱스 계산
                    int selectedItemIndex = input - 1;
                    Item selectedItem = Item.InventoryItems[selectedItemIndex];
                    if (selectedItemIndex >= 0 && selectedItemIndex < Item.InventoryItems.Count)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine($"'{selectedItem.Name}'을(를) {selectedItem.Gold * 0.85} G에 판매하였습니다.");

                        // 장착중이면 해제
                        if (Item.InventoryItems.Contains(selectedItem))
                        {
                            selectedItem.Purchase = false;
                            Item.InventoryItems.Remove(selectedItem);
                        }
                        // 아이템 판매 및 골드 추가
                        player.Gold += (int)(selectedItem.Gold * 0.85);
                        Item.InventoryItems.Remove(selectedItem);
                        // 다시 원상태로
                        player.Attack -= selectedItem.AttackPower;
                        player.Defense -= selectedItem.DefensePower;

                    }
                    else
                    {
                        Console.WriteLine("**잘못된 입력입니다**");
                    }
                    break;

            }
            Console.WriteLine("\n아무 키나 누르세요...");
            Console.ReadKey();
            ShowStore(player);
        }


    }
}





﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace B02_TextRPG
//{
//    internal class Store_B02
//    {
//        public class Store
//        {
//            public string Name { get; set; }  // 아이템 이름 
//            public string Description { get; set; }  // 아이템 설명 
//            public int AttackPower { get; set; }  // 공격력 
//            public int DefensePower { get; set; }   // 방어력 
//            public int Gold { get; set; } // 가격 
//            public Store(string name, string des, int attack, int defense, int gold)
//            {
//                Name = name;
//                Description = des;
//                AttackPower = attack;
//                DefensePower = defense;
//                Gold = gold;
//            }


//            public static void ShowStore(Inventory inventory, Character character)
//            {
//                Console.Clear();

//                Console.WriteLine("**상점**");
//                Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
//                Console.WriteLine();
//                Console.WriteLine();
//                Console.WriteLine("[보유 골드]");
//                Console.WriteLine($"{character.Gold} G");
//                Console.WriteLine();
//                Console.WriteLine();
//                Console.WriteLine("[아이템 목록]");
//                Console.WriteLine();
//                Console.WriteLine();
//                for (int i = 0; i < Inventory.items.Count; i++)
//                {
//                    string status = Inventory.items[i].Purchase ? "구매완료" : $"{Inventory.items[i].Gold} G";
//                    string Statistics = Inventory.items[i].AttackPower > 0 ? $"공격력: {Inventory.items[i].AttackPower}" :
//                          Inventory.items[i].DefensePower > 0 ? $"방어력: {Inventory.items[i].DefensePower}" : "";
//                    Console.WriteLine($"- {Inventory.items[i].Name} | {Statistics} | {Inventory.items[i].Description} | {status}");
//                }
//                Console.WriteLine();
//                Console.WriteLine("1. 아이템 구매");
//                Console.WriteLine("2. 아이템 판매");
//                Console.WriteLine("0. 나가기");
//                Console.WriteLine();
//                Console.WriteLine();
//                Console.WriteLine("\n원하시는 행동을 입력해주세요.");
//                Console.Write(">> ");
//                int input = int.Parse(Console.ReadLine());

//                if (input == 1)
//                {
//                    PurchasedMogi(character, inventory);
//                }
//                else if (input == 2)
//                {
//                    Resale(character, inventory);
//                }
//                else
//                {
//                    // 나가기 
//                }


//            }

//            public static void PurchasedMogi(Character character, Inventory inventory)
//            {
//                Console.Clear();


//                for (int i = 0; i < Inventory.items.Count; i++)
//                {
//                    string status = Inventory.items[i].Purchase ? "구매완료" : $"{Inventory.items[i].Gold} G";
//                    string Statistics = Inventory.items[i].AttackPower > 0 ? $"공격력: {Inventory.items[i].AttackPower}" :
//                          Inventory.items[i].DefensePower > 0 ? $"방어력: {Inventory.items[i].DefensePower}" : "";
//                    Console.WriteLine($"- {i + 1}. {Inventory.items[i].Name} | {Statistics} | {Inventory.items[i].Description} | {status}");
//                }
//                Console.WriteLine();
//                Console.WriteLine();
//                Console.WriteLine("구매할 아이템의 번호를 누르세요.");
//                Console.Write(">> ");
//                Console.WriteLine();
//                Console.WriteLine();
//                int input = int.Parse(Console.ReadLine());

//                // input 값 확인하기 
//                if (Inventory.items.Count >= input && 1 <= input)
//                {
//                    Item selectedItem = Inventory.items[input - 1];
//                    if (selectedItem.Purchase)
//                    {
//                        // 아이템 구매
//                        Console.WriteLine("이미 구매한 아이템 입니다!");
//                    }
//                    else if (character.Gold >= selectedItem.Gold)
//                    {
//                        // 재화 감소
//                        character.Gold -= selectedItem.Gold;
//                        selectedItem.Purchase = true;
//                        Inventory.PurchaseItems.Add(selectedItem);  // 인벤토리에 추가 
//                        Console.WriteLine("구매를 완료했습니다!");
//                    }
//                    else if (character.Gold < selectedItem.Gold)
//                    {
//                        Console.WriteLine("골드가 부족합니다..");
//                    }
//                    else
//                    {
//                        Console.WriteLine("잘못된 입력입니다.");
//                    }
//                }
//            }

//            static void Resale(Character character, Inventory inventory)
//            {
//                Console.Clear();


//                Console.WriteLine();
//                Console.WriteLine();
//                Console.WriteLine("상점 - 아이템 판매");
//                Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
//                Console.WriteLine();
//                Console.WriteLine($"보유 골드 {character.Gold} G");
//                Console.WriteLine();
//                Console.WriteLine("[아이템 목록]");
//                Console.WriteLine();
//                int index = 1;
//                for (int i = 0; i < Inventory.PurchaseItems.Count; i++)
//                {
//                    if (Inventory.PurchaseItems[i].Purchase)
//                    {
//                        string equipped = Inventory.equippedItems.Contains(Inventory.PurchaseItems[i]) ? "[E]" : "";
//                        string Statistics = Inventory.PurchaseItems[i].AttackPower > 0 ? $"공격력: {Inventory.PurchaseItems[i].AttackPower}" :
//                          Inventory.PurchaseItems[i].DefensePower > 0 ? $"방어력: {Inventory.PurchaseItems[i].DefensePower}" : "";
//                        Console.WriteLine($"{index}. {equipped} {Inventory.PurchaseItems[i].Name} | {Statistics} | {Inventory.PurchaseItems[i].Description}");
//                        index++;
//                    }
//                }
//                Console.WriteLine();
//                Console.WriteLine("판매할 아이템의 번호를 눌러주세요.");
//                Console.Write(">>");
//                int input = int.Parse(Console.ReadLine());


//                switch (input)
//                {
//                    case 0: return;
//                    default:
//                        Console.Clear();

//                        // 사용자 입력에 따라 선택된 아이템 인덱스 계산
//                        int selectedItemIndex = input - 1;
//                        Item selectedItem = Inventory.PurchaseItems[selectedItemIndex];
//                        if (selectedItemIndex >= 0 && selectedItemIndex < Inventory.PurchaseItems.Count)
//                        {
//                            Console.WriteLine($"'{selectedItem.Name}'을(를) {selectedItem.Gold * 0.85} G에 판매하였습니다.");

//                            // 장착중이면 해제
//                            if (Inventory.equippedItems.Contains(selectedItem))
//                            {
//                                Inventory.equippedItems.Remove(selectedItem);
//                            }
//                            // 아이템 판매 및 골드 추가
//                            character.Gold += (int)(selectedItem.Gold * 0.85);
//                            Inventory.PurchaseItems.Remove(selectedItem);
//                            // 다시 원상태로
//                            character.Attack -= selectedItem.AttackPower;
//                            character.Defense -= selectedItem.DefensePower;

//                        }
//                        else
//                        {
//                            Console.WriteLine("**잘못된 입력입니다**");
//                        }
//                        break;

//                }
//            }


//        }
//    }
//}
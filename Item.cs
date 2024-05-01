using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B02_TextRPG
{
    internal class Item
    {
        public string Name { get; set; }  // 아이템 이름 
        public string Description { get; set; }  // 아이템 설명 
        public int AttackPower { get; set; }  // 공격력 
        public int DefensePower { get; set; }   // 방어력 
        public int Gold { get; } // 가격

        public bool Purchase { get; set; }
        public bool Equipped { get; private set; }
        //public Item()
        //{

        //}

        public static List<Item> InventoryItems = new List<Item>();  // 인벤 아이템

        public static List<Item> storeItems = new List<Item>();  // 상점 아이템

        public static List<Item> equippedItems = new List<Item>();  // 장착 아이템 

        public Item(string name, string description, int attack, int defense, int gold, bool equipped = false)
        {
            Name = name;
            Description = description;
            AttackPower = attack;
            DefensePower = defense;
            Gold = gold;
            Purchase = false;
            Equipped = equipped;
        }

        // 아이템 추가 메소드
        public void AddItem(Item store)
        {
            storeItems.Add(store);
        }

        // 아이템 추가 메소드
        public void AddInvenItem(Item inventoryItems)
        {
            InventoryItems.Add(inventoryItems);
            equippedItems.Add(inventoryItems);
        }

        internal void PrintItemStatChange(bool anOptionNumber = false, int idx = 0)
        {
            
            if (anOptionNumber && !Equipped) // 장착 전 표시
            {
                Console.Write($"{idx}. ");
            }
            else Console.Write("   "); //장착 후 표시1

            if (Equipped) // 장착 후 표시2
            {
                Console.Write("[E]");

                Console.Write(ConsoleUtility.SpacingLetters(Name, 16));
            }
            else Console.Write(ConsoleUtility.SpacingLetters(Name, 19));//[E]+16

            string Statistics = AttackPower > 0 ? $"공격력: {AttackPower}" :
                                DefensePower > 0 ? $"방어력: {DefensePower}" : "";

            Console.Write(" | ");
            Console.Write(ConsoleUtility.SpacingLetters(Statistics, 12));
            Console.Write(" | ");
            Console.WriteLine(ConsoleUtility.SpacingLetters(Description, 50));

        }

        //장착관리용 메소드
        internal void ToggleEquip()
        {
            Equipped = !Equipped; // 장착됨의 반대
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B02_TextRPG
{
    public enum ItemType // 아이템 카테고리 지정
    {
        WEAPON, ARMOR, CONSUME, SPECIAL
    }

    internal class Item
    {
        public ItemType ThisItemType;
        //public string ItemType { get; set; }

        public string Name { get; set; }  // 아이템 이름 
        public string Description { get; set; }  // 아이템 설명 
        public int AttackPower { get; set; }  // 공격력 
        public int DefensePower { get; set; }   // 방어력 
        public int HealingPower { get; set; } // 힐링 
        public int Gold { get; } // 가격

        public bool Purchase { get; set; }
        public bool Equipped { get; set; }
        public bool Consumed { get; set; }
        //public Item()
        //{

        //}

        public static List<Item> InventoryItems = new List<Item>();  // 인벤 아이템

        public static List<Item> storeItems = new List<Item>();  // 상점 아이템

        public static List<Item> EquippedItems = new List<Item>();  // 장착 아이템 
        public static List<Item> ConsumeItems = new List<Item>();  // 소비 아이템 


        // 능력치 아이템
        public Item(ItemType thisItemType, string name, string description, int attack, int defense, int gold, bool equipped = false)
        {
            ThisItemType = thisItemType;
            Name = name;
            Description = description;
            AttackPower = attack;
            DefensePower = defense;
            Gold = gold;
            Purchase = false;
            Equipped = equipped;
        }

        // 힐 아이템
        public Item(ItemType thisItemType, string name, string description, int heal, int gold, bool equipped = false, bool consumed = false)
        {
            ThisItemType = thisItemType;
            Name = name;
            Description = description;
            HealingPower = heal;
            Gold = gold;
            Purchase = false;
            Equipped = equipped;
            Consumed = consumed; // 소비 판단을 위한 변수
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
            EquippedItems.Add(inventoryItems);
            ConsumeItems.Add(inventoryItems);
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
                                DefensePower > 0 ? $"방어력: {DefensePower}" :
                                HealingPower > 0 ? $"체력: {HealingPower}" : "";

            Console.Write(" | ");
            Console.Write(ConsoleUtility.SpacingLetters(Statistics, 12));
            Console.Write(" | ");
            Console.WriteLine(ConsoleUtility.SpacingLetters(Description, 50));

        }

        internal void PrintItemStatChange1(bool anOptionNumber = false, int idx = 0)
        {

            Console.Write(ConsoleUtility.SpacingLetters(Name, 16));


            string Statistics = AttackPower > 0 ? $"공격력: {AttackPower}" :
                                DefensePower > 0 ? $"방어력: {DefensePower}" :
                                HealingPower > 0 ? $"체력: {HealingPower}" : "";

            Console.Write(" | ");
            Console.Write(ConsoleUtility.SpacingLetters(Statistics, 12));
            Console.Write(" | ");
            Console.Write(ConsoleUtility.SpacingLetters(Description, 50));
            Console.Write(" | ");
            string status = Purchase ? "구매완료" : $"{Gold} G";
            Console.WriteLine(ConsoleUtility.SpacingLetters(status, 5));

        }

        internal void PrintItemStatChange2(bool anOptionNumber = false, int idx = 0)
        {
            if (anOptionNumber && !Equipped) // 장착 전 표시
            {
                Console.Write($"");
            }
            if (Equipped) // 장착 후 표시2
            {
                Console.Write("[E]");

                Console.Write(ConsoleUtility.SpacingLetters(Name, 16));
            }
            else Console.Write(ConsoleUtility.SpacingLetters(Name, 19));//[E]+16

            string Statistics = AttackPower > 0 ? $"공격력: {AttackPower}" :
                                DefensePower > 0 ? $"방어력: {DefensePower}" :
                                HealingPower > 0 ? $"체력: {HealingPower}" : "";

            Console.Write(" | ");
            Console.Write(ConsoleUtility.SpacingLetters(Statistics, 12));
            Console.Write(" | ");
            Console.Write(ConsoleUtility.SpacingLetters(Description, 50));
            Console.Write(" | ");

            int gold = Gold;

            string status = $"판매액 {gold * 0.85} G";
            Console.WriteLine(ConsoleUtility.SpacingLetters(status, 10));

        }

        //장착관리용 메소드
        internal void ToggleEquip()
        {
            Equipped = !Equipped; // 장착됨의 반대
        }

        //소비관리용 메소드

        internal void ToggleConsume()
        {
            Consumed = !Consumed; // 사용됨의 반대
        }

    }
}

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

        public Item()
        {

        }

        public static List<Item> InventoryItems = new List<Item>();  // 인벤 아이템

        public static List<Item> storeItems = new List<Item>();  // 상점 아이템

        public Item(string name, string description, int attack, int defense, int gold)
        {
            Name = name;
            Description = description;
            AttackPower = attack;
            DefensePower = defense;
            Gold = gold;
            Purchase = false;
        }

        // 아이템 추가 메소드
        public  void AddItem(Item store)
        {
            storeItems.Add(store);
        }

        // 아이템 추가 메소드
        public  void AddInvenItem(Item inventoryItems)
        {
            InventoryItems.Add(inventoryItems);
        }

    }
}

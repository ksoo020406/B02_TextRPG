using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace B02_TextRPG
{
    internal class Farming
    {
        public static void FarmingStage(Player player)
        {
            Console.Clear();

            Console.WriteLine("");
            Console.WriteLine("이곳은 임시 파밍장입니다.");
            Console.WriteLine("");

            Console.WriteLine("");
            Console.WriteLine("무엇을 하고 싶습니까?");
            Console.WriteLine("");
            Console.WriteLine("[보유 골드]");
            Console.WriteLine($"{player.Gold} G");
            Console.WriteLine("");


            Console.WriteLine("");
            Console.WriteLine("1. 돈 파밍");
            Console.WriteLine("2. 템 파밍");
            Console.WriteLine("");
            Console.WriteLine("0. 돌아가기");
            Console.WriteLine("");

            // 2. 선택한 결과를 검증한다.
            int choice = ConsoleUtility.PromptMenuChoice(0, 2);
            // 3. 선택한 결과에 따라 보내준다.
            switch (choice)
            {
                case 0:
                    GameManager gameManager = new GameManager();
                    gameManager.MainMenu(player);
                    break;
                case 1:
                    GiveMoney(player);
                    break;
                case 2:
                    GiveItem(player);
                    break;
            }

        }

        public static void GiveMoney(Player player, string? prompt = null)
        {
            if (prompt != null)
            {
                Console.Clear();
                ShowTitle(prompt);
                Thread.Sleep(1000);
            }

            Console.Clear();

            Console.WriteLine("[보유 골드]");
            Console.WriteLine($"{player.Gold} G");
            Console.WriteLine("");

            Console.WriteLine("돈을 얻고 싶으면 '돈줘'를 치세요");
            Console.WriteLine("");
            Console.WriteLine("나가고 싶다면 아무렇게나 치세요");
            Console.WriteLine("");

            // 유저가 될 때까지 시도할 수 있게 하기 위해 while (true)
            while (true)
            {
                Console.Write("원하시는 내용을 입력해주세요 : ");

                string one = Console.ReadLine();

                if (one == "돈줘")
                {
                    int cheatMoney = 1000;
                    player.Gold += cheatMoney;
                    GiveMoney(player, "당신은 "+ cheatMoney + " G 를 얻었다.");
                    return;
                }
                else FarmingStage(player);

            }
        }

        public static void GiveItem(Player player, string? prompt = null)
        {
            if (prompt != null)
            {
                Console.Clear();
                ShowTitle(prompt);
                Thread.Sleep(1000);
            }

            Console.Clear();

            Console.WriteLine("[소지품 목록]");

            for (int i = 0; i < Item.InventoryItems.Count; i++) // 리스트에는 항상 Count(몇 개?)라는 값이 있다.
            {
                Item.InventoryItems[i].PrintItemStatChange(true, i + 1);
            }

            Console.WriteLine("");
            Console.WriteLine("아이템을 얻고 싶으면 '템줘'를 치세요");
            Console.WriteLine("");
            Console.WriteLine("나가고 싶다면 아무렇게나 치세요");
            Console.WriteLine("");

            // 유저가 될 때까지 시도할 수 있게 하기 위해 while (true)
            while (true)
            {
                Console.Write("원하시는 내용을 입력해주세요 : ");

                string one = Console.ReadLine();

                if (one == "템줘")
                {
                    Random random = new Random();
                    int randomIdx = random.Next(Item.storeItems.Count);

                    Item cheatItem = Item.storeItems[randomIdx];

                    Item.InventoryItems.Add(cheatItem);

                    if (cheatItem.ThisItemType == ItemType.CONSUME)
                    {
                        // ConsumeItems 리스트에 추가
                        Item.ConsumeItems.Add(cheatItem);
                    }

                    // 인벤토리 아이템에서 아이템 타입이 WEAPON 이거나 ARMOR 이면
                    if (cheatItem.ThisItemType == ItemType.WEAPON || cheatItem.ThisItemType == ItemType.ARMOR)
                    {
                        // EquippedItems 리스트에 추가
                        Item.EquippedItems.Add(cheatItem);
                    }


                    GiveItem(player, "당신은 "+ cheatItem.Name+"아이템 얻었다.");
                    return;

                }
                else FarmingStage(player);

            }
        }





        internal static void ShowTitle(string title)
        {
            Console.ForegroundColor = ConsoleColor.Magenta; //ForegtoundColor = 전경색
            Console.WriteLine(title);
            Console.ResetColor(); // 리셋해주지 않으면 계속 Magenta가 나온다.
        }
    }
}


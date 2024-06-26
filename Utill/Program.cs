﻿using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.Numerics;



namespace B02_TextRPG
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GameManager gameManager = new GameManager();
            gameManager.GameIntro();
            
        }
    }
    public class GameManager
    {
        private Player player;
        private BattleManager battleManager;

        public GameManager()
        {
           
        }


        public void StoreItems(Player player)
        {

            Item Armor1 = new Item(ItemType.ARMOR, "수련자의 갑옷", "수련에 도움을 주는 갑옷입니다.", 0, 5, 1000);
            Item Armor = new Item(ItemType.ARMOR, "무쇠 갑옷", "무쇠로 만들어져 튼튼한 갑옷입니다.", 0, 9, 2000);
            Item SpartaArmor = new Item(ItemType.ARMOR, "스파르타의 갑옷", "스파르타의 전사들이 사용했다는 전설의 갑옷입니다.", 0, 15, 3500);

            Item Spear = new Item(ItemType.WEAPON, "스파르타의 창", "스파르타의 전사들이 사용했다는 전설의 창입니다.", 7, 0, 1500);
            Item Sword = new Item(ItemType.WEAPON, "낡은 검", "쉽게 볼 수 있는 낡은 검 입니다.", 2, 0, 600);
            Item axe = new Item(ItemType.WEAPON, "청동 도끼", "어디선가 사용됐던거 같은 도끼입니다.", 7, 0, 1800);

            Item sujin = new Item(ItemType.SPECIAL, "수진이의 사랑", "이 분의 사랑만 있으면 공격력이 올라갑니다.", 100, 0, 50000);

            Item potion = new Item(ItemType.CONSUME,"백두산 물", "백두산에서 흐르는 물로 만들었습니다.(1회성)",20,300);
            Item sujins = new Item(ItemType.CONSUME, "수진이의 눈물", "이 분의 눈물만 있으면 체력이 다 채워집니다.(1회성)", 100, 1000);

            Item.storeItems.Add(Armor1);
            Item.storeItems.Add(Armor);
            Item.storeItems.Add(SpartaArmor);
            Item.storeItems.Add(Spear);
            Item.storeItems.Add(Sword);
            Item.storeItems.Add(axe);
            Item.storeItems.Add(sujin);
            Item.storeItems.Add(potion);
            Item.storeItems.Add(sujins);
        }

        public void GameIntro()
        {
            Console.Clear();
            Title.TitleText();
            Start.startScene();
        }

        public void MainMenu(Player player)
        {
            while (true)
            {
                // 구성
                // 0. 화면 정리
                Console.Clear();

                // 1. 선택 멘트를 준다.
                Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■"); // 60개 
                Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
                Console.WriteLine("이곳에서 던전으로 들어가기 전활동을 할 수 있습니다.");
                Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■"); // 60개 
                Console.WriteLine("");

                Console.WriteLine("1. 상태보기");
                Console.WriteLine("2. 던전가기");
                Console.WriteLine("3. 인벤토리");
                Console.WriteLine("4. 상점");
                Console.WriteLine("5. 퀘스트");
                Console.WriteLine("");
                Console.WriteLine("0. 종료");
                Console.WriteLine("");
                Console.WriteLine("9. 임시 아이템 파밍장");
                Console.WriteLine("");



                // 2. 선택한 결과를 검증한다.
                int choice = ConsoleUtility.PromptMenuChoice(0, 9);
                // 3. 선택한 결과에 따라 보내준다.
                switch (choice)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        Player.ShowInfo(player.Level, player.Name, player.Job, player.Attack, player.Defense, player.Health, player.Gold, player.AttackPlus, player.DefensePlus);
                        break;
                    case 2:
                        DunGeon.StartDunGeon(player);
                        break;
                    case 3:
                        Inventory.ShowInventory(player);
                        break;
                    case 4:
                        Store_B02.ShowStore(player);
                        break;
                    case 5:
                        QuestManager.Quest(player);
                        break;
                    case 9:
                        Farming.FarmingStage(player);
                        break;
                }

                MainMenu(player);// 문제가 발생할 수 있으니 끝날 때 다시 호출해서 잡아주기.

            }

        }


    }


}

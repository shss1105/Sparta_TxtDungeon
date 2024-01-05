using System.Net.NetworkInformation;
using System.Collections.Generic;
using static spartaTxt.Program;

namespace spartaTxt
{
    internal class Program
    {
        public class Item
        {
            public string itemName;
            public int itemType;  // item type이 0이면 방어 아이템, 1이면 공격 아이템
            public int itemOption; // + 수치
            public string itemDes;  // 아이템 설명
            public int itemPrice;
            bool isSold = false;  // 구매 완료인지 아닌지

            public Item()
            {

            }

            public Item(string itemName, int itemType, int itemOption, string itemDes, int itemPrice, bool isSold)
            {
                if (itemType == 0)
                {
                    Console.WriteLine($"- {itemName} | 방어력 +{itemOption} | {itemDes} | {itemPrice}G");
                }
                else if (itemType == 1)
                {
                    Console.WriteLine($"- {itemName} | 공격력 +{itemOption} | {itemDes} | {itemPrice}G");
                }
            }
        }

        public class Player
        {
            public int Lv;
            public string Name;
            public string Job;
            public int Damage;
            public int armor;
            public int Health;
            public int Gold;
            public List<Item> playerItems;
            
            

            public Player()
            {

            }

            public Player(int Lv, string Name, string Job, int Damage, int armor, int Health, int Gold)
            {

            }

            public void PrintInfo() // 상태창
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow; // 색변경
                Console.WriteLine("상태 보기");
                Console.ResetColor();
                Console.WriteLine("캐릭터의 정보가 표시됩니다.");
                Console.WriteLine();
                Console.WriteLine($"Lv. {Lv}");
                Console.WriteLine($"{Name} ({Job})");
                Console.WriteLine($"공격력 : {Damage}");
                Console.WriteLine($"방어력 : {armor}");
                Console.WriteLine($"체력 : {Health}");
                Console.WriteLine($"Gold : {Gold}");
            }

            public void BuyItem(Item item)
            {
                playerItems.Add(item);
                Gold -= item.itemPrice;// 플레이어 아이템 리스트에 아이템 추가
            }

            public void PrintInventory()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("인벤토리");
                Console.ResetColor();
                Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
                playerItems = new List<Item>(); 

                if (playerItems.Count > 0)
                {
                    Console.WriteLine("보유중인 아이템 출력");
                }
                else
                {
                    Console.WriteLine("보유중인 아이템이 없습니다.");
                }
            }


            public void EquipItem()
            {
                // if 장착중이지 않다면 --> 장착
                // else 장착중이라면 --> 해제
            }
        }

        public class Market
        {
            public List<Item> MarketItem;

            public Market()
            {

            }

            public void MakeMarketItem()
            {
                MarketItem = new List<Item>();
            }
            public void PrintMarketItem()
            {
                Console.ForegroundColor = ConsoleColor.Yellow; 
                Console.WriteLine("상점");
                Console.ResetColor(); 
                Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
                Console.WriteLine();
                Console.WriteLine($"[보유 골드]\n800 G"); // 보유 골드를 어떻게 표시할까?
                Console.WriteLine();
                Console.WriteLine("[아이템 목록]");
                Console.WriteLine();
                MarketItem.Add(new Item("수련자 갑옷", 0, 5, "수련에 도움을 주는 갑옷입니다.", 1000, false));
                MarketItem.Add(new Item("무쇠갑옷", 0, 9, "무쇠로 만들어져 튼튼한 갑옷입니다.", 2400, false));
                MarketItem.Add(new Item("스파르타의 갑옷", 0, 15, "스파르타의 전사들이 사용했다는 전설의 갑옷입니다.", 3500, false));
                MarketItem.Add(new Item("낡은 검", 1, 2, "쉽게 볼 수 있는 낡은 검 입니다.", 600, false));
                MarketItem.Add(new Item("청동 도끼", 1, 5, "어디선가 사용됐던거 같은 도끼입니다.", 1500, false));
                MarketItem.Add(new Item("스파르타의 창", 1, 7, "스파르타의 전사들이 사용했다는 전설의 창입니다.", 2100, false));
            }

            public void Trade()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow; 
                Console.WriteLine("상점 - 아이템 구매");
                Console.ResetColor(); 
                Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
                Console.WriteLine();
                Console.WriteLine($"[보유 골드]\n800 G"); 
                Console.WriteLine();
                Console.WriteLine("[아이템 목록]");

                if (MarketItem.Count > 0)
                {
                    int idx = 1;
                    foreach (Item item in MarketItem)  
                    {
                        Console.WriteLine("{0}. {1} | {2} | {3} | {4}", idx, item.itemName, item.itemOption, item.itemDes, item.itemPrice);
                        idx++;
                    }
                }
                else
                {
                    Console.WriteLine("보유중인 아이템이 없습니다.");
                }
            }
           
        }

        static void Main(string[] args)
        {
            StartScene();
            Market market = new Market();
            Player player1 = new Player();
            player1.Name = "rtan";
            player1.Job = "전사";
            player1.Damage = 5;
            player1.armor = 1;
            player1.Health = 10;
            player1.Gold = 100;
            


            bool isPlaying = true;

            while (isPlaying)
            {
                int StartSceneNum = int.Parse(Console.ReadLine());

                if (StartSceneNum == 1)
                {
                    player1.PrintInfo();
                    Console.WriteLine();
                    Console.WriteLine("0. 나가기");
                    Console.WriteLine();
                    Console.WriteLine("원하시는 행동을 입력해주세요.\n>>");
                    int InfoNum = int.Parse(Console.ReadLine());
                    if (InfoNum == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("초기 화면으로 돌아갑니다.");
                        StartScene();
                    }
                    else
                    {
                        Console.WriteLine("잘못된 입력입니다.\n1. 상태 보기\n2. 인벤토리\n3. 상점\n원하시는 행동을 입력해주세요.\n>>");
                    }
                }
                else if (StartSceneNum == 2)
                {
                    player1.PrintInventory();
                    Console.WriteLine();
                    Console.WriteLine("1. 장착관리");
                    Console.WriteLine("0. 나가기");
                    int InventoryNum = int.Parse(Console.ReadLine());
                    if (InventoryNum == 1)
                    {
                        Console.WriteLine("장착관리 실행");
                        break;
                    }
                    if (InventoryNum == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("초기 화면으로 돌아갑니다.");
                        StartScene();
                    }
                    else
                    {
                        Console.WriteLine("잘못된 입력입니다.\n1. 상태 보기\n2. 인벤토리\n3. 상점\n원하시는 행동을 입력해주세요.\n>>");
                    }

                }
                else if (StartSceneNum == 3)
                {
                    market.MakeMarketItem();
                    market.PrintMarketItem();
                    Console.WriteLine();
                    Console.WriteLine("1. 아이템 구매");
                    Console.WriteLine("0. 나가기");
                    int MarketNum1 = int.Parse(Console.ReadLine());
                    if (MarketNum1 == 1)
                    {
                        market.Trade();
                        Console.WriteLine();
                        Console.WriteLine("0. 나가기");
                    }
                    if (MarketNum1 == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("초기 화면으로 돌아갑니다.");
                        StartScene();
                    }
                    else
                    {
                        Console.WriteLine("잘못된 입력입니다.\n1. 상태 보기\n2. 인벤토리\n3. 상점\n원하시는 행동을 입력해주세요.\n>>");
                    }
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");
                }
            }
        }

        public static void StartScene()
        {
            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다\n이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("1. 상태 보기\n2. 인벤토리\n3. 상점");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.\n>>");
        }

    }
}
namespace SpartaTxt_Dungeon
{
    internal class startScene
    {
        static void Main(string[] args)
        {
            StartScene();

        }

        public static void StartScene() //게임 시작 화면
        {
            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다\n이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("1. 상태 보기\n2. 인벤토리\n3. 상점");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.\n>>");


            while (true)
            {
                //Player player1 = new Player();
                //Market market = new Market();
                //player1.Name = "rtan";
                //player1.Job = "전사";
                //player1.Damage = 5;
                //player1.armor = 1;
                //player1.Health = 10;
                //player1.Gold = 100;
                int StartSceneNum = int.Parse(Console.ReadLine());

                if (StartSceneNum == 1)
                {
                    //player1.PrintInfo();
                    Console.WriteLine();
                    Console.WriteLine("0. 나가기");
                    Console.WriteLine();
                    Console.WriteLine("원하시는 행동을 입력해주세요.\n>>");
                    int InfoNum = int.Parse(Console.ReadLine());
                    if (InfoNum == 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("잘못된 입력입니다.\n1. 상태 보기\n2. 인벤토리\n3. 상점\n원하시는 행동을 입력해주세요.\n>>");
                    }
                }
                else if (StartSceneNum == 2)
                {
                    //player1.PrintInventory();
                    Console.WriteLine();
                    Console.WriteLine("1. 장착관리");
                    Console.WriteLine("0. 나가기");
                    int InventoryNum = int.Parse(Console.ReadLine());
                    if (InventoryNum == 1)
                    {
                        Console.WriteLine("장착관리 함수 실행");
                        break;
                    }
                    if (InventoryNum == 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("잘못된 입력입니다.\n1. 상태 보기\n2. 인벤토리\n3. 상점\n원하시는 행동을 입력해주세요.\n>>");
                    }

                }
                else if (StartSceneNum == 3)
                {
                    //market.openMarket();
                    break;
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");
                }
            }
        }
    }
}
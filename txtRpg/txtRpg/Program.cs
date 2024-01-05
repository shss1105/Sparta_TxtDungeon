namespace txtRpg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartScene();
        }

        static void StartScene()
        {
            while (true)
            {
                Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다\n이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
                Console.WriteLine();
                Console.WriteLine("1. 상태 보기\n2. 인벤토리\n3. 상점");
                Console.WriteLine();
                Console.WriteLine("원하시는 행동을 입력해주세요.\n>>");

                int startInput = int.Parse(Console.ReadLine());

                switch (startInput)
                {
                    case 1 :
                        Console.WriteLine();
                        break;
                    case 2 :
                        Console.WriteLine();
                        break;
                case 3 :
                        Console.WriteLine();
                        break;
                default:
                        Console.Clear();
                        Console.WriteLine("잘못된 입력입니다.");
                        break;

                }
            }

        }
    }
}
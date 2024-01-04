namespace SpartaTxt_Dungeon_Inven
{
    public class Inven
    {
        public List<Item> myItems;

        public Inven()
        {
            myItems = new List<Item>();
        }
        public void AddItem(Item item)
        {
            myItems.Add(item);
        }

        public void PrintInventory()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow; // 색변경
            Console.WriteLine("인벤토리");
            Console.ResetColor(); // 색초기화
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine();
            for (int i = 0; i < myItems.Count; i++)
            {
                Console.WriteLine(myItems[i].itemName);
            }
            // player.PrintItemInventory
            // Player 클래스의 프로퍼티인 itemList를 foreach로 순회하면서 item 정보를 출력한다.
            // item type이 0이면 방어 아이템, 1이면 공격 아이템
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Item
    {
        public string itemName;
        public int itemType;  // item type이 0이면 방어 아이템, 1이면 공격 아이템
        public int itemOption; // + 수치
        public string itemDes;  // 아이템 설명
        public int itemPrice;
        bool isSold;  // 구매 완료인지 아닌지


        public Item()
        {

        }
        public Item(string itemName, int itemType, int itemOption, string itemDes, int itemPrice, bool isSold) // 리스트 생성 후 매개변수가 안떳던 이유 : 
        {

        }
    }
}
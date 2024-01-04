namespace SpartaTxt_Dungeon_Item
{
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

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
namespace SpartaTxt_Dungeon_Info
{
    public class Player
    {
        public int Lv;
        public string Name;
        public string Job;
        public int Damage;
        public int armor;
        public int Health;
        public int Gold;

        public void PrintInfo()
        {
            Console.Clear();
            Console.WriteLine($"Lv. {Lv}");
            Console.WriteLine($"{Name} ({Job})");
            Console.WriteLine($"공격력 : {Damage}");
            Console.WriteLine($"방어력 : {armor}");
            Console.WriteLine($"체력 : {Health}");
            Console.WriteLine($"nGold : {Gold}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
namespace Player
{
    internal class Player
    {
        public int Lv;
        public string Name;
        public string Job;
        public int Damage;
        public int armor;
        public int Health;
        public int Gold;
        public List<Item> Items;
        public bool hasItem = false;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
namespace MyGame
{
    public class Item
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Defense { get; set; }
        public int Attack { get; set; }

        public Item(string name, int price, int defense, int attack)
        {
            Name = name;
            Price = price;
            Defense = defense;
            Attack = attack;
        }
    }
}
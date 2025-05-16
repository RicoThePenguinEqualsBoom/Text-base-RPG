namespace Engine
{
    public class Items(int id, int price, string name, string namePlural, string description)
    {
        public int ID { get; set; } = id;
        public int Price { get; set; } = price;
        public string Name { get; set; } = name;
        public string NamePlural { get; set; } = namePlural;
        public string Description { get; set; } = description;
    }
}

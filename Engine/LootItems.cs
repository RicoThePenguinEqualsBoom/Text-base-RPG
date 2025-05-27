namespace Engine
{
    public class LootItems
    {
        public Items Details { get; set; } 
        public int DropChance { get; set; } 
        public bool IsDefaultItem { get; set; }

        public LootItems() { }

        public LootItems(Items details, int dropChance, bool isDefaultItem)
        {
            Details = details;
            DropChance = dropChance;
            IsDefaultItem = isDefaultItem;
        }
    }
}

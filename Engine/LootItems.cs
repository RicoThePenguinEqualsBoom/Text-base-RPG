namespace Engine
{
    public class LootItems(Items details, int dropChance, bool isDefaultItem)
    {
        public Items Details { get; set; } = details;
        public int DropChance { get; set; } = dropChance;
        public bool IsDefaultItem { get; set; } = isDefaultItem;
    }
}

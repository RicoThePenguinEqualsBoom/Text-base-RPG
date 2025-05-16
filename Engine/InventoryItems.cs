namespace Engine
{
    public class InventoryItems(Items details, int quantity)
    {
        public Items Details { get; set; } = details;
        public int Quantity { get; set; } = quantity;
    }
}

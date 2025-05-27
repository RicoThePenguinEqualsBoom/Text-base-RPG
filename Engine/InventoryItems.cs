namespace Engine
{
    public class InventoryItems
    {
        public Items Details { get; set; } 
        public int Quantity { get; set; } 

        public InventoryItems() { }

        public InventoryItems(Items details, int quantity)
        {
            Details = details;
            Quantity = quantity;
        }
    }
}

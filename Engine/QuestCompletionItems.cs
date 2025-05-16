namespace Engine
{
    public class QuestCompletionItems(int quantity, Items details)
    {
        public int Quantity { get; set; } = quantity;
        public Items Details { get; set; } = details;
    }
}

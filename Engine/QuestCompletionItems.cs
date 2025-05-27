namespace Engine
{
    public class QuestCompletionItems
    {
        public int Quantity { get; set; } 
        public Items Details { get; set; } 

        public QuestCompletionItems() { }

        public QuestCompletionItems(int quantity, Items details)
        {
            Quantity = quantity;
            Details = details;
        }
    }
}

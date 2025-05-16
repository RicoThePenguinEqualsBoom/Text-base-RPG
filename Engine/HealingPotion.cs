using System.Diagnostics;
using System.Xml.Linq;

namespace Engine
{
    public class HealingPotion(int id, int price, int amountToHeal, string name, string namePlural, string description)
            : Items(id, price, name, namePlural, description)
    {
        public int AmountToHeal { get; set; } = amountToHeal;
    }
}

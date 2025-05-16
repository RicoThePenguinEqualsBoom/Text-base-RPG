using System.Diagnostics;
using System.Xml.Linq;

namespace Engine
{
    public class Weapons(int id, int price, int minDamage, int maxDamage, string name, string namePlural, string description)
            : Items(id, price, name, namePlural, description)
    {
        public int MinDamage { get; set; } = minDamage;
        public int MaxDamage { get; set; } = maxDamage;
    }
}

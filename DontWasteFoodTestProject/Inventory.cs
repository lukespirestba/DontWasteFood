
namespace DontWasteFoodTestProject
{
    public class Inventory
    {
        List<InventoryItem> items = new();

        public List<InventoryItem> GetToExpireItems()
        {
            return items.Where(i => i.IsDueToExpire).ToList();
        }

        internal void Add(string name, DateTime expiryDate)
        {
            items.Add(new InventoryItem(name, expiryDate));
        }
    }
}
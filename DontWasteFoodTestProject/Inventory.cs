
namespace DontWasteFoodTestProject
{
    public class Inventory
    {
        List<InventoryItem> items;

        public Inventory()
        { 
            items = new List<InventoryItem>() { new InventoryItem(DateTime.UtcNow), new InventoryItem(DateTime.UtcNow.AddDays(10)) };
        }

        public List<InventoryItem> GetToExpireItems()
        {
            return items.Where(i => i.IsDueToExpire).ToList();
        }
    }
}
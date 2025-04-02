namespace DontWasteFoodTestProject
{
    public class InventoryTests
    {
        [Test]
        public void WithPersihableItemsInStockThatAreDueToExpire_PersonChecksInventory_ItemsDueToExpireAreBroughtToAttention()
        {
            Inventory inventory = new();
            List<InventoryItem> inventoryItems = inventory.GetToExpireItems();

            Assert.That(inventoryItems.Count > 0);
            Assert.That(inventoryItems.All(i => i.IsDueToExpire));
        }
    }
}
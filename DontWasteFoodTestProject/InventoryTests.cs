using NUnit.Framework.Interfaces;

namespace DontWasteFoodTestProject
{
    public class InventoryTests
    {
        [Test]
        public void WithPersihableItemsInStockThatAreDueToExpire_PersonChecksInventory_ItemsDueToExpireAreBroughtToAttention()
        {
            Inventory inventory = new();
            inventory.Add("Item1", DateTime.UtcNow);
            inventory.Add("Item2", DateTime.UtcNow.AddDays(10));

            List<InventoryItem> inventoryItems = inventory.GetToExpireItems();

            Assert.That(inventoryItems.Count > 0);
            Assert.That(inventoryItems.All(i => i.IsDueToExpire));
        }

        [Test]
        public void WithBreadThatIsDueToExpire_PersonChecksInventory_BreadIsBroughtToAttention()
        {
            Inventory inventory = new();
            inventory.Add("Bread", DateTime.UtcNow.Date.AddDays(2).Date);

            List<InventoryItem> inventoryItems = inventory.GetToExpireItems();

            Assert.Multiple(() =>
            {
                Assert.That(inventoryItems, Has.Count.EqualTo(1));
                Assert.That(inventoryItems.First().Name, Is.EqualTo("Bread"));
                Assert.That(inventoryItems.First().IsDueToExpire);
            });
        }
    }
}
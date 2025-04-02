namespace DontWasteFoodTestProject
{
    public class InventoryItem
    {
        public string Name { get; internal set; }
        public bool IsDueToExpire { get; internal set; }

        public InventoryItem(string name, DateTime expiryDate)
        {
            Name = name;
            IsDueToExpire = expiryDate.AddDays(-3).Date <= DateTime.UtcNow.Date;
        }
    }
}
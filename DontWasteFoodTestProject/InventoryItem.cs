namespace DontWasteFoodTestProject
{
    public class InventoryItem
    {
        public bool IsDueToExpire { get; internal set; }

        public InventoryItem(DateTime expiryDate)
        {
            IsDueToExpire = expiryDate.AddDays(-3).Date <= DateTime.UtcNow.Date;
        }
    }
}
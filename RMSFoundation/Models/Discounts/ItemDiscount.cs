namespace RMSFoundation.Models.Discounts
{
    public class ItemDiscount : Discount
    {
        public override string ToString()
        {
            return $"ItemDiscount> AmountUnit: {AmountUnit.ToString()}, Amount: {Amount}";
        }
    }
}

using RMSEnumerations;
using System;

namespace RMSFoundation.Models.Discounts
{
    public class GeneralDiscount : Discount
    {
        public string Name { get; set; } = "";
        public override double Amount { get; set; }
        public override Units AmountUnit { get; set; } = Units.Percentage;
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public DiscountType DiscountType { get; set; }
        public override string ToString()
        {
            return $"General Discount> Name: {Name}, AmountUnit: {AmountUnit.ToString()}, Amount: {Amount}, FromDate: {From.ToShortDateString()}, ToDate: {To.ToShortDateString()}, DiscountType: {DiscountType.ToString()}";
        }
        public override double ApplyExclusive(double amount)
        {
            switch (DiscountType)
            {
                case DiscountType.Daily:
                    if (TimeSpan.Compare(DateTime.Now.TimeOfDay, From.TimeOfDay) >= 0 && TimeSpan.Compare(DateTime.Now.TimeOfDay, To.TimeOfDay) <= 0)
                        return _applyExclusive(amount);
                    break;
                case DiscountType.Limited:
                    if (DateTime.Compare(DateTime.Now, From) >= 0 && DateTime.Compare(DateTime.Now, To) <= 0)
                        return _applyExclusive(amount);
                    break;
                case DiscountType.Unlimited:
                    return _applyExclusive(amount);
                default:
                    return amount;
            }
            return amount;
        }
        public override double ApplyInclusive(double amount)
        {
            switch (DiscountType)
            {
                case DiscountType.Daily:
                    if (TimeSpan.Compare(DateTime.Now.TimeOfDay, From.TimeOfDay) >= 0 && TimeSpan.Compare(DateTime.Now.TimeOfDay, To.TimeOfDay) <= 0)
                        return _applyInclusive(amount);
                    break;
                case DiscountType.Limited:
                    if (DateTime.Compare(DateTime.Now, From) >= 0 && DateTime.Compare(DateTime.Now, To) <= 0)
                        return _applyInclusive(amount);
                    break;
                case DiscountType.Unlimited:
                    return _applyInclusive(amount);
                default:
                    return amount;
            }
            return amount;
        }
        public override bool Equals(object? obj)
        {
            return obj is GeneralDiscount discount &&
                   Amount == discount.Amount &&
                   AmountUnit == discount.AmountUnit &&
                   Name == discount.Name &&
                   Amount == discount.Amount &&
                   AmountUnit == discount.AmountUnit &&
                   From == discount.From &&
                   To == discount.To &&
                   DiscountType == discount.DiscountType;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Amount, AmountUnit, Name, Amount, AmountUnit, From, To, DiscountType);
        }
        private double _applyExclusive(double amount)
            => AmountUnit switch
            {
                Units.Percentage => amount - (amount * (Amount / 100)),
                Units.Amount => amount - (amount - Amount),
                _ => amount,
            };
        private double _applyInclusive(double amount) => AmountUnit switch
        {
            Units.Percentage => amount - (amount * (Amount / 100)),
            Units.Amount => amount - (amount - Amount),
            _ => amount,
        };
    }
}

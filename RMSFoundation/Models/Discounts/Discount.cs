using System;
using ;

namespace RMSFoundation.Models.Discounts
{
    public abstract class Discount
    {
        public virtual double Amount { get; set; }
        public virtual Units AmountUnit { get; set; } = Units.Percentage;
        public virtual double ApplyExclusive(double amount)
            => AmountUnit switch
            {
                Units.Percentage => amount - (amount * (Amount / 100)),
                Units.Amount => amount - (amount - Amount),
                _ => amount,
            };
        public virtual double ApplyInclusive(double amount) => AmountUnit switch
        {
            Units.Percentage => amount - (amount * (Amount / 100)),
            Units.Amount => amount - (amount - Amount),
            _ => amount,
        };

        public override bool Equals(object? obj)
        {
            return obj is Discount discount &&
                   Amount == discount.Amount &&
                   AmountUnit == discount.AmountUnit;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Amount, AmountUnit);
        }
    }
}

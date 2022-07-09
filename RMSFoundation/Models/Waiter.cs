using System.Collections.Generic;
using RMSEnumerations;

namespace RMSFoundation.Models
{
    public class Waiter
    {
        public string Name { get; set; } = string.Empty;
        public Commission Commission { get; set; } = new Commission();
        
        public override bool Equals(object? obj)
        {
            return obj is Waiter waiter &&
                   Name == waiter.Name &&
                   EqualityComparer<Commission>.Default.Equals(Commission, waiter.Commission);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"Name: {Name}, CommissionUnit: {Commission.AmountUnit.ToString()}, CommissionAmount: {Commission.Amount}";
        }
    }
}

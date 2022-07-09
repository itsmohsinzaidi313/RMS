using System;
using RMSEnumerations;

namespace RMSFoundation.Models
{
    public class Commission
    {
        public double Amount { get; set; }
        public Units AmountUnit { get; set; }
        internal bool Enabled { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Commission commission &&
                   Amount == commission.Amount &&
                   AmountUnit == commission.AmountUnit &&
                   Enabled == commission.Enabled;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Amount, AmountUnit, Enabled);
        }

        public override string ToString()
        {
            return $"Commission> AmountUnit: {AmountUnit.ToString()}, Amount: {Amount}, Enabled: {Enabled}";
        }
        
    }
}

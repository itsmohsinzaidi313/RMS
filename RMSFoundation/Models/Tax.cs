using System;

namespace RMSFoundation.Models
{
    public class Tax
    {
        public string Name { get; set; } = string.Empty;
        public double Percentage { get; set; }
        public double ApplyExclusive(double amount) => amount + (Percentage / 100);
        public double ApplyInclusive(double amount) => amount + (amount + (Percentage / 100));
        public override bool Equals(object? obj)
        {
            return obj is Tax tax && Percentage == tax.Percentage;
        }
        public override int GetHashCode() => HashCode.Combine(Percentage);

        public override string ToString()
        {
            return $"Tax> Name: {Name}, Percentage: {Percentage}";
        }
    }
}

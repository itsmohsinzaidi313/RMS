using System;
using System.Collections.Generic;
using RMSEnumerations;

namespace RMSFoundation.Models
{
    public class Rider
    {
        public string Name { get; set; } = string.Empty;
        public RiderStatus Status { get; set; }
        public Commission Commission { get; set; } = new Commission();

        public override bool Equals(object? obj)
        {
            return obj is Rider rider &&
                   Name == rider.Name &&
                   Status == rider.Status &&
                   EqualityComparer<Commission>.Default.Equals(Commission, rider.Commission);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Status, Commission);
        }
    }
}

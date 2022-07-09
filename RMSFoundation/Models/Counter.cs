using System;

namespace RMSFoundation.Models
{
    public class Counter
    {
        public string Name { get; set; } = string.Empty;
        public string UUID { get; set; } = "";

        public override bool Equals(object? obj)
        {
            return obj is Counter counter &&
                   Name == counter.Name &&
                   UUID == counter.UUID;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, UUID);
        }

        public override string ToString()
        {
            return $"Counter> Name: {Name}, UUID: {UUID}";
        }
        
    }
}

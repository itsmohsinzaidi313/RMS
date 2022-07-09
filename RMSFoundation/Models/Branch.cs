using System;

namespace RMSFoundation.Models
{
    public class Branch
    {
        public string Name { get; set; } = "";

        public override bool Equals(object? obj)
        {
            return obj is Branch branch &&
                   Name == branch.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name);
        }

        public override string ToString()
        {
            return $"Branch> Name: {Name}";
        }

    }
}
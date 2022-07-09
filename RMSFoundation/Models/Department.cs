using System;

namespace RMSFoundation.Models
{
    public class Department
    {
        public string Name { get; set; } = "";

        public override bool Equals(object? obj)
        {
            return obj is Department department &&
                   Name == department.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name);
        }

        public override string ToString()
        {
            return $"Department> Name: {Name}";
        }
    }
}
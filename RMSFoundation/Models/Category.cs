using System;

namespace RMSFoundation.Models
{
    public class Category
    {
        public string Name { get; set; } = "";

        public override bool Equals(object? obj)
        {
            return obj is Category category &&
                   Name == category.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name);
        }

        public override string ToString()
        {
            return $"Category> Name: {Name}";
        }
        
    }
}

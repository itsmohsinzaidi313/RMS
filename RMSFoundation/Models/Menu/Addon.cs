using System;

namespace RMSFoundation.Models.Menu
{
    public class Addon
    {
        public string Name { get; set; } = "";
        public double Price { get; set; }
        public bool Selected { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Addon addon &&
                   Name == addon.Name &&
                   Price == addon.Price &&
                   Selected == addon.Selected;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Price, Selected);
        }

        public override string ToString()
        {
            return $"Addon> Name: {Name}, Price: {Price}, Selected: {Selected}";
        }
    }
}

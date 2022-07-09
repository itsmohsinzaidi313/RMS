using System;
using System.Collections.Generic;
using RMSFoundation.Models.Discounts;

namespace RMSFoundation.Models.Menu
{
    public class Item : MenuItem
    {
        public List<Addon> Addons { get; set; } = new List<Addon>();
        public override double SubTotal
        {
            get
            {
                double addonsAmount = 0;
                Addons.ForEach(x => addonsAmount += x.Price);
                return (UnitPrice * Quantity) + addonsAmount;
            }
        }

        public override bool Equals(object? obj)
        {
            return obj is Item item &&
                   base.Equals(obj) &&
                   Name == item.Name &&
                   EqualityComparer<Category>.Default.Equals(Category, item.Category) &&
                   UnitPrice == item.UnitPrice &&
                   Quantity == item.Quantity &&
                   EqualityComparer<Tax>.Default.Equals(Tax, item.Tax) &&
                   EqualityComparer<ItemDiscount>.Default.Equals(Discount, item.Discount) &&
                   TotalDiscount == item.TotalDiscount &&
                   SubTotal == item.SubTotal &&
                   TaxAmount == item.TaxAmount &&
                   NetAmount == item.NetAmount &&
                   EqualityComparer<List<Addon>>.Default.Equals(Addons, item.Addons) &&
                   SubTotal == item.SubTotal;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(base.GetHashCode());
            hash.Add(Name);
            hash.Add(Category);
            hash.Add(UnitPrice);
            hash.Add(Quantity);
            hash.Add(Tax);
            hash.Add(Discount);
            hash.Add(TotalDiscount);
            hash.Add(SubTotal);
            hash.Add(TaxAmount);
            hash.Add(NetAmount);
            hash.Add(Addons);
            hash.Add(SubTotal);
            return hash.ToHashCode();
        }

        public override string ToString()
        {
            return $"Item> Name: {Name}, Category: {Category.Name}, UnitPrice: {UnitPrice}, Quantity: {Quantity}";
        }
    }
}

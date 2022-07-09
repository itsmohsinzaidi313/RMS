using System;
using System.Collections.Generic;
using System.Linq;
using RMSFoundation.Models.Discounts;

namespace RMSFoundation.Models.Menu
{
    public class Deal : Item
    {
        public IList<DealItem> DealItems { get; set; } = new List<DealItem>();

        public override double SubTotal => base.SubTotal;

        public override bool Equals(object? obj)
        {
            return obj is Deal deal &&
                   base.Equals(obj) &&
                   Name == deal.Name &&
                   EqualityComparer<Category>.Default.Equals(Category, deal.Category) &&
                   UnitPrice == deal.UnitPrice &&
                   Quantity == deal.Quantity &&
                   EqualityComparer<Tax>.Default.Equals(Tax, deal.Tax) &&
                   EqualityComparer<ItemDiscount>.Default.Equals(Discount, deal.Discount) &&
                   TotalDiscount == deal.TotalDiscount &&
                   SubTotal == deal.SubTotal &&
                   TaxAmount == deal.TaxAmount &&
                   NetAmount == deal.NetAmount &&
                   EqualityComparer<List<Addon>>.Default.Equals(Addons, deal.Addons) &&
                   SubTotal == deal.SubTotal &&
                   EqualityComparer<IList<DealItem>>.Default.Equals(DealItems, deal.DealItems) &&
                   SubTotal == deal.SubTotal;
        }

        // public override bool Equals(object obj)
        // {
        //     if (obj is not Deal)
        //     {
        //         return false;
        //     }

        //     if (this == null || obj == null)
        //     {
        //         return false;
        //     }

        //     if ((obj as Deal).DealItems.Count != DealItems.Count)
        //     {
        //         return false;
        //     }

        //     string thisItemNames = string.Empty;
        //     string objItemNames = string.Empty;
        //     DealItems.ToList().ForEach(x => thisItemNames += x.Name);
        //     (obj as Deal).DealItems.ToList().ForEach(x => objItemNames += x.Name);

        //     return base.Equals(thisItemNames.ToUpper().Equals(objItemNames.ToUpper()));
        // }



        public override int GetHashCode()
        {
            int hashCode = 0;
            DealItems.ToList().ForEach(x => hashCode += x.GetHashCode());
            return hashCode;
        }

        public override string ToString()
        {
            return $"Deal> Name: {Name}, Category: {Category.Name}, UnitPrice: {UnitPrice}, Quantity: {Quantity}";
        }
    }

    public class DealItem : MenuItem
    {
        public int Choice { get; set; } = 0;

        public override double SubTotal => base.SubTotal;

        public override bool Equals(object? obj)
        {
            return obj is DealItem item &&
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
                   Choice == item.Choice;
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
            hash.Add(Choice);
            return hash.ToHashCode();
        }

        public override string ToString()
        {
            return $"DealItem> Name: {Name}, Category: {Category.Name}, UnitPrice: {UnitPrice}, Quantity: {Quantity}";
        }
    }
}

using System;
using System.Collections.Generic;
using RMSFoundation.Models;
using RMSFoundation.Models.Discounts;
using RMSFoundation.Models.Menu;

public class Menu
{
    public List<Category> Categories { get; set; } = new List<Category>();
    public List<MenuItem> Items { get; set; } = new List<MenuItem>();

    public override bool Equals(object? obj)
    {
        return obj is Menu menu &&
               EqualityComparer<List<Category>>.Default.Equals(Categories, menu.Categories) &&
               EqualityComparer<List<MenuItem>>.Default.Equals(Items, menu.Items);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Categories, Items);
    }
}
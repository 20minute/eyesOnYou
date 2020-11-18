using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> items;
    public int capacity = 1;

    void BuildInventory()
    {
        items = new List<Item>();
    }

    void GetItem(Item item)
    {
        if (items.Count > 0)
        {
            return;
        }
        this.items.Add(item);
    }

    void UseItem()
    {

    }

    void DelteItem()
    {
        this.items = new List<Item>();
    }

}

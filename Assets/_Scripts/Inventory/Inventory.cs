using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> characterItems = new List<Item>();
    public ItemDataBase ItemDataBase;

    private void Start()
    {
        GiveItems(0);
    }

    public void GiveItems(int id)
    {
        Item itemToAdd = ItemDataBase.GetItem(id);
        if (characterItems.Count > 0)
        {
            Debug.Log("can not add because player already has an item: " + characterItems.First().title);
            return;
        }
        else
        {
            characterItems.Add(itemToAdd);
        }
        Debug.Log("Add Item :" + itemToAdd.title);
    }

}

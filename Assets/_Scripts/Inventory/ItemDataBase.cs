using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDataBase : MonoBehaviour
{
    public List<Item> items = new List<Item>();

    private void Awake()
    {
        BuildItemDataBase();
    }

    void BuildItemDataBase()
    {
        items = new List<Item>() { 
            new Item(0, "Test Item 1", "Test 1",
            new Dictionary<string, int> {
                { "String 1", 1 },
                { "String 2", 2 } 
            })};
    }

    public Item GetItem(int id)
    {
        return items.Find(item => item.id == id);
    }

    public Item GetItem(string itemName)
    {
        return items.Find(item => item.title == itemName);
    }

}

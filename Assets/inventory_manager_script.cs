using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class inventory_manager_script : MonoBehaviour
{
    List<InventoryItem> items = new List<InventoryItem>();
    public void addItem(InventoryItem myObject)
    {
        foreach(InventoryItem item in items)
        {
            if(item.name == myObject.name)
            {
                item.value += 1;
                return;
            }
        }
        items.Add(myObject);

    }
    public void removeItem(InventoryItem myObject)
    {
        items.Remove(myObject);
    }
    public void displayItems()
    {
        foreach(InventoryItem item in items) {
            Debug.Log($"{item.name}x{item.value} {item.description}");
        }
    }
}

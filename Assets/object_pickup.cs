using UnityEngine;
public class InventoryItem{
    public string name;
    public int value;
    public string description;
    public InventoryItem(string name,string description)
    {
        this.name = name;
        this.description = description;
        this.value = 1;
    }
}
public class object_pickup :MonoBehaviour
{
    public string item_name;
    public string description;
    inventory_manager_script inventory;
    private void Start()
    {
        inventory = FindFirstObjectByType<inventory_manager_script>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        InventoryItem myobject = new InventoryItem(item_name,description);
        Debug.Log($"I am picked! {myobject.name}");
        inventory.addItem(myobject);
        Destroy(gameObject);
    }

    
}

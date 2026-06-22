using UnityEngine;
public class movement_script : MonoBehaviour
{

    public inventory_manager_script inventory;

    void Update()
    {
        if (Input.GetKey(KeyCode.D)) transform.position += Vector3.right*Time.deltaTime*5f;
        else if (Input.GetKey(KeyCode.A)) transform.position += Vector3.left*Time.deltaTime*5f;
        if (Input.GetKeyDown(KeyCode.F)) inventory.displayItems();

    }
}

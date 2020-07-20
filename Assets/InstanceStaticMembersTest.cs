using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public string name;
    public int itemID;

    //shared across all items
    public static int itemCount;

    public Item()
    {

        itemCount++;
    }
}

public class InstanceStaticMembersTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Item sword = new Item();
        Item bread = new Item();
        Item cape = new Item();
        Item fish = new Item();

        Debug.Log("Number of items: " + Item.itemCount);
    }


}

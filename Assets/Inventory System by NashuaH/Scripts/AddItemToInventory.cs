using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// IN THIS SCRIPT: Use this script to Add a specific or random item to the Inventory
// WARNING: This script uses UNITY Editor to simplify the process of setting it up
// USE THIS SCRIPT by attaching it next to the script that calls the AddItem() and set up what you want to Add to the inventory in the Editor

public class AddItemToInventory : MonoBehaviour
{
    // The one bool you set up true is the type of AddItem you want to use
    // The specificItemGive let's you set up a specific Item and quantity to add to the Inventory
    // The randomItemGive let's you choose from a range of items to randomly add to the Inventory
    public bool specificItemGive, randomItemGive;

    // In case of random, this list becomes active in the Editor
    public List<Item> itemsToGive = new List<Item>();

    // In case of specific, this two parameters become active in the Editor
    public Item specificItem;
    public int specificQuant;


    // AddItem() is currenlty called by a UI button but you can call it from other script in the same GameObject by using:
    // GetComponent<AddItemToInventory>().AddItem();
    // Don't forget to set up the item you want to give in the Editor
    public void AddItem()
    {
        if(specificItemGive && randomItemGive == false)
        {
            AddSpecificItem();
        }else
       if (specificItemGive == false && randomItemGive)
        {
            AddRandom();
        }

    }

    // Adds the specific item and quantity you set up in the Editor to the Inventory
   void AddSpecificItem()
    {
        Inventory.instance.AddItem(specificItem, specificQuant);
    }

    // Adds one random Item from the pre selected list to the Inventory
    // The quantity is also random between 1 and 4
    void AddRandom()
    {
        Inventory.instance.AddItem(itemsToGive[Random.Range(0, itemsToGive.Count)], Random.Range(1, 5));
    }

}


-----------------------Basic Inventory System -------------------------------

Thank you for downoloading my first asset, I hope it serves you well in your projects

You can Add or Remove Items from the Inventory by using the following line on any script: Inventory.instance.Add(itemToAddHere, quantityHere); / Inventory.instance.Remove(itemToRemoveHere, quantityHere);

To setup your own Inventory you just need to make an Inventory Slot Prefab with the InventorySlot (Script) attached with an Image and Text as child Objects 
The Image to show the icon of the Item and the text to show the quantity
Put as many slots as you want inside a parent game object that you should reference to the Inventory (Script)
You can check up the example and replicate it or adpat it for an easy start

This Asset also supports Saving of the Inventory to save the progress made for later sessions
To use this corretly you need to add all Items you create for you game in the Inspector of Save Sytem(script) and in the correct order of their ID 
Remember: Every Item must have a different ID by order and be placed in the List of the Inspecto BY ORDER

The Icons in the Example for the Items are Icons made by Lorc. Available on https://game-icons.net

If you can't Build your game because of errors in the Editor Scripts just put /* in the beginning and */ in the end of every script with "Editor" in the end
If you think that the Editors are not necessary you can delete them from the project too(The Inventory System will still run)

Thank You one more time and don't forget to check my other assets that are extensions of this one

Bugs Corrected:
- The Item/Consumable menu is now done but note that the consumable item is just an example and does not work as a consumable, it's just an example of different items
- Bug in the Inventory.AddItem function corrected. It used to give one non-stackable item plus the ones tje user wanted to give.

Note: To create a new item just right-click in the Project Folder(inside Unity) and then Create --> Item ---> Choose the type of item


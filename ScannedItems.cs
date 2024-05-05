using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections.Generic;
using UnityEngine;

public class ScannedItemsManager : MonoBehaviour
{
    public List<GameObject> scannedItems = new List<GameObject>();

    public void AddScannedItem(GameObject item)
    {
        scannedItems.Add(item);
        // You can update UI or perform any other actions here based on the scanned item.
    }
}
